using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Slide;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class SlideQuery : ISlideQuery
    {
        private readonly ShopContext _shopContext;

        public SlideQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }


        public List<SlideQueryModel> GetSlides()
        {
            return _shopContext.Slides
                .Where(x => !x.IsRemoved)
                .Select(x => new SlideQueryModel
                {
                    Heading = x.Heading,
                    Title = x.Title,
                    Text = x.Text,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    BtnText = x.BtnText,
                    Link = x.Link
                }).ToList();
        }
    }
}
