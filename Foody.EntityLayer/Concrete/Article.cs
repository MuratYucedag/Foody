using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string CoverImageUrl { get; set; }
        public string CreatedDate { get; set; }
    }
}
