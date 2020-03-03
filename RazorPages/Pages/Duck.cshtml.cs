using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class Duck : PageModel
    {
        public IEnumerable<HelloWorld.Duck> SomeDucks { get; set; }
        public void OnGet()
        {
            SomeDucks = HelloWorld.Duck.GetDucks();
        }
    }
}