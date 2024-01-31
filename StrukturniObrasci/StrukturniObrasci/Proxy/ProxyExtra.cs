// namespace ProxtExtra{

// interface IImage
// {
//     void Display();
// }

// class RealImage : IImage
// {
//     private string filename;

//     public RealImage(string filename)
//     {
//         this.filename = filename;
//         LoadImageFromDisk();
//     }

//     public void Display()
//     {
//         Console.WriteLine($"Displaying image: {filename}");
//     }

//     private void LoadImageFromDisk()
//     {
//         Console.WriteLine($"Loading image from disk: {filename}");
//     }
// }

// class ImageSurrogate : IImage
// {
//     private string filename;
//     private RealImage image;

//     public ImageProxy(string filename)
//     {
//         this.filename = filename;
//     }

//     public void Display()
//     {
//         if (image == null)
//         {
//             image = new RealImage(filename);
//         }
//         image.Display();
//     }
// }

// }