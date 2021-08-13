using _01_BooklandQuery.Contract.Status;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class StatusViewComponent : ViewComponent
    {
        private readonly IStatusQuery _statusQuery;

        public StatusViewComponent(IStatusQuery statusQuery)
        {
            _statusQuery = statusQuery;
        }


        public IViewComponentResult Invoke()
        {
            var status = new StatusQueryModel
            {
                AllBooksCount = _statusQuery.GetAllBooksCount(),
                AllUsersCount = _statusQuery.GetAllUsersCount(),
                HappyUsersCount = _statusQuery.GetHappyUsersCount()
            };
            return View(status);
        }
    }
}
