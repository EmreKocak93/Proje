﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryManager
    {
        GenericRepository<Category> repo=new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName==null || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length >= 51)
            {
                //Hata Mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
