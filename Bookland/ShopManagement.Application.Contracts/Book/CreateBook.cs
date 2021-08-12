using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _01_Framework.Application;
using ShopManagement.Application.Contracts.Author;
using ShopManagement.Application.Contracts.Category;

namespace ShopManagement.Application.Contracts.Book
{
    public class CreateBook
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; } 

        public string Format { get; set; } 
        public int PageCount { get; set; } 
        public string PublishDate { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Publisher { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Language { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Isbn { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Picture { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired), MinLength(1)]
        public List<long> CategoryId { get; set; }
        public List<CategoryViewModel> Categories { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = ValidationMessages.IsRequired)]
        public long AuthorId { get; set; }

        public List<AuthorViewModel> Authors { get; set; }
    }
}
