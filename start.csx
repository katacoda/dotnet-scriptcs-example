using System.Dynamic;

public class TestController : ApiController
{
  public dynamic Get() {
    dynamic obj = new ExpandoObject();
    obj.message = "Hello from Web Api";
    return obj;
  }
}

var webapi = Require<WebApi>();

var server = webapi.
Configure(typeof(TestController)).
UseJsonOnly().
Start("http://+:8080");

Console.WriteLine("Listening...");
Console.ReadLine();
server.Dispose();
