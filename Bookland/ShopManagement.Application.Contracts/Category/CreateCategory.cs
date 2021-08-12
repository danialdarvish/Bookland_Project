using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _01_Framework.Application;

namespace ShopManagement.Application.Contracts.Category
{
    public class CreateCategory
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }

        public long ParentId { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}
