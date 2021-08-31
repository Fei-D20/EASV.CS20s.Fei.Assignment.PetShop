using System;
using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepositoryService;
using EASV.CS20s.Fei.Assignment.PetShop.Entities;
using EASV.CS20s.Fei.Assignment.PetShop.IConverter;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataBase.RepositoriesService
{
    public class PetRepositoryService : IPetRepositoryService
    {
        public static List<PetEntity> PetEntities { get; set; } = new();
        private static int _id = 1;
        private readonly IPetConverter _petConverter;

        public PetRepositoryService(IPetConverter iPetConverter)
        {
            _petConverter = iPetConverter;
        }

        public Pet Create(Pet pet)
        {
            
            throw new NotImplementedException();

        }

        public Pet Remove(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Pet Update(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Pet Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}