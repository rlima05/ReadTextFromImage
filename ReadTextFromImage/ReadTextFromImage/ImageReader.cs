namespace ReadTextFromImage
{
    public class ImageReader
    {
        private AImageToText _reader;

        public ImageReader(AImageToText reader)
        {
            _reader = reader;
        }

        public string ReadText()
        {
            return _reader.ReadText();
        }
    }
}
