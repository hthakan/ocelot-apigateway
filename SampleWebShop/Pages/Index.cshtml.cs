using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleWebShop
{
    public class IndexModel : PageModel
    {
        private readonly ICatalogService _catalogService;

        public IndexModel(ICatalogService catalogService)
        {
            _catalogService = catalogService ?? throw new ArgumentNullException(nameof(catalogService));
        }

        public IEnumerable<CatalogModel> ProductList { get; set; } = new List<CatalogModel>();

        public async Task<IActionResult> OnGetAsync()
        {
            ProductList = await _catalogService.GetCatalog();
            return Page();
        }
    }
}
