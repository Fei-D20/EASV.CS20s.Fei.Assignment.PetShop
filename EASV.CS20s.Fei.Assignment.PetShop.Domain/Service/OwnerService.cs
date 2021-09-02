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

        public Owner Delete(Owner owner)
        {
            return _iOwnerRepository.Remove(owner);
        }

        public Owner Modify(Owner owner)
        {
            return _iOwnerRepository.Update(owner);
        }

        public Owner Get(Owner owner)
        {
            return _iOwnerRepository.Read(owner);
        }

        public List<Owner> GetAll()
        {
            return _iOwnerRepository.ReadAll();
        }
    }
}