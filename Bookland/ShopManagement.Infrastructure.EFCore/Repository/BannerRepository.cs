using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Banner;
using ShopManagement.Domain.BannerAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class BannerRepository : RepositoryBase<long, Banner>, IBannerRepository
    {
        private readonly ShopContext _context;
        public BannerRepository(ShopContext context) : base(context)
        {
            _context = context;
        }


        public EditBanner GetDetails(long id)
        {
            return _context.Banners.Select(x => new EditBanner
            {
                Id = x.Id,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Tag = x.Tag,
                BookId = x.BookId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<BannerViewModel> Search(BannerSearchModel searchModel)
        {
            var query = _context.Banners
                .Include(x => x.Book)
                .ThenInclude(x => x.Author)
                .Select(x => new BannerViewModel
                {
                    Id = x.Id,
                    BookName = x.Book.Name,
                    Picture = x.Picture,
                    Tag = x.Tag,
                    CreationDate = x.CreationDate.ToFarsi(),
                    IsRemoved = x.IsRemoved
                });

            if (!string.IsNullOrWhiteSpace(searchModel.BookName))
                query = query.Where(x => x.BookName.Contains(searchModel.BookName));
            if (!string.IsNullOrWhiteSpace(searchModel.Tag))
                query = query.Where(x => x.Tag.Contains(searchModel.Tag));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
