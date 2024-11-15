using Foody.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultCategorySectionComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public _DefaultCategorySectionComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
    }
}
