# Dotnet AddScoped, AddSingleton and AddTransient sample

Probably you have used one or more of these 3 extention methods.
In this project you can see the difference between AddScoped, AddSingleton and AddTransient exterion methods and how they work.

There are two routes in the project get1 and get2. The get1 route just calls each of the implementations that use these methods directly, while get2 calls the implementations through other methods. It's like a route that calls a service layer that calls the repository (in this case we have several dependency injections taking place).

Note: This is just for demonstration and it don't follow any pattern
