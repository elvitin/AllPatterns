namespace AllPatterns;

public class Radio : IDevice
{
  public void SetVolume(int percent)
  {
    throw new NotImplementedException();
  }

  void IDevice.Disable()
  {
    throw new NotImplementedException();
  }

  void IDevice.Enable()
  {
    throw new NotImplementedException();
  }

  int IDevice.GetChannel()
  {
    throw new NotImplementedException();
  }

  int IDevice.GetVolume()
  {
    throw new NotImplementedException();
  }

  bool IDevice.IsEnable()
  {
    throw new NotImplementedException();
  }

  void IDevice.SetChannel(int channel)
  {
    throw new NotImplementedException();
  }
}
