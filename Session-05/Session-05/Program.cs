using Session_05;

var request = new ActionRequest("hello world", Enumerations.ActionEnum.Reverse);
Console.WriteLine(request.Action);
var response = new ActionResolver().Execute(request);
Console.WriteLine(response.Output);
