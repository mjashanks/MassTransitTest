using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Contracts
{
    public interface NewReferral
    {
        string Name { get; set; }
        DateTime DateOfBirth {get; set;}
        int NoOfAuthorisations { get; set; }
    }
}
