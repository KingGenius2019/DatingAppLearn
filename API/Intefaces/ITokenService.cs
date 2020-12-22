using API.Entities;

namespace API.Intefaces
{
    public interface ITokenService
    {
        string CreatToken(AppUser user);
    }
}