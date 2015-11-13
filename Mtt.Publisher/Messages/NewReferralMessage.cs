using Mtt.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Publisher.Messages
{
    public class NewReferralMessage : NewReferral
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int NoOfAuthorisations { get; set; }
    }
}
