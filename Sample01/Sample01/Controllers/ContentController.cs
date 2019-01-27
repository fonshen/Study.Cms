using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content _contents;
        public ContentController(IOptions<Content> option)
        {
            _contents = option.Value;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var contents = new List<Content>();
            contents.Add(_contents);
            for(int i=1;i<11;i++)
            {
                contents.Add(new Content { Id = i, Title = $"{i}的标题", Body = $"{i}的内容", Status = 1, Add_time = DateTime.Now.AddDays(-i) });
            }
            return View(new ContentViewModel { Contents = contents });
        }
    }
}
