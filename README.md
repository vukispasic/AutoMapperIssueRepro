# AutoMapperIssueRepro
This solution reproduces performance issue in AutoMapper v5 compared to performance in v4

There are 2 console apps, AutoMapper v4 and AutoMapper v5 running same scenario. Apps measure time needed to configure mapper and to execute mappings of entities to DTO's.
Database model is ommited, all properties beside navigational properties are removed and entity classes are renamed.
Removing properties improved performance but not enough (mapping of Entity1 was 20 seconds, now it is 3.5 seconds with AutoMapper v5).
With v4 it's close to 0.1 seconds. 
In ASP.NET application with full database model for mapping Entity1 we are also getting 20 seconds delay after which we get stackoverflow exception which I can't reproduce in console app.
We added mappings of other entities from our database model which also perform slow (around 1 sec) like Entity17 and Entity25 etc. 
On the contrary, mapping of some other entities from our model goes very fast.
This performance issue occurs only first time entity is mapped, next mappings of same entity type goes fast. 
I tried to make scenario which can reproduce this performance issue we noticed.
Current version of AutoMapper v4 in project is 4.2.1. Version of v5 is 5.3.0-alpha-01269
