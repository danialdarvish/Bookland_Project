using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.Slide
{
    public interface ISlideQuery
    {
        List<SlideQueryModel> GetSlides();
    }
}
