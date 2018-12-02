﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RESTService.Models
{
    public class Part
    {
        public string OBID { get; set; }

        [Required]
        public string PartNumber { get; set; }
        public string PCI { get; set; }
        public string UsageCondition { get; set; }
        public string MaterialShortName { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}