namespace AllPatterns.BridgePattern;

public class BridgePatternSample2
{
  public static void ExecMain()
  {
    Client client = new();
    Abstraction abstraction;

    abstraction = new Abstraction(new ConcreteImplementationA());
    client.ClientCode(abstraction);

    abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
    client.ClientCode(abstraction);
  }
}
