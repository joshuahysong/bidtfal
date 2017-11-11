using bidtfal.Models;
using bidtfal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bidtfal.Data
{
    public static class ContributorRepository
    {
        private static List<Contributor> _contributorsList = new List<Contributor>();
        
        public static List<Contributor> GetContributors()
        {
            if (_contributorsList.Count == 0)
            {
                LoadList();
            }
            return _contributorsList;
        }//end of GetContributors  

        private static void LoadList()
        {
            _contributorsList.Add(new Contributor()
            {
                Name = "Bob Ballew",
                ContactLinks = new ContactLink[]
                {
                    new ContactLink {LinkText = "Website", LinkUrl = "http://bobballew.com/" },
                    new ContactLink {LinkText = "Twitter", LinkUrl = "https://twitter.com/bobballew" },
                    new ContactLink {LinkText = "GitHub", LinkUrl = "https://github.com/BobBallew" }
                }
            });

            _contributorsList.Add(new Contributor()
            {
                Name = "Joshua Hysong",
                ContactLinks = new ContactLink[]
                {
                new ContactLink {LinkText = "Twitter", LinkUrl = "https://twitter.com/joshuahysong" },
                new ContactLink {LinkText = "GitHub", LinkUrl = "https://github.com/joshuahysong" }
                }
            });
            _contributorsList.Add(new Contributor()
            {
                Name = "Nathaniel Hysong",
                ContactLinks = new ContactLink[]
                {
                new ContactLink {LinkText = "Twitter", LinkUrl = "https://twitter.com/locketnathaniel" },
                new ContactLink {LinkText = "GitHub", LinkUrl = "https://github.com/nathanielhysong" }
                }
            });
        }//end of LoadList
    }//end of class
}//end of namespace