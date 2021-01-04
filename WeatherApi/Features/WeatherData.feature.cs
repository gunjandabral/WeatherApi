﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WeatherApi.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("WeatherData")]
    public partial class WeatherDataFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "WeatherData.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "WeatherData", "Following Scenarios get the weather data based on Latitude-Longitude and PostCode" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Weather Data based for a non-authenticated user")]
        [NUnit.Framework.TestCaseAttribute("Sydney", "-33.86", "151.21", null)]
        public virtual void WeatherDataBasedForANon_AuthenticatedUser(string comments, string latitude, string longitude, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Comments", comments);
            argumentsOfScenario.Add("Latitude", latitude);
            argumentsOfScenario.Add("Longitude", longitude);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Weather Data based for a non-authenticated user", null, tagsOfScenario, argumentsOfScenario);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
testRunner.Given("I am a user who wants to get the weather details using < PostalCode > and < Count" +
                        "ryCode >", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
testRunner.When("I look up the weather forecast as a non-authenticated user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 7
testRunner.Then("the Api response code should be \'Forbidden\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Weather Data based on Latitudes and Longitudes")]
        [NUnit.Framework.TestCaseAttribute("Sydney", "-33.86", "151.21", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("Tokyo", "35.65", "139.74", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("Sydney", "", "151.21", "BadRequest", null)]
        [NUnit.Framework.TestCaseAttribute("Sydney", "-33.86", "", "BadRequest", null)]
        [NUnit.Framework.TestCaseAttribute("Sydney", "", "", "BadRequest", null)]
        public virtual void WeatherDataBasedOnLatitudesAndLongitudes(string comments, string latitude, string longitude, string expectedResponse, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Comments", comments);
            argumentsOfScenario.Add("Latitude", latitude);
            argumentsOfScenario.Add("Longitude", longitude);
            argumentsOfScenario.Add("ExpectedResponse", expectedResponse);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Weather Data based on Latitudes and Longitudes", null, tagsOfScenario, argumentsOfScenario);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
testRunner.Given(string.Format("I am a user who wants to get the weather details based on its {0} and {1}", latitude, longitude), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
testRunner.When("I look up the weather forecast as an authenticated user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
testRunner.Then(string.Format("the Api response code should be \'{0}\'", expectedResponse), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comments",
                            "clouds",
                            "snow",
                            "precip",
                            "sunrise",
                            "sunset",
                            "date_time",
                            "temp"});
                table1.AddRow(new string[] {
                            "All parameters are approximations. Values in this tble are not utilized but can b" +
                                "e used with small change",
                            "0",
                            "0",
                            "0",
                            "",
                            "",
                            "0",
                            "0"});
#line 17
testRunner.And("I receive the weather forecast with the following parameters", ((string)(null)), table1, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Weather Data based on PostCode")]
        [NUnit.Framework.TestCaseAttribute("Only Postal Code", "2000", "", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("Postal Code and correct Country Code", "2000", "AU", "OK", null)]
        [NUnit.Framework.TestCaseAttribute("Postal Code and wrong Country Code. There is a potential bug here", "2000", "JP", "NoContent", null)]
        [NUnit.Framework.TestCaseAttribute("Neither a Post Code nor a Country Code", "", "", "BadRequest", null)]
        public virtual void WeatherDataBasedOnPostCode(string comments, string postalCode, string countryCode, string expectedResponse, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Comments", comments);
            argumentsOfScenario.Add("PostalCode", postalCode);
            argumentsOfScenario.Add("CountryCode", countryCode);
            argumentsOfScenario.Add("ExpectedResponse", expectedResponse);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Weather Data based on PostCode", null, tagsOfScenario, argumentsOfScenario);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 31
testRunner.Given(string.Format("I am a user who wants to get the weather details using {0} and {1}", postalCode, countryCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
testRunner.When("I look up the weather forecast as an authenticated user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
testRunner.Then(string.Format("the Api response code should be \'{0}\'", expectedResponse), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Comments",
                            "clouds",
                            "snow"});
                table2.AddRow(new string[] {
                            "All parameters are approximations. Values in this tble are not utilized but can b" +
                                "e used with small change",
                            "0",
                            "0"});
#line 34
testRunner.And("I receive the weather forecast with the following parameters", ((string)(null)), table2, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
