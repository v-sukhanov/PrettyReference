using System;

namespace PrettyReference.ReferenceManager.Interface.Shared
{
    public class SiteReference
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Source { get; set; }

        public SiteReference()
        {
            
        }
        public SiteReference(Guid id, string url, string title, string image, string source)
        {
            Id = id;
            Url = url;
            Title = title;
            Image = image;
            Source = source;
        }
    }
}