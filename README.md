# WeatherApi

**Tools/ Technologies:**

**Editor :** Visual Studio 2019 Community edition

**Language:** C# , Class Library Project with *Dot Net Core*

**BDD:** Specflow

**Test Framework:** NUnit 

**For Assertions:** Fluent Assertions , NUnit Assertions

**For API Automation :** Used *HTTP* Client


**Steps to Run the Tests:**

1)Clone the repo on your local.

2)Open the solution in Visual Studio 2019 (Community Edition is free and can be used).

3)Build the solution. There should not be any errors.

4)On the Visual Studio Menu go to Test ->Test Explorer.

5)You will see all the tests in the Test Explorer. Run them all.

**Reporting** - Even though Specflow tests are fairly detailed and gives you the information on failure, we can also have custom reports.

**Steps**:
1. Go to your project path and run the following command that will run the tests. It will create an xml file with Test results.
dotnet test -l:trx;LogFileName=C:\Reports\Results.xml

2. Now install Specflow.Exe on your local machine (it will already be there as you are using it ). Go to the path and run the following command to generate a html report.
specflow.exe nunitexecutionreport --ProjectFile C:\CodeChallenge\WeatherApi\WeatherApi\WeatherApi.csproj --xmlTestResult C:\Reports\Results.xml --OutputFile C:\Reports\Results.html

the tags --ProjectFile, --xmlTestResult and --OutputFile are self explanatory
