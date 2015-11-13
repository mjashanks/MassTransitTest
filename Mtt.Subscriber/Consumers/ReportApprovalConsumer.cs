using MassTransit;
using Mtt.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Subscriber.Consumers
{
    public class ReportApprovalConsumer : IConsumer<ReportApproval>
    {
        public async Task Consume(ConsumeContext<ReportApproval> context)
        {
            await Console.Out.WriteLineAsync(string.Format("Approved: {0}, Notes: {1}",
                context.Message.Approved, context.Message.ApprovalNotes));

        }
    }
}
