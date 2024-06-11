using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.Business.Abstract;
using Topic.DataAccessLayer.Abstract;
using Topic.EntityLayer.Entities;

namespace Topic.Business.Concrete
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        public BlogManager(IGenericDal<Blog> genericDal) : base(genericDal)
        {
        }
    }
}
