﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var c = new CoreProjeContext();
            c.Add(blog);
            c.SaveChanges();    
            
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new CoreProjeContext();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new CoreProjeContext();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new CoreProjeContext();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new CoreProjeContext();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
