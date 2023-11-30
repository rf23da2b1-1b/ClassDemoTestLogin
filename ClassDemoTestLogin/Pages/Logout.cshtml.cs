using ClassDemoTestLogin.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassDemoTestLogin.Pages
{
    public class LogoutModel : PageModel
    {
        private IUserRepository _userRepository;

        public LogoutModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult OnGet()
        {
            _userRepository.LogoutUser();

            return RedirectToPage("Index");
        }
    }
}
