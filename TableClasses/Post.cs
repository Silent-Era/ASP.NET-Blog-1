using ASPBlog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPBlog.TableClasses
{
    public class Post
    {
        public Post()
        {
            this.IsDeleted = false;
            this.PostDate = DateTime.Now;
            this.Comments = new HashSet<Comment>();
        }
        [Key]
        public int PostId { get; set; }

        [Required]
        public string PostTitle { get; set; }

        [Required]
        public string PostBody { get; set; }

        [Required]
        public DateTime PostDate { get; set; }

        [Required]
        public ApplicationUser Author { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}