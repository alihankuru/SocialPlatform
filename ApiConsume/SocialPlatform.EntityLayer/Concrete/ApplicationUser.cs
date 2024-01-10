using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPlatform.EntityLayer.Concrete
{
    public class ApplicationUser: IdentityUser
    {

        [MaxLength(30)]
        public string? Name { get; set; }

        // Navigation property to represent the user's posts
        public ICollection<Post> Posts { get; set; }


        // Navigation property to represent the user's comments
        public ICollection<Comment> Comments { get; set; }
    }
}
