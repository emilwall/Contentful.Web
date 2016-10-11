using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Contentful.NET;
using Contentful.NET.DataModels;
using Contentful.NET.Exceptions;
using Contentful.Web.Models;

namespace Contentful.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var contentfulAccessToken = "9d9fdbdca6affed43cbb94281eff744427c07f32977b06b447b481e60dedcd31";
            var spaceId = "mi4rdl7ro9cd";
            var preview = false;
            var cmsClient = new ContentfulClient(contentfulAccessToken, spaceId, preview);

            var cancellationToken = new CancellationToken();
            var contentId = "3DVqIYj4dOwwcKu6sgqOgg";
            var content = new Product();
            try
            {
                content = await cmsClient.GetAsync<Entry>(cancellationToken, contentId);
            }
            catch (ContentfulException e)
            {
                //content. = "Error: " + e.ErrorCode;
                //content.Description = e.ErrorDetails.Message;
            }
            var product = content as Product;
            product.ProductName = product.Name + ", " + product.Description;

            return View(product);
        }
    }
}