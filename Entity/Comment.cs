using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }
        public Product Product { get; set; } = null!;
        public int ProductId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public string? UserId { get; set; }
    }
}