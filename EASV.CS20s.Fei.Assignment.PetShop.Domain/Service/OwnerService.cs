using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.Service
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _iOwnerRepository;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _iOwnerRepository = ownerRepository;
        }
        
        
        public Owner Add(Owner owner)
        {
            return _iOwnerRepository.Create(owner);
        }

        public Owner Delete(int id)
        {
            return _iOwnerRepository.Remove(id);
        }

        public Owner Modify(int id, Owner owner)
        {
            return _iOwnerRepository.Update(id, owner);
        }

        public Owner Get(int id)
        {
            return _iOwnerRepository.Read(id);
        }

        public List<Owner> GetAll()
        {
            return _iOwnerRepository.ReadAll();
        }
    }
}