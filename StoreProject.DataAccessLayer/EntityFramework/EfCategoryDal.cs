using StoreProject.DataAccessLayer.Abstract;
using StoreProject.DataAccessLayer.Concrete;
using StoreProject.DataAccessLayer.Repositories;
using StoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {

        }
    }
}
