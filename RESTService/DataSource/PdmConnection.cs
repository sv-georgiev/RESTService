using RESTService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RESTService.DataSource
{
    public class PdmConnection
    {

        /// <summary>
        /// Get a part from the PDM upon its id (OBID) 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Part GetPart(string id)
        {
            Part part = new Part();

            part.PartNumber = id;
            part.OBID = id;
            part.PCI = "Sam";
            part.UsageCondition = "Smith";
            part.MaterialShortName = "mat short";
            part.LastModifiedDate = DateTime.Parse("15/6/2017");

            return part;
        }

        public Part GetPart(string PartNumber, string pci)
        {
            Part part = new Part();

            part.PartNumber = PartNumber;
            part.OBID = "xxxxxx";
            part.PCI = pci;
            part.UsageCondition = "Smith";
            part.MaterialShortName = "mat short";
            part.LastModifiedDate = DateTime.Parse("15/6/2017");

            return part;

        }

        public List<Part> GetParts()
        {
            List<Part> parts = new List<Part>();

            Part part = new Part();

            part.PartNumber = "100";
            part.OBID = "xy100";
            part.PCI = "10.01";
            part.UsageCondition = "Production";
            part.MaterialShortName = "mat short";
            part.LastModifiedDate = DateTime.Parse("15/6/2017");

            parts.Add(part);

            Part part1 = new Part();

            part1.PartNumber = "101";
            part1.OBID = "xy101";
            part1.PCI = "10.02";
            part1.UsageCondition = "Consturction";
            part1.MaterialShortName = "mat short";
            part1.LastModifiedDate = DateTime.Parse("16/6/2017");

            parts.Add(part1);

            return parts;
        }

        public DataTable SearchParts(string searchString)
        {
            DataTable result = new DataTable("Parts");

            return result;
        }
    }
}