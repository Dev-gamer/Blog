using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogLab.Web.BlogComments
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }

        public int? ParentBlogCommentId { get; set; }


        public int BlogId { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
        [System.ComponentModel.DataAnnotations.MinLength(10, ErrorMessage = "Must be 10-300 characteres")]
        [System.ComponentModel.DataAnnotations.MaxLength(300, ErrorMessage = "Must be  10-300 characteres")]

        public string Content { get; set; }
    }

}
