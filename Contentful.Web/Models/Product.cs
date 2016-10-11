using Contentful.NET.DataModels;

namespace Contentful.Web.Models
{
    public class Product : Entry
    {
        public string ProductName { get; set; }
        public string Slug { get; set; }
    }
}