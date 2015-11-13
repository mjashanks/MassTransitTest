using MassTransit;
using Mtt.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Subscriber.Consumers
{
    public class ErrorConsumer : IConsumer<Error>
    {
        public async Task Consume(ConsumeContext<Error> context)
        {
            await Console.Out.WriteLineAsync(string.Format("ERROR:{0}",context.Message.Exception));
        }
    }
}
