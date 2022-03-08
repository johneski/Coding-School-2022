using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionRequest
    {
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public Enumerations.ActionEnum Action;

        public ActionRequest(string input, Enumerations.ActionEnum action)
        {
            RequestID = Guid.NewGuid();
            Input = input;
            Action = action;
        }
    }
}
