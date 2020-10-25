using PhotoManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var photoFilters = new PhotoFilters();

            //PhotoProcessor.PhotoFilterHandler photoFilterHandler = photoFilters.ApplyContrast;
            Action<Photo> photoFilterHandler = photoFilters.ApplyContrast;
            photoFilterHandler += photoFilters.ApplyBrightness;
            photoFilterHandler += photoFilters.Resize;
            photoFilterHandler += RemoveRedEyes;

            processor.Process("photo.jpeg", photoFilterHandler);
        }

        private static void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Remove red eyes is done");
        }
    }
}
