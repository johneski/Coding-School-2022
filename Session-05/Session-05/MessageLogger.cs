using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger : Logger
    {
        public Message[] Messages { get; set; }
        private int _numOfMsgs;
        private int _index = 0;

        public MessageLogger(int numOfMsgs = 1000)
        {
            Messages = new Message[numOfMsgs];
            _numOfMsgs = numOfMsgs;
        }

        public override string ReadAll()
        {
            string allMessages = string.Empty;
            try
            {
                foreach (Message message in Messages)
                {
                    allMessages += message.MessageTxt + "\n";
                }
            }
            catch(NullReferenceException ex)
            {
                
            }
            

            return allMessages;
        }

        public override void Clear()
        {
            Messages = new Message[_numOfMsgs];
        }

        public override void Write(Message msg)
        {
            Messages[_index] = msg;
            _index++;
        }
    }
}
