using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Topic.Business.Abstract;
using Topic.DataAccessLayer.Abstract;
using Topic.EntityLayer.Entities;

namespace Topic.Business.Concrete
{
    public class FAQManager : GenericManager<FAQ>,IFAQService
    {
        public FAQManager(IGenericDal<FAQ> genericDal) : base(genericDal)
        {
        }
    }
}
