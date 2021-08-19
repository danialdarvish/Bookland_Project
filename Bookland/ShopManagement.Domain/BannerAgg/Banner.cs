using _01_Framework.Domain;
using ShopManagement.Domain.BookAgg;

namespace ShopManagement.Domain.BannerAgg
{
    public class Banner : EntityBase
    {
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Tag { get; private set; }
        public bool IsRemoved { get; private set; }

        public long BookId { get; private set; }
        public Book Book { get; private set; }

        public Banner(string picture, string pictureAlt, string pictureTitle, string tag, long bookId)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Tag = tag;
            BookId = bookId;
            IsRemoved = false;
        }

        public void Edit(string picture, string pictureAlt, string pictureTitle, string tag, long bookId)
        {
            if (!string.IsNullOrWhiteSpace(picture))
                Picture = picture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Tag = tag;
            BookId = bookId;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
