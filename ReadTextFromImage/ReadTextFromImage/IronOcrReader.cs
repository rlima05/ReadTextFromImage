using IronOcr;

namespace ReadTextFromImage
{
    public class IronOcrReader : AImageToText
    {
        public override string ReadText()
        {
            var ocrReader = new AutoOcr();
            var Result = ocrReader.Read(AppSettingsReader.ImagePath);
            return Result.Text;
        }
    }
}
