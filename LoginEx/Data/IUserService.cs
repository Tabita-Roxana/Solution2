using LoginEx.Models;

namespace LoginEx.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
    }
}