
using AutoMapper;
using BusinessLogic.Interface;
using Model;
using Model.ModelDTO;
using MVCApplication;

namespace BusinessLogic.Service
{
    public class OwnerService : IOwnerService
    {
        private readonly ApplicationContext _appContext;
        private readonly IMapper _mapper;

        public OwnerService(ApplicationContext carAppContext, IMapper mapper)
        {
            _appContext = carAppContext;
            _mapper = mapper;
        }

        public IEnumerable<Owner> Get()
        {
            return _appContext.Owner.ToList();
        }

        public IQueryable<Owner> Get(int id)
        {
            return _appContext.Owner.Where(x => x.Id == id);
        }

        public void Delete(int id)
        {
            _appContext.Owner.Remove(Get(id).FirstOrDefault());
            _appContext.SaveChanges();
        }
        
        public void Create(OwnerDTO model)
        {
            if (_appContext.Owner.Any(x => x.Email == model.Email))
                throw new Exception($"Пользователь {model.Email} уже зарегистрирован.");

            var owner = _mapper.Map<OwnerDTO, Owner>(model);
            
            owner.Name = model.Name;
            owner.Email = model.Email;

            _appContext.Owner.Add(owner);
            _appContext.SaveChanges();
        }

        public void Edit(OwnerDTO model)
        {
            var user = _mapper.Map<OwnerDTO, Owner>(model);

            user.Name = model.Name;
            user.Email = model.Email;

            _appContext.Update(user);
            _appContext.SaveChanges();
        }

        public IEnumerable<Owner> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Owner> GetUser(int id)
        {
            throw new NotImplementedException();
        }

    }
}
