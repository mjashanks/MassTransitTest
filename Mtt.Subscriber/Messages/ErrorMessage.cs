using Mtt.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtt.Subscriber.Messages
{
    public class ErrorMessage : Error
    {
        public string Exception { get; set; }
    }
}
