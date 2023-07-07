namespace AllPatterns.BridgePattern;

public class BridgePatternSample1
{
  public static void ExecMain()
  {
    TV tv = new();

    RemoteControl remote = new(tv);
    remote.TogglePower();

    Radio radio = new();
    remote = new AdvancedRemoteControl(radio);
    ((AdvancedRemoteControl)remote).Mute();
  }
}
