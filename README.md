# Michael_Fibonacci

This is a Fibonacci code written in C# with Recursion Versus Iteration Solutions

The solution is built with .Net Core with Web MVC model, and it is also published at http://fibonacci-demo.azurewebsites.net  which hosted 

in Azure environment and it is a public web site.  Type in what Fibonacci number you 

want to try, the web page will show you the result for both iteration approach and recursive apporach. Since the original Recursive 

approach takes too many resources the performance was really slow when calculating F(30) and higher number, it is optimized by using 

Dictionary to store the historical result and improved the performance. The performance is improved tremendensly after using the dictionary check to store the historic result for recursive approach. 

The calculation class is a public static class which means that it can be accessed from any project inside the solution, Azure web applicaton and the testing project.

Unit Testing project is added for developers to test the calculation result for all three methods (Iteration, Recursion and Optimized Recursion) with VS tools.

Since the solution is implemented using .Net Core, it is portable and can be deployed into Windows, Mac OS and Linux systems and will be a standalone solution, which is independent from any other system/application/Frameworks. The Azure web site has visula accessf for end users/Business stakeholders and they can access the web site from anywhere, on any device.

This Azure Web Site can be used for testing purpose to check if both Solution return same result.

The Source code is published at https://github.com/mren2006/Michael_Fibonacci 

Note:

For CICD and release management apporach, this source code can be built and uploaded to Visual Studio Team Service, and then create

Versional control, Testing, deploy and publish process to support release management type of Agile work. 

On Azure web Site, people can also configure the release management process so that the publishing process can be automated. 

Both approaches will be discussed with the technical Consultant and practice manager.


