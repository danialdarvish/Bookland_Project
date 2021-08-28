using System.Collections.Generic;
using _01_Framework.Infrastructure;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Comments
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public List<CommentViewModel> Comments;
        public CommentSearchModel SearchModel;


        private readonly ICommentApplication _commentApplication;
        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }


        [NeedsPermission(CommentPermissions.ListComments)]
        public void OnGet(CommentSearchModel searchModel)
        {
            Comments = _commentApplication.Search(searchModel);
        }

        [NeedsPermission(CommentPermissions.CancelComments)]
        public IActionResult OnGetCancel(long id)
        {
            var result = _commentApplication.Cancel(id);
            Message = result.Message;
            if (result.IsSucceed)
                return RedirectToPage("./Index");
            
            return RedirectToPage("./Index");

        }

        [NeedsPermission(CommentPermissions.ConfirmComments)]
        public IActionResult OnGetConfirm(long id)
        {
            var result = _commentApplication.Confirm(id);
            Message = result.Message;
            if (result.IsSucceed)
                return RedirectToPage("./Index");

            return RedirectToPage("./Index");
        }
    }
}
