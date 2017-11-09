using bidtfal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bidtfal.Data
{
    public class ContributorRepository
    {
        private static Contributor[] _contributors = new Contributor[]
        {
            new Contributor()
            {
                Name = "Bob Ballew",
                ContactLinks = new ContactLink[]
                {
                    new ContactLink {LinkText = "Website", LinkUrl = "http://bobballew.com/" },
                    new ContactLink {LinkText = "Twitter", LinkUrl = "https://twitter.com/bobballew" },
                    new ContactLink {LinkText = "GitHub", LinkUrl = "https://github.com/BobBallew" }
                }
            },
            new Contributor()
            {
                Name = "Joshua Hysong",
                ContactLinks = new ContactLink[]
                {
                    new ContactLink {LinkText = "Twitter", LinkUrl = "https://twitter.com/joshuahysong" },
                    new ContactLink {LinkText = "GitHub", LinkUrl = "https://github.com/joshuahysong" }
                }
            },
            new Contributor()
            {
                Name = "Nathaniel Hysong",
                ContactLinks = new ContactLink[]
                {
                    new ContactLink {LinkText = "Twitter", LinkUrl = "https://twitter.com/locketnathaniel" },
                    new ContactLink {LinkText = "GitHub", LinkUrl = "https://github.com/nathanielhysong" }
                }
            },
        };

        public Contributor[] GetContributors()
        {
            return _contributors;
        }
    }
}