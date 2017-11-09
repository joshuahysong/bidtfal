using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bidtfal.Models
{
    public class ContactLink
    {
        public string LinkText { get; set; }
        public string LinkUrl { get; set; }

        public string GetContactLinkHtml
        {
            get
            {
                return "<a href=\"" + LinkUrl + "\">" + LinkText + "</a>";
            }
        }
    }
}