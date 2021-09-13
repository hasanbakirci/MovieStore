 ## MovieStore Case

 This project is a simple movie store project.
 
 `dotnet ef migrations add migrationName`

 `dotnet ef database update`

 `dotnet watch run`
 
 ##  Requirements

 - Postgresql
 - .Net 5

 ## 3rd Party Libraries

- EntityFramework
- FluentValidation
- Automapper
- Swagger
## Endpoints
___
## Actors
| Endpoint                | Desc                                                     |
|-------------------------|----------------------------------------------------------|
| GET  /Actors| Get actors
| POST /Actors| Create actor 
| DELETE  /Actors/uuidv4| Delete actor  
| GET  /Actors/uuidv4| Get actor                             
| PUT /Actors/uuidv4| Update actor        
| GET  /FilmsOfActor| Get films of actor

## Customers
| Endpoint                | Desc                                                     |
|-------------------------|----------------------------------------------------------|
| GET  /Customers| Get customers
| POST /Customers| Create customer 
| DELETE  /Customers/uuidv4| Delete customer  
| GET  /Customers/uuidv4| Get customer                             
| PUT /Customers/uuidv4| Update customer        

## Directors
| Endpoint                | Desc                                                     |
|-------------------------|----------------------------------------------------------|
| GET  /Directors| Get directors
| POST /Directors| Create director 
| DELETE  /Directors/uuidv4| Delete director  
| GET  /Directors/uuidv4| Get director                             
| PUT /Directors/uuidv4| Update director
| GET /FilmsOfDirector| Get films of director 

## Films
| Endpoint                | Desc                                                     |
|-------------------------|----------------------------------------------------------|
| GET  /Films| Get films
| POST /Films| Create film 
| DELETE  /Films/uuidv4| Delete film  
| GET  /Films/uuidv4| Get film                             
| PUT /Films/uuidv4| Update film
| POST /Actor| Add films of actor
| GET  /Actor| Get films of actor
| POST /Director| Add films of director
| GET /Director| Get films of director

## Orders
| Endpoint                | Desc                                                     |
|-------------------------|----------------------------------------------------------|
| GET  /Orders| Get orders
| POST /Orders| Create order  
| GET  /Orders/uuidv4| Get order                             
| GET /Film/uuidv4| Get orders by film
| GET /Customer/uuidv4| Get orders by customer