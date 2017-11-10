using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bidtfal.Models
{
    public class Contributor
    {
        public string Name { get; set; }
        public ContactLink[] ContactLinks { get; set; }

        public string ImageFileName
        {
            get
            {
                return Name.Replace(" ", "-").ToLower() + ".jpg";
            }
        }
    }
}