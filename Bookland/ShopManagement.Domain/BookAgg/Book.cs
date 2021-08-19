using System;
using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Domain.AuthorAgg;
using ShopManagement.Domain.BannerAgg;
using ShopManagement.Domain.BookCategoryAgg;

namespace ShopManagement.Domain.BookAgg
{
    public class Book : EntityBase
    {
        public string Name { get; private set; }
        public string Format { get; private set; }
        public int PageCount { get; private set; }
        public DateTime PublishDate { get; private set; }
        public string Publisher { get; private set; }
        public string Language { get; private set; }
        public string Isbn { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public bool IsEditorsChoice { get; private set; }

        public List<BookCategory> BookCategories { get; private set; }
        public List<Banner> Banners { get; private set; }

        public long AuthorId { get; private set; }
        public Author Author { get; private set; }




        public Book(string name, string format, int pageCount, DateTime publishDate, string publisher,
            string language, string isbn, string picture, string pictureAlt, string pictureTitle,
            string slug, string keywords, string metaDescription, string description,
            long authorId, string shortDescription, bool isEditorsChoice)
        {
            Name = name;
            Format = format;
            PageCount = pageCount;
            PublishDate = publishDate;
            Publisher = publisher;
            Language = language;
            Isbn = isbn;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Description = description;
            AuthorId = authorId;
            ShortDescription = shortDescription;
            IsEditorsChoice = isEditorsChoice;
        }

        public void Edit(string name, string format, int pageCount, DateTime publishDate, string publisher,
            string language, string isbn, string picture, string pictureAlt, string pictureTitle,
            string slug, string keywords, string metaDescription, string description, long authorId,
            string shortDescription, bool isEditorsChoice)
        {
            Name = name;
            Format = format;
            PageCount = pageCount;
            PublishDate = publishDate;
            Publisher = publisher;
            Language = language;
            Isbn = isbn;

            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Description = description;
            AuthorId = authorId;
            ShortDescription = shortDescription;
            IsEditorsChoice = isEditorsChoice;
        }
    }
}
