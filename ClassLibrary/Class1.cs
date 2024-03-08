using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class NewsArticle
    {
        public string Title { set; get; }
        public string Category { set; get; }

        public NewsArticle(string title, string category)
        {
            this.Title = title;
            this.Category = category;
        }
    }

    public class NewsArticleCollection
    {
        /*
         

            articleAddedHandler (delegate): a delegate that is invoked when a new article is added to the collection

            articleRemovedHandler (delegate): a delegate that is invoked when an article is removed from the collection

            articleFilteredHandler (delegate): a delegate that is invoked when articles are filtered by category

            RegisterArticleAddedHandler(Action<object, NewsArticle> handler): registers an event handler for the article added event

            RegisterArticleRemovedHandler(Action<object, NewsArticle> handler): registers an event handler for the article removed event

            RegisterArticleFilteredHandler(string category, Action<object, string> handler): registers an event handler for the article filtered eve
         */

        private List<NewsArticle> articles = new List<NewsArticle>();

        public void Addarticle(NewsArticle article)
        {
           
        }

        public void Removearticle(NewsArticle article)
        {
           
        }

        public void FilterArticlesByCategory(string category)
        {
            

        }

        public event Action< NewsArticle> articleAddedHandler;
        public event Action< NewsArticle> articleRemovedHandler;
        public event Action<string> articleFilteredHandler;

        public void RegisterArticleAddedHandler(Action<NewsArticle> handler)
        {
            articleAddedHandler += handler;
        }

        public void RegisterArticleRemovedHandler(Action<NewsArticle> handler)
        {
            articleAddedHandler += handler;
        }

        public void RegisterArticleFilteredHandler(Action<string> handler)
        {
            articleFilteredHandler += handler;
        }


    }
}
