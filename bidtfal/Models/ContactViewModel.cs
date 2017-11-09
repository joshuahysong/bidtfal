using bidtfal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bidtfal.Models
{
    public class ContactViewModel
    {
       static ContributorRepository _contributorRepository = new ContributorRepository();

        public Contributor[] Contributors
        {
            get
            {
                return _contributorRepository.GetContributors();
            }
        }

        public string test { get; set; }

    }
}