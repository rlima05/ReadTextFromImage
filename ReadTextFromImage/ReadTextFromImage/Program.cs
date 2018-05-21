using IronOcr;
using System;
using Tesseract;

namespace ReadTextFromImage
{
    class Program
    {
        static void Main(string[] args)
        {
            var tesseractReader = new TesseractReader();

            var readWithTesseract = new ImageReader(tesseractReader);

            var text = readWithTesseract.ReadText();

            Console.WriteLine("Reading with Tesseract: ");
            Console.WriteLine(text);
            Console.WriteLine();

            var ironOcrReader = new IronOcrReader();

            var readWithIronOcr = new ImageReader(ironOcrReader);

            text = readWithIronOcr.ReadText();

            Console.WriteLine("Reading with IronOCR: ");
            Console.WriteLine(text);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
