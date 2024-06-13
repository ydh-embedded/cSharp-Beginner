# Xunit
- To add xUnit support to your project using the xunit and xunit.runner.visualstudio packages, follow these steps:

- Open your project in Rider.
- Open the "Package Manager Console" window by selecting "View" > "Tool Windows" > "Package Manager Console".
- In the Package Manager Console window, enter the following command to install the xunit package:

````ps
    >> Powershell 
    
    Install-Package xunit
````

- After the xunit package is installed, enter the following command to install the xunit.runner.visualstudio package:

````ps
    >> Powershell 
    
    Install-Package xunit.runner.visualstudio
````

- Once the packages are installed, you can create a new test class in your project. Here's an example:

````csharp
    >> cSharp 

    using Xunit;

    namespace MyProject
    {
        public class MyTests
        {
            [Fact]
            public void TestMethod1()
            {
                // Arrange
                int a = 2;
                int b = 3;
                int expected = 5;

                // Act
                int actual = a + b;

                // Assert
                Assert.Equal(expected, actual);
            }
        }
    }
````


- To run your tests, you can use the "Test" menu in Rider. Select "Test" > "Windows" > "Test Explorer" to open the Test Explorer window. From there, you can select your tests and run them.
- That's it! You should now be able to use xUnit to write and run unit tests in your project.


