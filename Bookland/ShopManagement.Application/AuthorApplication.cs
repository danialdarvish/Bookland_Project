using System;
using System.Collections.Generic;
using _01_Framework.Application;
using ShopManagement.Application.Contracts.Author;
using ShopManagement.Domain.AuthorAgg;

namespace ShopManagement.Application
{
    public class AuthorApplication : IAuthorApplication
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorApplication(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }


        public OperationResult Create(CreateAuthor command)
        {
            var operation = new OperationResult();
            if (_authorRepository.Exists(x => x.FullName == command.FullName))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var author = new Author(command.FullName, command.Biography, command.Picture,
                command.PictureAlt, command.PictureTitle, slug, command.MetaDescription);

            _authorRepository.Create(author);
            _authorRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Edit(EditAuthor command)
        {
            var operation = new OperationResult();
            var author = _authorRepository.Get(command.Id);

            if (author == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (_authorRepository.Exists(x => x.FullName == command.FullName
                                              && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            author.Edit(command.FullName, command.Biography, command.Picture,
                command.PictureAlt, command.PictureTitle, slug, command.MetaDescription);

            _authorRepository.SaveChanges();

            return operation.Succeed();
        }

        public EditAuthor GetDetails(long id)
        {
            return _authorRepository.GetDetails(id);
        }

        public List<AuthorViewModel> Search(AuthorSearchModel searchModel)
        {
            return _authorRepository.Search(searchModel);
        }

        public List<AuthorViewModel> ListAuthors()
        {
            return _authorRepository.ListAuthors();
        }
    }
}
