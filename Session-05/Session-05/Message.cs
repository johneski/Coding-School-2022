using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string MessageTxt { get; set; }

        public Message(string msg = "")
        {
            MessageTxt = msg;
            TimeStamp = DateTime.Now;
            ID = Guid.NewGuid();
        }
    }
}
