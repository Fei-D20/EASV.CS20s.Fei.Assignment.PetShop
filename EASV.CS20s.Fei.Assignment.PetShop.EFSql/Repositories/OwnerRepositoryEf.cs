using System.Collections.Generic;
using System.Linq;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;
using EASV.CS20s.Fei.Assignment.PetShop.EFSql.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.EFSql.Repositories
{
    public class OwnerRepositoryEf : IOwnerRepository
    {
        private readonly PetShopApplicationContext _ctx;

        public OwnerRepositoryEf(PetShopApplicationContext ctx)
        {
            _ctx = ctx;
        }


        public Owner Create(Owner owner)
        {
            OwnerEntity ownerEntity = new OwnerEntity()
            {
                Address = owner.Address,
                Email = owner.Email,
                FirstName = owner.FirstName,
                LastName = owner.LastName,
                PhoneNumber = owner.PhoneNumber
            };

            var savedEntity = _ctx.Add(ownerEntity).Entity;

            _ctx.SaveChanges();

            return new Owner()
            {
                Address = savedEntity.Address,
                Email = savedEntity.Email,
                FirstName = savedEntity.FirstName,
                LastName = savedEntity.LastName,
                PhoneNumber = savedEntity.PhoneNumber,
                Id = savedEntity.Id
            };
        }

        public Owner Remove(int id)
        {
            var firstOrDefault = _ctx.Owners.FirstOrDefault(o => o.Id == id);
            var removedEntity = _ctx.Remove(firstOrDefault).Entity;
            _ctx.SaveChanges();
            return new Owner()
            {
                Id = firstOrDefault.Id,
                Address = firstOrDefault.Address,
                Email = firstOrDefault.Email,
                FirstName = firstOrDefault.FirstName,
                LastName = firstOrDefault.LastName,
                PhoneNumber = firstOrDefault.PhoneNumber
            };
        }

        public Owner Update(int id,Owner owner)
        {
            OwnerEntity ownerEntity = new OwnerEntity()
            {
                Id = id,
                Address = owner.Address,
                Email = owner.Email,
                FirstName = owner.FirstName,
                LastName = owner.LastName,
                PhoneNumber = owner.PhoneNumber
            };

            var updatedEntity = _ctx.Update(ownerEntity).Entity;

            _ctx.SaveChanges();

            return new Owner()
            {
                Address = updatedEntity.Address,
                Email = updatedEntity.Email,
                FirstName = updatedEntity.FirstName,
                LastName = updatedEntity.LastName,
                PhoneNumber = updatedEntity.PhoneNumber,
                Id = updatedEntity.Id
            };
        }

        public Owner Read(int id)
        {
            return _ctx.Owners
                .Select(ownerEntity => new Owner()
                {
                    Id = ownerEntity.Id,
                    Address = ownerEntity.Address,
                    Email = ownerEntity.Email,
                    FirstName = ownerEntity.FirstName,
                    LastName = ownerEntity.LastName,
                    PhoneNumber = ownerEntity.PhoneNumber

                }).FirstOrDefault(v => v.Id == id);
        }

        public List<Owner> ReadAll()
        {
            return _ctx.Owners
                .Select(ownerEntity => new Owner() 
                {
                    Id = ownerEntity.Id,
                    Address = ownerEntity.Address,
                    Email = ownerEntity.Email,
                    FirstName = ownerEntity.FirstName,
                    LastName = ownerEntity.LastName,
                    PhoneNumber = ownerEntity.PhoneNumber
                
                })
                .ToList();
        }
        
    }
}