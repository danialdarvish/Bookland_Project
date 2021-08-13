using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _01_Framework.Application;
using ShopManagement.Application.Contracts.Book;

namespace DiscountManagement.Application.Contract.ColleagueDiscount
{
    public class DefineColleagueDiscount
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long BookId { get; set; }

        [Range(1, 99, ErrorMessage = ValidationMessages.IsRequired)]
        public int DiscountRate{ get; set; }

        public List<BookViewModel> Books{ get; set; }
    }
}
