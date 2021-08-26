EASV.CS20s.Fei.Assignment.PetShop

This is the first compulsory assignment at 3rd semester EASV CS20s. 



## Vision

This application is a console application which is working for pet trade service. It should can manage the pet in the shop. Offer the pet trading service for the customer which is add, delete, update, search, sort the pet information. Offer the sales UI to customer to use the service. Offer the manage UI to control the pet in the shop. 

This application should based on the Onion architecture to organise the structure of code. Following the architecture it should easy to improve the application to add the different model and component. 

This application’s language is C# based on .NET Core.

## The Structure (Solution level)

```mermaid
classDiagram
class Pet
class PetType

Pet "1"-->"*" PetType

class IPetService
class IPetTypeService

Pet <.. IPetService
PetType <.. IPetTypeService

class PetService
class PetTypeService

IPetService <|.. PetService
IPetTypeService <|.. PetTypeService

class IPetRepository
class IPetTypeRepository



PetService <.. IPetRepository
PetTypeService <.. IPetTypeRepository

class PetRepository
class PetTypeRepository

Pet ..> PetRepository
PetType ..> PetTypeRepository

IPetRepository <|.. PetRepository
IPetTypeRepository <|.. PetTypeRepository

```



### Core

#### Models

Pet

```mermaid
classDiagram
class Pet{
+int Id
+string Name
+PetType PetType
+DateTime Birthdate
+DateTime? SoldDate
+string Color
+double? Price
}
```



PetType

```mermaid
classDiagram
class PetType{
+int Id
+string Type
}
```





#### IService

IPetService

``` mermaid
classDiagram
class IPetService{
<<interface>>
+Add(Pet pet) bool
+Delete(Pet pet) bool
+Modify(Pet pet) Pet
+Get(Pet pet) Pet
+GetAll() List<Pet>
}
```



IPetTypeService

```mermaid
classDiagram
class IPetTypeService{
<<interface>>
+Add(PetType petType) bool
+Delete(PetType petType) bool
+Modify(PetType petType) PetType
+Get(PetType petType) PetType
+GetAll() List<PetType>
}
```





### Domain

#### Service

PetService

```mermaid
classDiagram
class PetService
class IPetService
IPetService <|.. PetService
```



PetTypeService

```mermaid
classDiagram
class PetTypeService
class IPetTypeService
IPetTypeService <|.. PetTypeService
```



#### IRepositories

IPetRepository

```mermaid
classDiagram
class IPetRepositories{
<<interface>>
+Create(Pet pet) bool
+Remove(int id) bool
+Update(Pet pet) Pet
+Read(int id) Pet
+ReadAll() List<Pet>
}
```



IPetTypeRepository

```mermaid
classDiagram
class IPetTypeRepositories{
<<interface>>
+Create(PetType petType) bool
+Remove(int id) bool
+Update(PetType petType) Pet
+Read(int id) Pet
+ReadAll() List<PetType>
}
```



#### IUI

IMenuService

#### ITest

ITestService





### Infrastructure

#### Repository

PetRepository

PetTypeRepository

#### RepositoryService

PetRepositoryService

PetTypeRepository



### UI

#### Menu

#### MenuService



### Test 

Test





