using System;
using System.Collections.Generic;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepositoryService;
using EASV.CS20s.Fei.Assignment.PetShop.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.Infrastructure.DataSource.RepositoriesService
{
    public class PetTypeRepositoryService : IPetTypeRepositoryService
    {
        public static List<PetTypeEntity> PetTypeEntities { get; set; } = new();

        public PetType Create(PetType petType)
        {
            throw new NotImplementedException();

        }

        public PetType Remove(PetType petType)
        {
            throw new NotImplementedException();
        }

        public PetType Update(PetType petType)
        {
            throw new NotImplementedException();
        }

        public PetType Read(PetType petType)
        {
            throw new NotImplementedException();
        }

        public List<PetType> ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}