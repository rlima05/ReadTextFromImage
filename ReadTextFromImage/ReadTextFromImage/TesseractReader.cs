using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace ReadTextFromImage
{
    public class TesseractReader : AImageToText
    {
        public override string ReadText()
        {
            var imagePath = AppSettingsReader.ImagePath;
            var tessDataPath = AppSettingsReader.TessDataPath;

            var text = string.Empty;

            using (var engine = new TesseractEngine(tessDataPath, "eng"))
            {
                using (var img = Pix.LoadFromFile(imagePath))
                {
                    using (var page = engine.Process(img))
                    {
                        text = page.GetText();
                    }
                }
            }

            return text;
        }
    }
}
