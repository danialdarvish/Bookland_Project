using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Domain.BookAgg;

namespace ShopManagement.Domain.AuthorAgg
{
    public class Author : EntityBase
    {
        public string FullName { get; private set; }
        public string Biography { get; private set; }
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string MetaDescription { get; private set; }
        public string Slug { get; private set; }

        public List<Book> Books { get; private set; }


        public Author()
        {
            Books = new List<Book>();
        }

        public Author(string fullName, string biography, string picture, string pictureAlt,
            string pictureTitle, string slug, string metaDescription)
        {
            FullName = fullName;
            Biography = biography;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            MetaDescription = metaDescription;
        }

        public void Edit(string fullName, string biography, string picture, string pictureAlt,
            string pictureTitle, string slug, string metaDescription)
        {
            FullName = fullName;
            Biography = biography;

            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            MetaDescription = metaDescription;
        }
    }
}
