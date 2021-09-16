using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _01_Framework.Application;
using AccountManagement.Application.Contracts.Role;

namespace AccountManagement.Application.Contracts.Account
{
    public class CreateAccount
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string FullName { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Username { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Password { get; set; }

        [RegularExpression(@"(\+98|0)?9\d{9}", ErrorMessage = "قالب شماره همراه صحیح نمی باشد.")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }

        public long RoleId { get; set; }

        public List<RoleViewModel> Roles { get; set; }
    }
}
