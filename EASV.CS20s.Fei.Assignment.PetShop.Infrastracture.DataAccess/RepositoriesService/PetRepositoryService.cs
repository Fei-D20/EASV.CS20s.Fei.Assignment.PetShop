using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepositoryService;
using EASV.CS20s.Fei.Assignment.PetShop.Entity;

namespace EASV.CS20s.Fei.Assignment.PetShop.RepositoriesService
{
    public class PetRepositoryService : IPetRepositoryService
    {
        private List<PetEntity> _petEntities;

        public PetRepositoryService(List<PetEntity> petEntities)
        {
            _petEntities = petEntities;
        }
        
        public bool Create(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public Pet Update(Pet pet)
        {
            throw new System.NotImplementedException();
        }

        public Pet Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Pet> ReadAll()
        {
            throw new System.NotImplementedException();
        }
    }
}