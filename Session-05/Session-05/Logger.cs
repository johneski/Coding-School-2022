using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal abstract class Logger
    {
        public abstract Message[] ReadAll();
        public abstract void Clear();
        public abstract void Write(Message msg);
    }
}
