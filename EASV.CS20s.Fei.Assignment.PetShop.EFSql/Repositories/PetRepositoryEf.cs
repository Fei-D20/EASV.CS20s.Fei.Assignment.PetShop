using System.Collections.Generic;
using System.Linq;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Filtering;
using EASV.CS20s.Fei.Assignment.PetShop.Core.Models;
using EASV.CS20s.Fei.Assignment.PetShop.Domain.IRepository;
using EASV.CS20s.Fei.Assignment.PetShop.EFSql.Entities;

namespace EASV.CS20s.Fei.Assignment.PetShop.EFSql.Repositories
{
    public class PetRepositoryEf : IPetRepository
    {
        private readonly PetShopApplicationContext _ctx;

        public PetRepositoryEf(PetShopApplicationContext ctx)
        {
            _ctx = ctx;
        }

        public Pet Create(Pet pet)
        {
            var petEntity = new PetEntity()
            {
                Name = pet.Name,
                Color = pet.Color,
                Birthdate = pet.Birthdate,
                Price = pet.Price,
                SoldDate = pet.SoldDate,
                OwnerId = pet.Owner.Id,
                PetTypeId = pet.PetType.Id
                
            };
            
            var saveEntity = _ctx.Pets.Add(petEntity).Entity;
            
            _ctx.SaveChanges(); // it is vary important like excute. 
            
            return new Pet()
            {
                Id = saveEntity.Id,
                Name = saveEntity.Name,
                Owner = new Owner()
                {
                    Id = saveEntity.OwnerId
                },
                PetType = new PetType()
                {
                    Id = saveEntity.PetTypeId
                },
                Birthdate = saveEntity.Birthdate,
                Color = saveEntity.Color,
                Price = saveEntity.Price,
                SoldDate = saveEntity.SoldDate
            };
        }

        public Pet Remove(int id)
        {
            var removedEntity = _ctx.Remove(new PetEntity(){Id = id}).Entity;
            _ctx.SaveChanges();
            return new Pet()
            {
                Birthdate = removedEntity.Birthdate,
                Color = removedEntity.Color,
                Id = removedEntity.Id,
                Name = removedEntity.Name,
                Owner = new Owner()
                {
                    Id = removedEntity.OwnerId
                },
                PetType = new PetType()
                {
                    Id = removedEntity.PetTypeId
                },
                Price = removedEntity.Price,
                SoldDate = removedEntity.SoldDate
            };
        }

        public Pet Update(int id, Pet pet)
        {
            var petEntity = new PetEntity()
            {
                Birthdate = pet.Birthdate,
                Color = pet.Color,
                Id = id,
                Name = pet.Name,
                OwnerId = pet.Owner.Id,
                PetTypeId = pet.PetType.Id,
                Price = pet.Price,
                SoldDate = pet.SoldDate
            };

            var updateEntity = _ctx.Update(petEntity).Entity;

            _ctx.SaveChanges();

            return new Pet()
            {
                Birthdate = updateEntity.Birthdate,
                Color = updateEntity.Color,
                Id = updateEntity.Id,
                Name = updateEntity.Name,
                Price = updateEntity.Price,
                SoldDate = updateEntity.SoldDate,
                Owner = new Owner()
                {
                    Id = updateEntity.OwnerId
                },
                PetType = new PetType()
                {
                    Id = updateEntity.PetTypeId
                }
            };
        }

        public Pet Read(int id)
        {
            return _ctx.Pets.Select(entity => new Pet()
            {
                Birthdate = entity.Birthdate,
                Color = entity.Color,
                Id = entity.Id,
                Name = entity.Name,
                Owner = new Owner()
                {
                    Id = entity.OwnerId
                },
                PetType = new PetType()
                {
                    Id = entity.PetTypeId
                },
                Price = entity.Price,
                SoldDate = entity.SoldDate
            }).FirstOrDefault(v => v.Id == id);
        }
        

        public List<Pet> ReadAll(Filter filter)
        {
            return _ctx.Pets
                .Select(petEntity => new Pet() 
                {
                Id = petEntity.Id,
                Name = petEntity.Name,
                Color = petEntity.Color,
                Birthdate = petEntity.Birthdate,
                Price = petEntity.Price,
                SoldDate = petEntity.SoldDate,
                Owner = new Owner()
                {
                    Id = petEntity.OwnerId
                },
                PetType = new PetType()
                {
                    Id = petEntity.PetTypeId
                }
                
                })
                .Skip(filter.Count * (filter.Page - 1))
                .Take(filter.Count)
               // .OrderBy(v => v.Name)
                .ToList();
        }

        public int GetTotalCount()
        {
            return _ctx.Pets.Count();
        }
    }
}