using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.IService;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepositoryService;

namespace EASV.CS20s.Fei.Assignment.PetShop.Domain.Service
{
    /// <summary>
    ///     This class is use for offer the function to CRUD the Pet Object.
    /// </summary>
    public class PetService : IPetService
    {
        private readonly IPetRepositoryService _iPetRepositoryService; // declare the variable 

        public PetService(IPetRepositoryService iPetRepositoryService) // trans from outside to inside
        {
            _iPetRepositoryService = iPetRepositoryService; // initialize the variable when the class be instantiate 
        }


        public Pet Add(Pet pet)
        {
            return _iPetRepositoryService.Create(pet);
        }

        public Pet Delete(Pet pet)
        {
            return _iPetRepositoryService.Remove(pet);
        }

        public Pet Modify(Pet pet)
        {
            return _iPetRepositoryService.Update(pet);
        }

        public Pet Get(Pet pet)
        {
            return _iPetRepositoryService.Read(pet.Id);
        }

        public List<Pet> GetAll()
        {
            return _iPetRepositoryService.ReadAll();
        }
    }
}