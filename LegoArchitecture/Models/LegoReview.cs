using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegoArchitecture.Models
{
    public class Lego
    {
        public int Id { get; set; }
        public string ArchitectureName { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
    }
}