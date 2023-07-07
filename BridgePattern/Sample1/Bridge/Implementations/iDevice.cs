namespace AllPatterns;

public interface IDevice
{
  bool IsEnable();
  void Enable();
  void Disable();
  int GetVolume();
  void SetVolume(int percent);
  int GetChannel();
  void SetChannel(int channel);
}
