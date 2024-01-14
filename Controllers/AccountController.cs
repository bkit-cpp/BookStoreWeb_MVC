using BookStoreMVCWeb.Models;
using BookStoreMVCWeb.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreMVCWeb.Controllers
{
	public class AccountController : Controller
	{
		private UserManager<AppUser> _userManager;
		private SignInManager<AppUser> _signInManager;
		public AccountController(SignInManager<AppUser>signInManager, UserManager<AppUser>userManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}
		public IActionResult Login(string returnUrl)
		{
			return View(new LoginVm { ReturnUrl=returnUrl });
		}
		[HttpPost]
		public async Task<IActionResult> Login(LoginVm loginVm)
		{
			if (!ModelState.IsValid)
			{
				Microsoft.AspNetCore.Identity.SignInResult result = await
					_signInManager.PasswordSignInAsync(loginVm.UserName, loginVm.Password, false, false);
              //  var user = await _userManager.FindByNameAsync(loginVm.UserName);
                if (result.Succeeded)
				{

                    return Redirect(loginVm.ReturnUrl ?? "/");

                    //return Redirect(loginVm.ReturnUrl ?? "/admin");
                }
                else if(loginVm.UserName == "admin" && loginVm.Password == "admin123")
				{
                    return Redirect(loginVm.ReturnUrl ?? "/admin");
                }
                //else
                //{

                //}
                //else if (loginVm.UserName=="admin" && loginVm.Password=="admin123") 
                //{

                //	return Redirect(loginVm.ReturnUrl ?? "/admin");
                //}

            }
            ModelState.AddModelError("", "Invalid username or password");
            return View(loginVm);
		}
		public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
		public async Task< IActionResult> Create(UserVm user)
		{
           
            if (ModelState.IsValid)
			{
				AppUser newUser = new AppUser 
				{ 
					UserName=user.UserName,
					Email=user.Email,
					Opccupation=user.Opccupation
					
				};
                IdentityResult result = await _userManager.CreateAsync(newUser, user.Password);
				if (result.Succeeded)
				{
                
                    TempData["success"] = "Tạo user Thành Công ";
					return Redirect("/account/login");
				}
				foreach (IdentityError error in result.Errors)
				{
					ModelState.AddModelError("", error.Description);
				}
            }
			return View(user);
		}
		public async Task<IActionResult> LogOut(string ReturnUrl= "/")
		{
			await _signInManager.SignOutAsync();
			return Redirect(ReturnUrl);
		}
	}
}
