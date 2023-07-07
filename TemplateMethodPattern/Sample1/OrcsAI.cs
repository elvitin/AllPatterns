namespace AllPatterns;

public class OrcsAI : GameAI
{
  class Scouts
  {
    public int length = 0;
  }

  class Warrior
  {
    public int length = 0;
  }

  protected override void BuildStructures()
  {
    // if (existem alguns recursos) then
    // Construir fazendas, depois quartéis, e então uma fortaleza.
  }

  protected override void BuildUnits()
  {
    //if (há muitos recursos) then
    //if (não há batedores)
    // Construir peão, adicionar ele ao grupo de
    // scouts (batedores).
    //else
    // Construir um bruto, adicionar ele ao grupo
    // dos guerreiros.
  }

  protected override void SendScouts(int center)
  {
    Scouts scouts = new();
    if (scouts.length > 0)
      Console.WriteLine("Enviar batedores para posição.");
  }

  protected override void SendWarriors(int position)
  {
    Warrior warriors = new();
    if (warriors.length > 5)
      Console.WriteLine("Enviar guerreiros para posição.");
  }
}
