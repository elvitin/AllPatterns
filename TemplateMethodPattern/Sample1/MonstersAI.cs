namespace AllPatterns;


// As subclasses também podem sobrescrever algumas operações com
// uma implementação padrão.
public class MonstersAI : GameAI
{
  protected override void BuildStructures()
  {
    Console.WriteLine("Monstros não constroem estruturas.");
  }

  protected override void BuildUnits()
  {
    Console.WriteLine("Monstros não constroem unidades.");
  }

  protected override void SendScouts(int center)
  {
    throw new NotImplementedException();
  }

  protected override void SendWarriors(int position)
  {
    throw new NotImplementedException();
  }


  // As subclasses também podem sobrescrever algumas operações com
  // uma implementação padrão.
  protected override void CollectResources()
  {
    Console.WriteLine("Monstros não coletam recursos.");
  }
}
