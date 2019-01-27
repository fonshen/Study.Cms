using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01.Models
{
    public class Content
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public int Status { get; set; }

        public DateTime Add_time { get; set; }

        public DateTime Modyfy_time { get; set; }
    }
}
