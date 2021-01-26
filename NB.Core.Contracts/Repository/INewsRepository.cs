using NB.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Core.Contracts.Repository
{
    public interface INewsRepository
    {
        News Get(int NewsId);
        //for Search by category
        (List<News>, int Count) GetFilterNews(string search, string category, int pageNumber, int PageSize);

        List<News> GetPopularNews();
        List<News> GetRecentNews();
        List<News> GetTopNews();
        List<News> GetbreakingNews();

    }
}
