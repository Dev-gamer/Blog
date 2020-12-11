using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogLab.Web.Blog
{
    public class BlogCreate
    {

        public int BlogId { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
        [System.ComponentModel.DataAnnotations.MinLength(10, ErrorMessage = "Must be atleast  10-50 characteres")]
        [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Must be at least 10-50 characteres")]
        public string Title { get; set; }


        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
        [System.ComponentModel.DataAnnotations.MinLength(300, ErrorMessage = "Must be at least 300-3000 characteres")]
        [System.ComponentModel.DataAnnotations.MaxLength(3000, ErrorMessage = "Must be at least 300-3000 characteres")]
        public string Content { get; set; }

        public int? PhotoId { get; set; }


    }
}
 