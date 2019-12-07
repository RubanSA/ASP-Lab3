using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Lab3.Models
{
    public class ListModel
    {
        public IEnumerable<SelectListItem> List { get; set; }

        public string[] Values { get; set; }
        public string AddedValue { get; set; }


        
        //public ListModel()
        //{
        //    //List = new List<SelectListItem>();

        //}
    }
}