using Session_05;

var actionResolver = new ActionResolver();
var request = new ActionRequest("hello world", Enumerations.ActionEnum.Reverse);
var response = actionResolver.Execute(request);
Console.WriteLine(response.Output);
request = new ActionRequest("123,456", Enumerations.ActionEnum.Convert);
response = actionResolver.Execute(request);
Console.WriteLine(response.Output);
request = new ActionRequest("hello world ", Enumerations.ActionEnum.UpperCase);
response = actionResolver.Execute(request);
Console.WriteLine(response.Output);
Console.WriteLine(actionResolver.Logger.ReadAll());
