# WeatherApi

**Tools/ Technologies:**

**Editor :** Visual Studio 2019 Community edition

**Language:** C# , Took Specflow Project with Specflow+Runner inbuilt

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
Since I am using Specflow Runner, there is no need for any custom code/ manual step to generate a report. An HTML report will be automaticlly generated on each test run in the Test Results folder. A sample report has been enclosed alongside this code. Please check the reportnamed - **CodeChallenge__2021-01-04T174348.html** under WeatherApi/SpecFlowProject3/.

**Note** : When you download the code and run it , you can see the reports for each of your sucessive runs in ../WeatherApi/TestResults folder. 
