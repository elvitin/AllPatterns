using AllPatterns.FacadePattern.Sample1.ComplexVideoFramerwork;

namespace AllPatterns;

public class VideoConverterFacade
{
  public FrameworkFile Convert(string fileName, string format)
  {
    _ = new VideoFile(fileName);
    var sourceCodec = new CodecFactory().extract(fileName);
    CodecFactory destinationCodec;
    if (format == "mp4")
    {
      destinationCodec = new MPEG4CompressionCodec();
    }
    else
      destinationCodec = new OggCompressionCodec();
    var buffer = BitrateReader.Read(fileName, sourceCodec);
    var result = BitrateReader.Convert(buffer, destinationCodec);
    result = (new AudioMixer()).Fix(result);
    return new FrameworkFile(result);
  }
}
