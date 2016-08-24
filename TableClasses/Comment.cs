using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPBlog.TableClasses
{
    public class Comment
    {
        public Comment()
        {
            this.IsDeleted = false;
            this.CommentDate = DateTime.Now;
        }
        [Key]
        public int CommentId { get; set; }

        public string CommentBody { get; set; }
        [Required]
        public DateTime CommentDate { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public Post post { get; set; }
        
    }
}