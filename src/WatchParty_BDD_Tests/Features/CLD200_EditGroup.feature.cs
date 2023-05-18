﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WatchParty_BDD_Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CLD200_EditGroup")]
    [NUnit.Framework.CategoryAttribute("Armando_Yanez")]
    [NUnit.Framework.CategoryAttribute("LoggedIn")]
    public partial class CLD200_EditGroupFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "Armando_Yanez",
                "LoggedIn"};
        
#line 1 "CLD200_EditGroup.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CLD200_EditGroup", @"**As a user, I would like to be able to modify my Watch Party Group so that I can add the link to the TeleParty link so that
others in the group can see it and join.**

This feature will allow the host of the watch party to make modifications to an already existing watch party group, it also
introduces a TeleParty URL field so that other users are able to join the watch party so that they can watch shows with
others in the group via the TeleParty thrid party extension.", ProgrammingLanguage.CSharp, new string[] {
                        "Armando_Yanez",
                        "LoggedIn"});
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
        
        public virtual void FeatureBackground()
        {
#line 12
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Email",
                        "FirstName",
                        "LastName",
                        "Password"});
            table8.AddRow(new string[] {
                        "TaliaK",
                        "knott@example.com",
                        "Talia",
                        "Knott",
                        "ScotIs#1"});
            table8.AddRow(new string[] {
                        "ZaydenC",
                        "clark@example.com",
                        "Zayden",
                        "Clark",
                        "ScotIs#1"});
            table8.AddRow(new string[] {
                        "DavilaH",
                        "hareem@example.com",
                        "Hareem",
                        "Davila",
                        "ScotIs#1"});
            table8.AddRow(new string[] {
                        "KrzysztofP",
                        "krzysztof@example.com",
                        "Krzysztof",
                        "Ponce",
                        "ScotIs#1"});
#line 13
 testRunner.Given("the following users exist", ((string)(null)), table8, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users can navigate to the edit page to make changes to their current watch party")]
        [NUnit.Framework.TestCaseAttribute("Talia", null)]
        [NUnit.Framework.TestCaseAttribute("Zayden", null)]
        [NUnit.Framework.TestCaseAttribute("Hareem", null)]
        [NUnit.Framework.TestCaseAttribute("Krzysztof", null)]
        public virtual void UsersCanNavigateToTheEditPageToMakeChangesToTheirCurrentWatchParty(string firstName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users can navigate to the edit page to make changes to their current watch party", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 20
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
#line 12
this.FeatureBackground();
#line hidden
#line 21
 testRunner.Given(string.Format("I am a user with first name \'{0}\'", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.When("I login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
  testRunner.And("I go to the details page of the newly created watch party", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
  testRunner.And("I click on the group options button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
  testRunner.And("I click on the edit group button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.Then("the page title contains \"Edit Group\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users can navigate to edit page that is not their own but are unable to make chan" +
            "ges")]
        [NUnit.Framework.TestCaseAttribute("Talia", null)]
        [NUnit.Framework.TestCaseAttribute("Zayden", null)]
        [NUnit.Framework.TestCaseAttribute("Hareem", null)]
        [NUnit.Framework.TestCaseAttribute("Krzysztof", null)]
        public virtual void UsersCanNavigateToEditPageThatIsNotTheirOwnButAreUnableToMakeChanges(string firstName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users can navigate to edit page that is not their own but are unable to make chan" +
                    "ges", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 34
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
#line 12
this.FeatureBackground();
#line hidden
#line 35
 testRunner.Given(string.Format("I am a user with first name \'{0}\'", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 36
 testRunner.When("I login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
  testRunner.And("I navigate to the \"EditExistingWatchParty\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then("I should see a header titled \"Only the host can make modifications to the Watch P" +
                        "arty Group\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users can navigate to the edit page, change all pre-existing inputs, update the w" +
            "atch party and verify that it\'s been updated from the details page")]
        [NUnit.Framework.TestCaseAttribute("Talia", null)]
        [NUnit.Framework.TestCaseAttribute("Zayden", null)]
        [NUnit.Framework.TestCaseAttribute("Hareem", null)]
        [NUnit.Framework.TestCaseAttribute("Krzysztof", null)]
        public virtual void UsersCanNavigateToTheEditPageChangeAllPre_ExistingInputsUpdateTheWatchPartyAndVerifyThatItsBeenUpdatedFromTheDetailsPage(string firstName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users can navigate to the edit page, change all pre-existing inputs, update the w" +
                    "atch party and verify that it\'s been updated from the details page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 46
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
#line 12
this.FeatureBackground();
#line hidden
#line 47
 testRunner.Given(string.Format("I am a user with first name \'{0}\'", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 48
 testRunner.When("I login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
  testRunner.And("I go to the details page of the newly created watch party", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
  testRunner.And("I click on the group options button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
  testRunner.And("I click on the edit group button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
  testRunner.And("I update the title to \"Movie marathon night\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
  testRunner.And("I update the description to \"All are welcome to join don\'t be shy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
  testRunner.And("I update the start date to \"02/08/2025\" and start time to \"10:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
  testRunner.And("I update the teleparty link to \"https://redirect.teleparty.com/join/3d63d7434826d" +
                        "1e8\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
  testRunner.And("I click on update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("I should be redirected to the details page with page title \"Group Details\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
  testRunner.And(@"I should see header ""Group Details"", group title ""Movie marathon night"", group description ""All are welcome to join don't be shy"", start date ""2/8/2025 10:00:00 AM"", and TeleParty URL ""https://redirect.teleparty.com/join/3d63d7434826d1e8"" have all been updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users can navigate to the edit page, leave the description empty, update the watc" +
            "h party and verify that it\'s been updated from the details page")]
        [NUnit.Framework.TestCaseAttribute("Talia", null)]
        [NUnit.Framework.TestCaseAttribute("Zayden", null)]
        [NUnit.Framework.TestCaseAttribute("Hareem", null)]
        [NUnit.Framework.TestCaseAttribute("Krzysztof", null)]
        public virtual void UsersCanNavigateToTheEditPageLeaveTheDescriptionEmptyUpdateTheWatchPartyAndVerifyThatItsBeenUpdatedFromTheDetailsPage(string firstName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users can navigate to the edit page, leave the description empty, update the watc" +
                    "h party and verify that it\'s been updated from the details page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 66
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
#line 12
this.FeatureBackground();
#line hidden
#line 67
 testRunner.Given(string.Format("I am a user with first name \'{0}\'", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 68
 testRunner.When("I login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
  testRunner.And("I go to the details page of the newly created watch party", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
  testRunner.And("I click on the group options button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
  testRunner.And("I click on the edit group button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
  testRunner.And("I update the title to \"Movie marathon night\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
  testRunner.And("I update the description to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
  testRunner.And("I update the start date to \"02/08/2025\" and start time to \"10:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
  testRunner.And("I update the teleparty link to \"https://redirect.teleparty.com/join/3d63d7434826d" +
                        "1e8\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
  testRunner.And("I click on update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.Then("I should be redirected to the details page with page title \"Group Details\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
  testRunner.And("I should see header \"Group Details\", group title \"Movie marathon night\", group de" +
                        "scription empty, start date \"2/8/2025 10:00:00 AM\", and TeleParty URL \"https://r" +
                        "edirect.teleparty.com/join/3d63d7434826d1e8\" have all been updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users can navigate to the edit page, leave the teleparty url empty, update the wa" +
            "tch party and verify that it\'s been updated from the details page")]
        [NUnit.Framework.TestCaseAttribute("Talia", null)]
        [NUnit.Framework.TestCaseAttribute("Zayden", null)]
        [NUnit.Framework.TestCaseAttribute("Hareem", null)]
        [NUnit.Framework.TestCaseAttribute("Krzysztof", null)]
        public virtual void UsersCanNavigateToTheEditPageLeaveTheTelepartyUrlEmptyUpdateTheWatchPartyAndVerifyThatItsBeenUpdatedFromTheDetailsPage(string firstName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users can navigate to the edit page, leave the teleparty url empty, update the wa" +
                    "tch party and verify that it\'s been updated from the details page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 86
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
#line 12
this.FeatureBackground();
#line hidden
#line 87
 testRunner.Given(string.Format("I am a user with first name \'{0}\'", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 88
 testRunner.When("I login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
  testRunner.And("I go to the details page of the newly created watch party", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
  testRunner.And("I click on the group options button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
  testRunner.And("I click on the edit group button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
  testRunner.And("I update the title to \"Movie marathon night\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
  testRunner.And("I update the description to \"All are welcome to join don\'t be shy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
  testRunner.And("I update the start date to \"02/08/2025\" and start time to \"10:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
  testRunner.And("I update the teleparty link to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
  testRunner.And("I click on update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.Then("I should be redirected to the details page with page title \"Group Details\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 98
  testRunner.And("I should see header \"Group Details\", group title \"Movie marathon night\", group de" +
                        "scription \"All are welcome to join don\'t be shy\", start date \"2/8/2025 10:00:00 " +
                        "AM\", and TeleParty URL \"N/A\" have all been updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users navigate to the edit page, update the title to null and on submission it do" +
            "es not let them update the group")]
        [NUnit.Framework.TestCaseAttribute("Talia", null)]
        [NUnit.Framework.TestCaseAttribute("Zayden", null)]
        [NUnit.Framework.TestCaseAttribute("Hareem", null)]
        [NUnit.Framework.TestCaseAttribute("Krzysztof", null)]
        public virtual void UsersNavigateToTheEditPageUpdateTheTitleToNullAndOnSubmissionItDoesNotLetThemUpdateTheGroup(string firstName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users navigate to the edit page, update the title to null and on submission it do" +
                    "es not let them update the group", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 106
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
#line 12
this.FeatureBackground();
#line hidden
#line 107
 testRunner.Given(string.Format("I am a user with first name \'{0}\'", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 108
 testRunner.When("I login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
  testRunner.And("I go to the details page of the newly created watch party", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
  testRunner.And("I click on the group options button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
  testRunner.And("I click on the edit group button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
  testRunner.And("I update the title to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
  testRunner.And("I update the description to \"All are welcome to join don\'t be shy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
  testRunner.And("I update the start date to \"02/08/2025\" and start time to \"10:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
  testRunner.And("I update the teleparty link to \"https://redirect.teleparty.com/join/3d63d7434826d" +
                        "1e8\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
  testRunner.And("I click on update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.Then("I should receive an error message stating Title is a required field on the edit p" +
                        "age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users navigate to the edit page, update the teleparty url to an invalid link and " +
            "on submission it does not let them update the group")]
        [NUnit.Framework.TestCaseAttribute("Talia", null)]
        [NUnit.Framework.TestCaseAttribute("Zayden", null)]
        [NUnit.Framework.TestCaseAttribute("Hareem", null)]
        [NUnit.Framework.TestCaseAttribute("Krzysztof", null)]
        public virtual void UsersNavigateToTheEditPageUpdateTheTelepartyUrlToAnInvalidLinkAndOnSubmissionItDoesNotLetThemUpdateTheGroup(string firstName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users navigate to the edit page, update the teleparty url to an invalid link and " +
                    "on submission it does not let them update the group", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 125
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
#line 12
this.FeatureBackground();
#line hidden
#line 126
 testRunner.Given(string.Format("I am a user with first name \'{0}\'", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 127
 testRunner.When("I login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 128
  testRunner.And("I go to the details page of the newly created watch party", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
  testRunner.And("I click on the group options button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
  testRunner.And("I click on the edit group button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 131
  testRunner.And("I update the title to \"Movie marathon night\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
  testRunner.And("I update the description to \"All are welcome to join don\'t be shy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 133
  testRunner.And("I update the start date to \"02/08/2025\" and start time to \"10:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 134
  testRunner.And("I update the teleparty link to \"https://shorturl.at/zKLV1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 135
  testRunner.And("I click on update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 136
 testRunner.Then("I should receive an error message telling me to enter the url in the correct form" +
                        "at on the edit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users navigate to the edit page, update the teleparty url to link missing informa" +
            "tion at the end of the link and on submission it does not let them update the gr" +
            "oup")]
        [NUnit.Framework.TestCaseAttribute("Talia", null)]
        [NUnit.Framework.TestCaseAttribute("Zayden", null)]
        [NUnit.Framework.TestCaseAttribute("Hareem", null)]
        [NUnit.Framework.TestCaseAttribute("Krzysztof", null)]
        public virtual void UsersNavigateToTheEditPageUpdateTheTelepartyUrlToLinkMissingInformationAtTheEndOfTheLinkAndOnSubmissionItDoesNotLetThemUpdateTheGroup(string firstName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FirstName", firstName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users navigate to the edit page, update the teleparty url to link missing informa" +
                    "tion at the end of the link and on submission it does not let them update the gr" +
                    "oup", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 144
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
#line 12
this.FeatureBackground();
#line hidden
#line 145
 testRunner.Given(string.Format("I am a user with first name \'{0}\'", firstName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 146
 testRunner.When("I login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 147
  testRunner.And("I go to the details page of the newly created watch party", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 148
  testRunner.And("I click on the group options button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 149
  testRunner.And("I click on the edit group button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 150
  testRunner.And("I update the title to \"Movie marathon night\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 151
  testRunner.And("I update the description to \"All are welcome to join don\'t be shy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 152
  testRunner.And("I update the start date to \"02/08/2025\" and start time to \"10:00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 153
  testRunner.And("I update the teleparty link to \"https://redirect.teleparty.com/join/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 154
  testRunner.And("I click on update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 155
 testRunner.Then("I should receive an error message telling me to enter the url in the correct form" +
                        "at on the edit page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
