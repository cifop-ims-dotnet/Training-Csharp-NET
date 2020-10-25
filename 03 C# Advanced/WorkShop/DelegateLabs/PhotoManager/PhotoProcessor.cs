using System;

namespace PhotoManager
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, Action<Photo> handler)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            handler(photo);

            //filters.ApplyBrightness(photo);
            //filters.Resize(photo);
            //filters.ApplyContrast(photo);

            photo.Save();
        }
    }
}
