using SocialPlatform.BusinessLayer.Abstract;
using SocialPlatform.DataAccessLayer.Abstract;
using SocialPlatform.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPlatform.BusinessLayer.Concrete
{   // Implementation of the IPostService interface for managing Post entities
    public class PostManager:IPostService
    {
        private readonly IPostDal _postDal;
        // Constructor to inject the Post Data Access Layer (Dal)
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }
        public void TDelete(Post t)
        {
            _postDal.Delete(t);
        }

        public Post TGetByID(int id)
        {
            return _postDal.GetByID(id);
        }

        public List<Post> TGetList()
        {
            return _postDal.GetList();
        }

        public void TInsert(Post t)
        {
            _postDal.Insert(t);
        }

        public void TUpdate(Post t)
        {
            _postDal.Update(t);
        }

    }
}
