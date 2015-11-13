using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Contracts
{
    public interface ReportApproval
    {
        bool Approved { get; set; }
        string ApprovalNotes { get; set; }
    }
}
