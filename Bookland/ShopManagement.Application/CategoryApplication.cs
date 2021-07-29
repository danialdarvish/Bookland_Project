using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using _01_Framework.Application;
using ShopManagement.Application.Contracts.Category;
using ShopManagement.Domain.CategoryAgg;

namespace ShopManagement.Application
{
    public class CategoryApplication : ICategoryApplication
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryApplication(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public OperationResult Create(CreateCategory command)
        {
            var operation = new OperationResult();
            if (_categoryRepository.Exists(x=>x.Name == command.Name))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var category = new Category(command.Name, command.Description, command.Keywords,
                command.MetaDescription, slug);

            _categoryRepository.Create(category);
            _categoryRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Edit(EditCategory command)
        {
            var operation = new OperationResult();
            var category = _categoryRepository.Get(command.Id);

            if (category == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_categoryRepository.Exists(x => x.Name == command.Name
            && x.Id != category.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            category.Edit(command.Name, command.Description, command.Keywords, command.MetaDescription,
                slug);

            _categoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public EditCategory GetDetails(long id)
        {
            return _categoryRepository.GetDetails(id);
        }

        public List<CategoryViewModel> Search(CategorySearchModel searchModel)
        {
            return _categoryRepository.Search(searchModel);
        }
    }
}
