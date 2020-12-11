using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogLab.Web.Blog
{
    public class PagedResults<T>
    {
        public IEnumerable<T> Item { get; set; }

        public int TotalCount { get; set; }
    }
}
