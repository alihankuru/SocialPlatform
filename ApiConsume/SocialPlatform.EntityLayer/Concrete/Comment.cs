using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPlatform.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        // Foreign key to link the comment to a user
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        
    }
}
