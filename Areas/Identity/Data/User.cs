using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Tunrecrute.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        [PersonalData]
        public string Firstname { get; set; }
        [PersonalData]
        public string Lastname { get; set; }
        [PersonalData]
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string Picture { get; set; }
        public string AboutMe { get; set; }
        [PersonalData]
        [StringLength(10)]
        public string Sex { get; set; }
        [PersonalData]
        public string Birthdate { get; set; }
        [PersonalData]
        public string Nationality { get; set; }
        public string CVFilename { get; set; }
        public string CoverLetterFilename { get; set; }
    }
}
