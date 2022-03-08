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

            if(request.Action == Enumerations.ActionEnum.Convert)
            {
                if (decimal.TryParse(request.Input, out value))
                {
                    response.Output = ToBinary(request);

                }
            }


            return response;
        }


        private string ToBinary(ActionRequest req)
        {
            string[] s = req.Input.Split(",");
            int intPart = int.Parse(s[0]);
            decimal floatPart = decimal.Parse("0,"+s[1]);

            string result = Convert.ToString(intPart, 2) + ",";
            int numOfIterations = 0;
            do
            {

                result += Convert.ToString((int)floatPart * 2);
                floatPart -= (int)floatPart;
                numOfIterations++;
            } while (floatPart != 0 || numOfIterations > 20);



            return result;

        }
    }
}
