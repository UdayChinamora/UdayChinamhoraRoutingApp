
using Microsoft.AspNetCore.Identity;

using System.Threading.Tasks;

using UdayChinhamoraWebsite.Models;

namespace UdayChinhamoraWebsite.Repository
{
    public class IAccountRepository
    {
       Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task SignOutAsync();

    }
}
