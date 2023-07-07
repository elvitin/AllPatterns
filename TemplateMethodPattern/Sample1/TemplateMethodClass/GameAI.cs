using System.Data;

namespace AllPatterns;

abstract public class GameAI
{
  class BuiltStructures
  {
    public void Collect() { }
  }

  class Map
  {
    public int Center { get; set; }
  }

  class Enemy
  {
    public int position = 0;
  }

  readonly List<BuiltStructures> builtStructures = new();
  public virtual void Turn()
  {
    CollectResources();
    BuildStructures();
    BuildUnits();
    Attack();
  }
  protected abstract void BuildUnits();
  protected abstract void BuildStructures();
  protected abstract void SendWarriors(int position);
  protected abstract void SendScouts(int center);
  protected void Attack()
  {
    Map map = new();

    var enemy = CloseEnemy();
    if (enemy == null)
      SendWarriors(map.Center);
    else
      SendScouts(enemy.position);
  }
  private Enemy CloseEnemy()
  {
    //throw new NotImplementedException();
    return new Enemy();
  }
  protected virtual void CollectResources()
  {
    foreach (var item in builtStructures)
    {
      item.Collect();
    }
  }
}
