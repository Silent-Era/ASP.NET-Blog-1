﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace BlogMVC.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

       
        public DateTime Date { get; set; }

        public ApplicationUser Author { get; set; }
        
    }
}