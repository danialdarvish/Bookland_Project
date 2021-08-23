namespace _01_BooklandQuery.Contract.BookCategoryCount
{
    public class BookCategoryCountQueryModel
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public long BooksCount { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
        public string Slug { get; set; }

        //public BookCategoryCountQueryModel SetIcon()
        //{
        //    switch (CategoryName)
        //    {
        //        case "درام":
        //            Icon = "icon-bubble";
        //            Color = "tg-drama";
        //            break;
        //        case "آموزشی":
        //            Icon = "icon-graduation-hat";
        //            Color = "tg-horror";
        //            break;
        //        case "علمی":
        //            Icon = "icon-book";
        //            Color = "tg-romance";
        //            break;
        //        case "تاریخی":
        //            Icon = "icon-history";
        //            Color = "tg-fashion";
        //            break;
        //        case "فلسفی":
        //            Icon = "icon-search";
        //            Color = "tg-horror";
        //            break;
        //        default:
        //            Icon = "icon-star";
        //            Color = "tg-fashion";
        //            break;
                    
        //    }

        //    return this;
        //}
    }
}
