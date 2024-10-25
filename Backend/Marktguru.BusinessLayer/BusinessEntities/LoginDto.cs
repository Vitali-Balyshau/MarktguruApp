using System;
using System.ComponentModel.DataAnnotations;

namespace Marktguru.BusinessLayer.BusinessEntities
{
    public class LoginDto
    {
        public LoginDto()
        {
            UserName = String.Empty;
            Password = String.Empty;
        }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(512)]
        [Required]
        public string Password { get; set; }
    }
}