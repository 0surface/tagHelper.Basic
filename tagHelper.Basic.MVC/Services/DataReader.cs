using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using tagHelper.Basic.MVC.Models;

namespace tagHelper.Basic.MVC.Services
{
    public class DataReader : IDataReader
    {
        private readonly string articlesPath = @"tagHelper.Basic.MVC.Data.Articles.json";

        public string ReadDocument(string resourceName)
        {
            string testData = "";
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                testData = reader.ReadToEnd();
            }

            return testData;
        }

        public List<Article> ReadArticles()
        {
            var result = ReadDocument(articlesPath);
            var articles = JsonConvert.DeserializeObject<List<Article>>(result);
            return articles;
        }

    }
}
