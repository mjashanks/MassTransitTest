using Mtt.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Subscriber.Messages
{
    public class ReportApprovalMessage : ReportApproval
    {
        public bool Approved { get; set; }

        public string ApprovalNotes { get; set; }
    }
}
