# EASV.CS20s.Fei.Assignment.PetShop

This is the first compulsory assignment at 3rd semester EASV CS20s. 

## Assignment Requirement

> ###  Pet Shop, developed with the Clean (Onion) Architecture
>
> #### Required Features:
>
> - Show list of choices (Pure UI, Add one choice at a time)
> - Show list of all Pets
> - Search Pets by Type (Cat, Dog, Goat) *Yes Goats can be pets :D
> - Create a new Pet
> - Delete Pet
> - Update a Pet
> - Sort Pets By Price
> - Get 5 cheapest available Pets
> - Code Available on Github
>
> #### Pet properties:
>
> - ID: int
> - Name: string
> - Type: PetType
> - Birthdate: DateTime
> - SoldDate: DateTime
> - Color: string
> - Price: double
>
> 
>
> #### PetType properties:
>
> - ID: int
> - Name: string
>
> 
>
> #### How to proceed:
>
> - Initial Plumbing:
>
> - [ ] Setup initial projects (Core, Domain, Infrastructure.Data, UI)
> - [ ] Add Pet and PetType to Core.Models
> - [ ] Add Interface for PetService and PetTypeService in Core.IServices (IPetService, IPetTypeService)
> - [ ] Add Interface for PetRepository and PetTypeRepository in Domain.IRepositories (IPetRepository, IPetTypeRepository)
> - [ ] Add Implementation Class for PetService and PetTypeService in Domain.Services
> - [ ] First Feature - List All Pets:
>
> ------------ UI ------------------
>
> Add a new Class for printing UI information (Menu or whatever you wish to call it)
> In Constructor add IPetService
> Get all Pets using the Service and print them (in Constructor or a new method)
> In the Program.CS File Add DI if it is not already setup
> ------------ Core ---------------
>
> Add Pet Model if its not there
> Add a GetPets that returns a List<Pet> in IPetService
> ------------ Domain ---------------
>
> Add IPetRepository in PetService Constructor if it is not there
> Implement GetPets in PetService Implementation
> Add a ReadPets that returns a List<Pet> in IPetRepository
> ------------ Infrastructure Data --------------
>
> Create a FakeDB Class to represent our SQL Database and make it public
> Add a private static List<Pet> and List<PetType> and a private static int id in FakeDB
> Add a PetRepository (impl of IPetRepository) class
> Implement ReadPets so it return the list of pets
> -------------- Dependency Injection -----------
>
> Using NuGet package in UI project get the following package (remember to go to browse tab) Microsoft.Extensions.DependencyInjection
> Type the magic dependency injection code found here: DI code
> ------------- Test it -----------------------
>
> Run Program to see if it works
> Fails? --- DEBUG ----
> Runs? ----- CLAP YOUR HANDS -----
> ---------------- Next Feature ---------------
>
> Start creating the next feature, maybe Create Pet or Delete Pet?
>
> Optional Features:
>
> If you have completed required features add a new Model called Owner and add a PreviousOwner property in Pet  You can also add full CRUD for owners
>
> Model changes:
>
> New Pet property
>
> PreviousOwner: Owner
> Owner properties:
>
> Id: int
> FirstName: string
> LastName: string
> Address: string
> PhoneNumber: string
> Email: string