using MassTransit;
using MassTransit.RabbitMqTransport;
using Mtt.Contracts;
using Mtt.Publisher.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            IBusControl busControl = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                var host = sbc.Host(new Uri("rabbitmq://ubuntu-vbvm"), h =>
                {
                    h.Username("bluezinc");
                    h.Password("blu3z1nc");
                });

                sbc.UseRetry(Retry.Immediate(5));

                //sbc.ReceiveEndpoint(host, "mtt", ep =>
                //{
                //    ep.Consumer<MyConsumer>();
                //});
            });

            busControl.Start();

            var input = "";
            while (input != "exit")
            {
                try
                {
                    input = Console.ReadLine();
                    var parts = input.Split(':');
                    Repeat(busControl, parts[0], int.Parse(parts[1]));
                }
                catch (Exception ex)
                {
                    busControl.Publish<Error>(new ErrorMessage { Exception = ex.ToString() });
                }
            }

            busControl.Stop();
        }

        private static void Repeat(IBusControl bus, string command, int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (command == "approval")
                {
                    bus.Publish<ReportApproval>(new ReportApprovalMessage
                    {
                        Approved = (times % 2) == 0,
                        ApprovalNotes = "this is the " + i + " time "
                    });
                }
                else if (command == "newref")
                {
                    bus.Publish<NewReferral>(new NewReferralMessage
                    {
                        Name = "Mr Michael Shanks the " + i,
                        DateOfBirth = DateTime.Now.AddYears(-20),
                        NoOfAuthorisations = i
                    });
                }
                else
                {
                    throw new Exception("Could not find command " + command);
                }
            }


        }
    }
}
