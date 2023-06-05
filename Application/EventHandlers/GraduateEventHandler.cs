using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EventHandlers
{
    public class GradeEventHandler : EventArgs
    {
        public string Message { get; }
        public GradeEventHandler(string message)
        {
            Message = message;
        }
    }
}
