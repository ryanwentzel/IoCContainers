# IoC Containers

I was curious how registration works in the various .NET IoC containers so I threw together some code to find out. The `Core` project contains classes that do type registration using:

- [Autofac](http://code.google.com/p/autofac/)    
- [Windsor](http://docs.castleproject.org/Default.aspx?Page=MainPage&NS=Windsor&AspxAutoDetectCookieSupport=1)  
- [StructureMap](https://github.com/structuremap/structuremap)  
- [Ninject](http://www.ninject.org/)  
- [Unity](http://unity.codeplex.com/)  

The `Core.Tests` project contains very basic unit tests for each of the registration classes.