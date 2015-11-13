using MassTransit;
using Mtt.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Subscriber.Consumers
{
    public class NewReferralConsumer : IConsumer<NewReferral>
    {
        public async Task Consume(ConsumeContext<NewReferral> context)
        {
            await Console.Out.WriteLineAsync(string.Format("Name:{0}, Auth={1}, DoB={2}",
                context.Message.Name, context.Message.NoOfAuthorisations, context.Message.DateOfBirth));
        }
    }
}
