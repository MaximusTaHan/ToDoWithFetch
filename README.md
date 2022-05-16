# To-do App with Fetch API
This application uses a web API backend with C# and Fetch API on the frontend. Database with EF, SQL server. Styled with Bootstrap.

This app was primarily to learn to use fetch API and some form validation in JS.

## Requirements
- [x] This is an application where you should manage a todo list.
- [x] Users should be able to Add, Delete, Update and Read from a database, using a SPA (single-page application). The user should never be redirected to a new page.
- [x] You need to use Entity Framework, raw SQL isn't allowed.
- [x] You don't need a navigation bar. No menu is necessary since you'll only have one page
- [x] Once you execute any operation, the todo-list needs to be updated accordingly.
- [x] Your data model is only one table with to-dos. You. might be tempted to create more complex data-models (categories of todos for example) but avoid that for now. We're focusing on the front-end.

## Features
### Frontend
- Single page application with basic CRUD functionality
- To-do list that does not allow duplicate entries
- Fetch API to handle http requests

![Add](https://user-images.githubusercontent.com/91058022/168605934-75b0aae8-784f-4e15-82a0-0d2702ab3574.png)

![Error](https://user-images.githubusercontent.com/91058022/168605753-ad6cb4b6-f637-42a4-a804-c94bb0d2a9b1.png)

### Backend
- Web API with EF
- SQL server database

## Challenges
- Managing where to do input validation on the frontend was not completely obvious. The solution works fine but there could be better separation of concerns.
- Debugging JavaScript continues to be somewhat difficult.
- Apparantly your browser can cache your JavaScript which results in your changes not taking place unless you disable this.

## What i learned
- To use Fetch API and map responses to a DOM.
- How to pick out elements from HTML in javascript and manipulate it.
- Input validation with JavaScript.
