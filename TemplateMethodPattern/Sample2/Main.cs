using AllPatterns.TemplateMethodPattern;

namespace AllPatterns;

public class TemplateMethodPatternSample2
{
  public static void ExecMain()
  {
    Console.WriteLine("Same client code can work with different subclasses:");

    Client.ClientCode(new ConcreteClass1());

    Console.Write("\n");

    Console.WriteLine("Same client code can work with different subclasses:");
    Client.ClientCode(new ConcreteClass2());
  }
}
