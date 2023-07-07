namespace AllPatterns.BridgePattern;

public class Client
{
  public void ClientCode(Abstraction abstraction)
  {
    Console.WriteLine(abstraction.Operation());
  }
}
