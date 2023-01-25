using WebAPI_Token_SQL.Models.Request;
using WebAPI_Token_SQL.Models.Response;

namespace WebAPI_Token_SQL.Services
{
    public interface IUserService
    {
        UserResponse Auth(AuthRequest model);
    }
}
