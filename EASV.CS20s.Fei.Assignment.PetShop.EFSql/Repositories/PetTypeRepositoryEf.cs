using System;
using System.Collections.Generic;
using System.Linq;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;
using EASV.CS20s.Fei.Assignment.PetShop.EFSql.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.EFSql.Repositories
{
    public class PetTypeRepositoryEf : IPetTypeRepository
    {
        private readonly PetShopApplicationContext _ctx;

        public PetTypeRepositoryEf(PetShopApplicationContext ctx)
        {
            _ctx = ctx;
        }


        public PetType Create(PetType petType)
        {
            var petTypeEntity = new PetTypeEntity()
            {
                Type = petType.Type
            };

            var savedEntity = _ctx.Add(petTypeEntity).Entity;

            _ctx.SaveChanges();

            return new PetType()
            {
                Id = savedEntity.Id,
                Type = savedEntity.Type
            };
        }

        public PetType Remove(int id)
        {
            var removedEntity = _ctx.Remove(new PetTypeEntity(){Id = id}).Entity;
            _ctx.SaveChanges();
            return new PetType()
            {
                Id = removedEntity.Id,
                Type = removedEntity.Type
            };
        }

        public PetType Update(int id, PetType petType)
        {
            var petTypeEntity = new PetTypeEntity()
            {
                Id = id,
                Type = petType.Type
            };

            var updateEntity = _ctx.Update(petTypeEntity).Entity;
            _ctx.SaveChanges();

            return new PetType()
            {
                Id = updateEntity.Id,
                Type = updateEntity.Type
            };

        }

        public PetType Read(int id)
        {
            return _ctx.PetTypes.Select(entity => new PetType()
            {
                Id = entity.Id,
                Type = entity.Type
            }).FirstOrDefault(v => v.Id == id);
        }

        public List<PetType> ReadAll()
        {
            return _ctx.PetTypes.Select(entity => new PetType()
            {
                Id = entity.Id,
                Type = entity.Type
            }).ToList();
        }
    }
}