using NB.Core.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using NB.Core.Contracts.Service;
using NB.Core.Entities;

public class NewsService : INewsService
{
    private readonly INewsRepository newsRepository;

    public NewsService(INewsRepository newsRepository)
    {
        this.newsRepository = newsRepository;
    }

    public List<News> GetPopularNews()
    {
        return newsRepository.GetPopularNews()
             .Take(4).ToList();
    }

    public List<News> GetRecentNews()
    {
        return newsRepository.GetRecentNews();
    }

    public (List<News>, int) NewsSearch(string q, string category, int pageNumber, int PageSize)
    {
        return newsRepository.GetFilterNews(q, category, pageNumber, PageSize);
    }


    public News Get(int ProductId)
    {
        return newsRepository.Get(ProductId);
    }
}