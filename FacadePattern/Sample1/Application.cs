namespace AllPatterns;

public class FacadePatternSample1
{
  public static void ExecMain()
  {
    var convertor = new VideoConverterFacade();
    var mp4 = convertor.Convert("funny-cats-video.ogg", "mp4");
    mp4.save();
  }
}
