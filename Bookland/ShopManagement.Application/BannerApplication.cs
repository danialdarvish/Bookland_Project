using System.Collections.Generic;
using _01_Framework.Application;
using ShopManagement.Application.Contracts.Banner;
using ShopManagement.Domain.BannerAgg;

namespace ShopManagement.Application
{
    public class BannerApplication : IBannerApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly IBannerRepository _bannerRepository;

        public BannerApplication(IBannerRepository bannerRepository, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _bannerRepository = bannerRepository;
        }


        public OperationResult Create(CreateBanner command)
        {
            var operation = new OperationResult();

            var pictureName = _fileUploader.Upload(command.Picture, "Banners");
            var banner = new Banner(pictureName, command.PictureAlt, command.PictureTitle,
            command.Tag, command.BookId);

            _bannerRepository.Create(banner);
            _bannerRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Edit(EditBanner command)
        {
            var operation = new OperationResult();
            var banner = _bannerRepository.Get(command.Id);

            if (banner == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            var pictureName = _fileUploader.Upload(command.Picture, "Banners");

            banner.Edit(pictureName, command.PictureAlt, command.PictureTitle,
                command.Tag, command.BookId);
            _bannerRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var banner = _bannerRepository.Get(id);

            if (banner == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            banner.Remove();
            _bannerRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var banner = _bannerRepository.Get(id);

            if (banner == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            banner.Restore();
            _bannerRepository.SaveChanges();
            return operation.Succeed();
        }

        public EditBanner GetDetails(long id)
        {
            return _bannerRepository.GetDetails(id);
        }

        public List<BannerViewModel> Search(BannerSearchModel searchModel)
        {
            return _bannerRepository.Search(searchModel);
        }
    }
}
