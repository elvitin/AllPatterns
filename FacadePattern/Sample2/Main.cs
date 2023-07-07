using AllPatterns.FacadePattern;

namespace AllPatterns;

public class FacadePatternSample2
{
  public static void ExecMain()
  {
    Subsystem1 subsystem1 = new();
    Subsystem2 subsystem2 = new();
    Facade facade = new(subsystem1, subsystem2);
    Client.ClientCode(facade);
  }
}
