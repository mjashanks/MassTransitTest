using MassTransit;
using MassTransit.RabbitMqTransport;
using Mtt.Subscriber.Consumers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(x =>
            {
                var host = x.Host(new Uri("rabbitmq://ubuntu-vbvm/"), h =>
                {
                    h.Username("bluezinc");
                    h.Password("blu3z1nc");
                });

                x.ReceiveEndpoint(host, "mtt", e =>
                    {
                        e.Consumer<ErrorConsumer>();
                        e.Consumer<NewReferralConsumer>();
                        e.Consumer<ReportApprovalConsumer>();
                    });
            });
            var busHandle = bus.Start();
            Console.ReadKey();
            busHandle.Stop();


        }
    }
}
