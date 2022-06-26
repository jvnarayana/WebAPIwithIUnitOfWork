# WebAPIwithIUnitOfWork

This Project mainly focuses about Unit of Work and Repository Pattern. You can learn more about Repository Pattern on below MSDN article. 

https://docs.microsoft.com/en-us/previous-versions/msp-n-p/ff649690(v=pandp.10)?redirectedfrom=MSDN

**What is Repository Pattern?**


A repository separates the business logic from the interactions with the underlying data source or Web service. The separation between the data and business tiers has three benefits:

It seperates the Business Logic and Data Access Layer from UI Layer. It mediates the interaction between Business Entity and Data Access.

**Unit Of Work:**


Unit of Work Pattern is a design pattern with which you can expose various respostiories in our application. It has very similar properties of dbContext, just that Unit of Work is not coupled to any framework like dbContext to Entity Framework Core.
What happens when there are quite more than 2 repositories. It would not be practical to keep adding new injections every now and then. Inorder to wrap all the Repositories to a Single Object, we use Unit Of Work.

Unit of Work is responsible for exposing the available Repositories and to Commit Changes to the DataSource ensuring a full transaction, without loss of data.


<img width="1047" alt="Screen Shot 2022-06-26 at 12 11 58 AM" src="https://user-images.githubusercontent.com/29008310/175800368-426faacb-2bbe-403e-b2ab-8e11033a5523.png">


