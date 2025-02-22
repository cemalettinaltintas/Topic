﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.EntityLayer.Entities;

namespace Topic.Business.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> TGetBlogsWithCategories();
        List<Blog> TGetBlogsByCategoryId(int id);
        Blog TGetBlogWithCategoryById(int id);
    }
}
