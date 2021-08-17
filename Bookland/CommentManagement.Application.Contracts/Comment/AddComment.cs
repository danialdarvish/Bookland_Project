using System.ComponentModel.DataAnnotations;
using _01_Framework.Application;

namespace CommentManagement.Application.Contracts.Comment
{
    public class AddComment
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Message { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public long OwnerRecordId { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public int Type { get; set; }

        public long ParentId { get; set; }
    }
}
