﻿namespace AllPatterns;

public class AdvancedRemoteControl : RemoteControl
{
  public AdvancedRemoteControl(IDevice device) : base(device) { }

  public void Mute()
  {
    _device.SetVolume(0);
  }
}
