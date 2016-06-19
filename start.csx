public class TestController : ApiController {
  public string Get() {
    return "Hello world!";
  }
}

var webApi = Require<WebApi>();
var server = webApi.CreateServer("http://localhost:8080");
server.OpenAsync().Wait();

Console.WriteLine("Listening...");
Console.ReadKey();
server.CloseAsync().Wait();
