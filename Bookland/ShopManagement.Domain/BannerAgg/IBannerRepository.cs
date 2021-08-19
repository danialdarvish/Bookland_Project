using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Application.Contracts.Banner;

namespace ShopManagement.Domain.BannerAgg
{
    public interface IBannerRepository : IRepository<long, Banner>
    {
        EditBanner GetDetails(long id);
        List<BannerViewModel> Search(BannerSearchModel searchModel);
    }
}
