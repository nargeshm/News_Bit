﻿
using Microsoft.EntityFrameworkCore;
using NB.Core.Contracts.Repository;
using NB.Core.Entities;
using NewsBit.InfraStructure.sql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsBit.InfraStructure.Data
{
    public class NewsRepository : INewsRepository
    {
        private readonly NewsContext context;

        public NewsRepository(NewsContext context)
        {
            this.context = context;
        }
        public News Get(int NewsId)
        {
            return context.News.Include(a => a.Medias)

                .First(a => a.NewsId == NewsId);
        }
        //مجبوب ترین اخبار از هر دسته بندی 
        public List<News> GetPopularNews()
        {
            List<News> result = new List<News>();
            foreach (var category in context.Categories.ToList())
            {
                int MaxRead = context.News.Include(a => a.Category).Where(a => a.Category == category).Max(a => a.ReadCount);
                result.Add(context.News.Include(a => a.Medias).First(a => a.ReadCount == MaxRead));

            }
            return result;
        }
        //for Search by category:
        public (List<News>, int Count) GetFilterNews(string search, string category, int pageNumber, int PageSize)
        {

            IQueryable<News> query = context.News.Include(a => a.Category).Include(a => a.Medias);
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(a => a.LitleTitle.Contains(search) || a.NewsSummary.Contains(search));
            }
            if (category != "All")
            {
                query = query.Where(a => a.Category.CategoryName == category);

            }

            var lengthQuery = query.ToList().Count;

            return (query.Skip((pageNumber - 1) * PageSize).Take(PageSize).ToList(), lengthQuery);
        }



        public List<News> GetRecentNews()
        {
            return context.News.Include(a => a.Medias)
                .OrderByDescending(a => a.NewsReleasetime).ToList();
        }  
        //اخبار فوری
        public List<News> GetbreakingNews()
        {
            return context.News.Include(a => a.Medias)
                .OrderByDescending(a => a.NewsReleasetime).ToList();
        }
        public List<News> GetTopNews()
        {
            return context.News.Include(a => a.Medias)
                .OrderByDescending(a => a.ReadCount).ToList();
        }

    }
}
