# Tutorial ASP.NET Core

## [001. ASP.NET Core Tutorial](https://www.youtube.com/watch?v=4IgC2Q5-yDE&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU)
## [057. Handling 404 not found in ASP. NET Core MVC](https://www.youtube.com/watch?v=QiF3eJ4Zb0o&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=57)
## [058. Centralised 404 error handling in ASP.NET Core](https://www.youtube.com/watch?v=DVo138knAHQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=58)
* https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-3.1
## [059. UseStatusCodePagesWithRedirects vs UseStatusCodePagesWithReExecute](https://www.youtube.com/watch?v=9CwgiSxrkeQ&list=PL6n9fhu94yhVkdrusLaQsfERmL_Jh4XmU&index=59)
* https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-3.1#usestatuscodepageswithredirects
* https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-3.1#usestatuscodepageswithreexecute

_UseStatusCodePagesWithReExecute_ est à privilégier. Cette méthode implémente le comportement correct.  
Dans l'exemple, elle retourne un code HTTP 404 (not found) et l'URL dans le navigateur ne change pas.