using System.Data.Common;
using School.SharedContext;

namespace School.ContentContext
{
    public abstract class Content : Base
    {

        public Content(string title, string url)
        {
            Tilte = title;
            URL = url;
        }

        public string Tilte { get; set; }
        public string URL { get; set; }
    }
}