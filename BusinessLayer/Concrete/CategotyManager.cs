using BusinessLayer.Abstrack;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategotyManager : ICategoryServices
    {
        ICategoryDal _categoryDal;

        public CategotyManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public object CategoryAdd { get; set; }

        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }



    }
}
