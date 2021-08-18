using _01_Framework.Domain;

namespace ShopManagement.Domain.QuoteAgg
{
    public class Quote : EntityBase
    {
        public string PersonName { get; private set; }
        public string PersonPost { get; private set; }
        public string Text { get; private set; }
        public string PersonPicture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public bool IsRemoved { get; private set; }

        public Quote(string personName, string personPost, string text, string personPicture,
            string pictureAlt, string pictureTitle)
        {
            PersonName = personName;
            PersonPost = personPost;
            Text = text;
            PersonPicture = personPicture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            IsRemoved = false;
        }

        public void Edit(string personName, string personPost, string text, string personPicture,
            string pictureAlt, string pictureTitle)
        {
            PersonName = personName;
            PersonPost = personPost;
            Text = text;

            if (!string.IsNullOrWhiteSpace(personPicture))
                PersonPicture = personPicture;

            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
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
