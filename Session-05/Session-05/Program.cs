using Session_05;

var request = new ActionRequest("125,125");
var response = new ActionResolver().Execute(request);
Console.WriteLine(response.Output);
