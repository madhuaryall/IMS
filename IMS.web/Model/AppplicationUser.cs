using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IMS.web.Model
{
    public class AppplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        //public string PhoneNumber { get; set; }
        public int StoreId { get; set; }

        //Generally to identify users 
        public int UserRoleID { get; set; }

        public bool IsActive { get; set; }

        public string ProfilePicture { get; set; }
        public string ProfilePictureUrl { get; set; }

       public DateTime CreatedDate { get; set; }

      public string CreatedBy { get; set; }

     public string UpdatedBy { get; set; }

         
        public DateTime LastModifiedDate { get; set; }
        public string ModifiedBy { get; set;}
    }
}
