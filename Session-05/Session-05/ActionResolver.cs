using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }

        public ActionResolver()
        {
            Logger = new MessageLogger();
        }


        public ActionResponse Execute(ActionRequest request)
        {
            var response = new ActionResponse();
            var logger = new MessageLogger();
            decimal value;
            Message msg;


            if (request.Action == Enumerations.ActionEnum.Convert)
            {
                msg = new Message("Transaction type: Convert\n");


                if (decimal.TryParse(request.Input, out value))
                {
                    response.Output = DecimalToBinary(request);
                    msg.Append(response.Output);
                }
                else
                {
                    msg.Append("Something went wrong!");
                }

            }
            else if (request.Action == Enumerations.ActionEnum.UpperCase)
            {
                msg = new Message("Transaction type: UpperCase");

                if(request.Input.GetType() == typeof(string) && request.Input.Split(" ").Length > 1)
                {
                    string longestWord = FindLongestWord(request.Input.Split(" "));
                    response.Output = longestWord.ToUpper();
                    msg.Append("Longest word to Upper: " + response.Output);
                }
                else
                {
                    msg.Append("Something went wrong!");
                }
            }
            else if (request.Action == Enumerations.ActionEnum.Reverse)
            {
                msg = new Message("Transaction type: Reverse");

                if (request.Input.GetType() == typeof(string))
                {
                    response.Output = ReverseString(request.Input);
                }
            }
            else
            {
                response.Output = "There is no such action. Please try again!";
                msg = new Message("Wrong transaction type!");
            }


            logger.Write(msg);

            return response;
        }

        private string FindLongestWord(string[] array)
        {
            int longest = array.Max(s => s.Length);
            string longestWord = array.FirstOrDefault(s => s.Length == longest);

            return longestWord;
        }

        private string DecimalToBinary(ActionRequest req)
        {
            string[] s = req.Input.Split(",");
            int intPart = int.Parse(s[0]);
            decimal floatPart = decimal.Parse("0,"+s[1]);

            string result = Convert.ToString(intPart, 2) + ",";
            int numOfIterations = 0;
            do
            {
                floatPart *= 2;
                result += Convert.ToString((int)floatPart);
                
                floatPart -= (int)floatPart;
                numOfIterations++;
            } while (numOfIterations < 20 && floatPart != 0);



            return result;

        }

        private string ReverseString(string name)
        {
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            return new string(nameArray);
        }
    }
}
