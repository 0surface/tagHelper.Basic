using System.Collections.Generic;
using tagHelper.Basic.MVC.Models;

namespace tagHelper.Basic.MVC.Services
{
    public interface IDataReader
    {
        string ReadDocument(string resourceName);
        List<Article> ReadArticles();
    }
}