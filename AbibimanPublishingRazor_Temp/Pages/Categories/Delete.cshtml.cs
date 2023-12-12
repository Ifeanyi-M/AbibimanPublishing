using AbibimanPublishingRazor_Temp.Data;
using AbibimanPublishingRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbibimanPublishingRazor_Temp.Pages.Categories
{
	[BindProperties]
    public class DeleteModel : PageModel
    {
		private readonly ApplicationDbContext _db;

        public Category category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
			_db = db;
		}
		public void OnGet(int? id)
		{
			if (id != null && id != 0)
			{
				category = _db.Categories.FirstOrDefault(u => u.Id == id);
			}
		}

		public IActionResult OnPost()
		{
			Category? obj = _db.Categories.Find(category.Id);

			if (obj == null)
			{
				return NotFound();
			}

			_db.Categories.Remove(obj);

			_db.SaveChanges();
			TempData["success"] = "Category deleted successfully";
			return RedirectToPage("Index");
		}
	}
}
