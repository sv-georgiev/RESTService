using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTService.Models
{
    public class Document
    {
        public string OBID { get; set; }
        public string Title { get; set; }

        [ForeignKey("OBID")]
        public Part Part { get; set; }
    }
}