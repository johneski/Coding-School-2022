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
            decimal value;
            Message msg;


            if (request.Action == Enumerations.ActionEnum.Convert)
            {
                msg = new Message("Transaction type: Convert");


                if (decimal.TryParse(request.Input, out value))
                {
                    response.Output = DecimalToBinary(request);
                    msg.Append(response.Output);
                }
                else
                {
                    msg.Append("Couldn't convert to binary!");
                    response.Output = "Couldn't convert to binary! Please check the input.";
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
                    response.Output = "Something went wrong!";
                    msg.Append("Couldn't convert to UpperCase!");
                }
            }
            else if (request.Action == Enumerations.ActionEnum.Reverse)
            {
                msg = new Message("Transaction type: Reverse");

                if (request.Input.GetType() == typeof(string))
                {
                    response.Output = ReverseStringRecursion(request.Input);
                    msg.Append("Reversed string: " + response.Output);
                }
                else
                {
                    response.Output = "Couldn't reverse the string. Please check the input";
                    msg.Append("Couldn't reverse the string!");
                }
            }
            else
            {
                response.Output = "There is no such action. Please try again!";

                msg = new Message("Transaction type: Error");
                msg.Append("Wrong transaction type!");
            }


            Logger.Write(msg);

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
            decimal floatPart = decimal.Parse("0," + s[1]);

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

        public static string ReverseStringRecursion(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + ReverseStringRecursion(str.Substring(0, str.Length - 1));
            else
                return str;
        }
        private string ReverseString(string name)
        {
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            return new string(nameArray);
        }
    }
}
