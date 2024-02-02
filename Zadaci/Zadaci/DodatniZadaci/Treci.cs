/*
Za primjer dan izlistanjem kôda odredite obrazac o kojem
 je riječ i njegovu skupinu. Dopunite kôd implementacijom 
 koja nedostaje te napišite klijentski kôd za ovaj primjer.
*/
/*Proxy*/
namespace Treci
{
    using System;

    namespace TreciRjesenje
    {
        interface IImage
        {
            void Display();
        }

        class RealImage : IImage
        {
            private string filename;

            public RealImage(string filename)
            {
                this.filename = filename;
                LoadImageFromDisk();
            }

            public void Display()
            {
                Console.WriteLine($"Displaying image: {filename}");
            }

            private void LoadImageFromDisk()
            {
                Console.WriteLine($"Loading image from disk: {filename}");
            }
        }

        class ImageSurrogate : IImage
        {
            private string filename;
            private RealImage image;

            public ImageSurrogate(string filename)
            {
                this.filename = filename;
            }

            public void Display()
            {
                if (image == null)
                {
                    image = new RealImage(filename);
                }
                image.Display();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Klijentski kod
                IImage image = new ImageSurrogate("example.jpg");
                image.Display();
            }
        }
    }

}