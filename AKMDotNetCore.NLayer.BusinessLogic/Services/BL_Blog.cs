﻿using AKMDotNetCore.NLayer.DataAccess.Services;
using Microsoft.EntityFrameworkCore;
using AKMDotNetCore.NLayer.DataAccess.Models;

namespace AKMDotNetCore.NLayer.BusinessLogic.Services
{
    public class BL_Blog
    {
        private readonly DA_Blog _daBlog;

        public BL_Blog()
        {
            _daBlog = new DA_Blog();
        }

        public List<BlogModel> GetBlogs()
        {
            var lst = _daBlog.GetBlogs();
            return lst;
        }

        public BlogModel GetBlog(int id)
        {
            var item = _daBlog.GetBlog(id);
            return item;
        }

        public int CreatBlog(BlogModel requestModel)
        {
            var result = _daBlog.CreatBlog(requestModel);
            return result;
        }

        public int UpdateBlog(int id, BlogModel requestModel)
        {
            var result = _daBlog.UpdateBlog(id, requestModel);
            return result;
        }

        public int DeleteBlog(int id)
        {
            var result = _daBlog.DeleteBlog(id);
            return result;
        }
    }
}
