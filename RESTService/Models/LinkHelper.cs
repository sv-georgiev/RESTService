using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTService.Models
{


    public class LinkHelper<T> where T : class
    {
        public T Value { get; set; }
        public List<Link> Links { get; set; }

        public LinkHelper()
        {
            Links = new List<Link>();
        }

        public LinkHelper(T item) : base()
        {
            Value = item;
            Links = new List<Link>();
        }
    }
}