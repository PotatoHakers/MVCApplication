
using Model;
using Model.ModelDTO;

namespace BusinessLogic.Interface
{
    public interface IAuthorizationService
    {
        string CreateToken(Owner owner);
    }
}
