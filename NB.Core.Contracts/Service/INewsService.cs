using NB.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NB.Core.Contracts.Service
{
    public interface INewsService
    {
        News Get(int ProductId);
        (List<News>, int) NewsSearch(string q, string category, int pageNumber, int PageSize);

        List<News> GetPopularNews();
        List<News>  GetRecentNews();
    }
}
