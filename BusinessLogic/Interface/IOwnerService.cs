
using Model;
using Model.ModelDTO;

namespace BusinessLogic.Interface
{
    public interface IOwnerService
    {
        IEnumerable<Owner> GetUsers();

        IQueryable<Owner> GetUser(int id);

        void Delete(int id);

        void Create(OwnerDTO model);

        void Edit(OwnerDTO model);

    }
}
