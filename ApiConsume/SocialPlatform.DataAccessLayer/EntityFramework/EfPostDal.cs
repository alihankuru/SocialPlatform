using SocialPlatform.DataAccessLayer.Abstract;
using SocialPlatform.DataAccessLayer.Concrete;
using SocialPlatform.DataAccessLayer.Repositories;
using SocialPlatform.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPlatform.DataAccessLayer.EntityFramework
{
    public class EfPostDal : GenericRepository<Post>, IPostDal
    {
        public EfPostDal(ApplicationDbContext context) : base(context)
        {

        }

    }
}
