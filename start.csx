using System.Dynamic;

public class MachineController : ApiController
{
  // *:8080/api/machine
  public dynamic Get() {
    dynamic obj = new ExpandoObject();
    obj.message = "Hello from Web Api via ScriptCS! Processed by " + System.Environment.MachineName;
    return obj;
  }
}

var webapi = Require<WebApi>();

var server = webapi.
Configure(typeof(MachineController)).
UseJsonOnly().
Start("http://+:8080");

Console.WriteLine("Listening...");
Console.ReadLine();
server.Dispose();
