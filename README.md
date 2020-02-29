# To Do List Application
*Author: Biniam Tesfamariam*

----

## Application Summary

## Features:  
-  Create a task  
-  Label a task as completed or uncompleted  
-  Set task priority  
-  Edit task
-  Delete a task  
-  View all tasks  

## Application Specifications
###### Application includes the following:  

#### 1) Startup File  
- Explicit routing of MVC  
- MVC dependency in ConfigureServices  
- DBContext registered in ConfigureServices  
- Use of static files accepted  
#### 2) Controller  
- Home Controller  
#### 3) Data  
- DBContext present and properly configured  
- DB Table for entity model (DbSet<Lists>) created    
- appsettings.json file present with name of database updated.  
#### 4) Models  
- Entity from the DB Table converted into a Model  
- Proper naming conventions of Primary keys  
- Enum present in appropriate model  
#### 5) Views  
- Razor Views created for about, contact, create, delete, details, edit, index, and privacy page that matches default routing   
#### 6) Web application should build, compile, and redirect us to the home page upon launch.  

## Technologies used:  
- C#  
- Visual Studio 2019  
- ASP.NET Core  
- Bootstrap
- Sql Server
- CSS
---

### Getting Started
Clone this repository to your local machine.

```
$ git clone https://github.com/biniamsea2/ToDoApplication.git
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```ToDoApplication``` directory.

Then select and open ```ToDoApplication```

---

### Visuals

### Entity Relationship Diagram
![Image 1]()
### Application Home Page
![Image 1]()
### View all Tasks  
![Image 1]()
### Editing a Task
![Image 1]()
### Deleting a Task
![Image 1]()

---
### ToDoPackage Table:  
The ToDoPackage table consists of all the tasks' information that is required when creating a new task. It includes the primary ID key, task, priority level, completion, and due date. 

------------------------------
