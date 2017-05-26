using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSite.Models
{
    public class ImageGalleryModel
    {
        private List<string> _galleryStorage;

        public ImageGalleryModel()
        {
            GetGalleryStorage();
        }

        public string CurrentImgName { get; set; }
        public string PreviousImgName { get; set; }
        public string NextImgName { get; set; }
        public bool CanGoBack { get; set; }
        public bool CanGoNex { get; set; }
        public List<string> GalleryStorage { get { return _galleryStorage; } }

        private void GetGalleryStorage()
        {
            _galleryStorage = new List<string>();

            foreach (var filePath in Directory.EnumerateFiles(@"D:\GL\desktop images\temp"))
            {
                var img = new FileInfo(filePath);
                var name = img.Name.Substring(0, img.Name.IndexOf("."));
                _galleryStorage.Add(name);
            }
        }
    }
}
