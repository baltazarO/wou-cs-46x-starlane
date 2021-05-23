﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace iCollections.BDDTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateCollectionBetter")]
    public partial class CreateCollectionBetterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CreateCollectionBetter.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CreateCollectionBetter", @"	Creating A Collection 

	Derek Russell
	User Story ID: 177895357, Sprint 6, 2 Points.
		The Original Form of Acceptance Criteria that is being sought after in BDD testing:
			* As a user of this site that is creating an icollection I would like to select exisiting Keywords(Tags) to attach to the collection when I publish it.
			* As a user of this site that is creating an icollection I would like to create new Keywords(Tags) to attach to the collection when I publish it.
	

Going through the process from logging in,  to publishing a newly made iCollection. ", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 13
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Email",
                        "FirstName",
                        "LastName",
                        "Password"});
            table3.AddRow(new string[] {
                        "TaliaK",
                        "knott@example.com",
                        "Talia",
                        "Knott",
                        "Abcd987?6"});
            table3.AddRow(new string[] {
                        "ZaydenC",
                        "clark@example.com",
                        "Zayden",
                        "Clark",
                        "Abcd987?6"});
            table3.AddRow(new string[] {
                        "DavilaH",
                        "hareem@example.com",
                        "Hareem",
                        "Davila",
                        "Abcd987?6"});
            table3.AddRow(new string[] {
                        "KrzysztofP",
                        "krzysztof@example.com",
                        "Krzysztof",
                        "Ponce",
                        "Abcd987?6"});
#line 14
 testRunner.Given("the following users exist", ((string)(null)), table3, "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Being a logged in User I can click the nav bar links")]
        [NUnit.Framework.TestCaseAttribute("create_collection", "EnvironmentSelection", null)]
        public virtual void BeingALoggedInUserICanClickTheNavBarLinks(string selectedButton, string page, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("SelectedButton", selectedButton);
            argumentsOfScenario.Add("Page", page);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Being a logged in User I can click the nav bar links", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 22
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
#line 13
this.FeatureBackground();
#line hidden
#line 23
 testRunner.Given("I am a User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 24
 testRunner.When("I am a logged in user on the HomePage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
   testRunner.And(string.Format("I Click the \'{0}\' Dropdown button", selectedButton), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.Then(string.Format("I am redirected to the \'{0}\' page", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creating a new collection, User doesnt selecte an environment and hits continue b" +
            "ut the page is refreshed.")]
        public virtual void CreatingANewCollectionUserDoesntSelecteAnEnvironmentAndHitsContinueButThePageIsRefreshed_()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a new collection, User doesnt selecte an environment and hits continue b" +
                    "ut the page is refreshed.", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 32
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
#line 13
this.FeatureBackground();
#line hidden
#line 33
 testRunner.Given("I am a User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
   testRunner.And("I am a logged in user on the HomePage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
   testRunner.And("I am on the \'EnvironmentSelection\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
   testRunner.When("I Click the \'continue_on\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("I am redirected to the \'EnvironmentSelection\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creating a new collection, User can select an environment and continue to photo s" +
            "election")]
        [NUnit.Framework.TestCaseAttribute("ocean_environment", "PhotoSelection", null)]
        [NUnit.Framework.TestCaseAttribute("gallery_environment", "PhotoSelection", null)]
        [NUnit.Framework.TestCaseAttribute("null", "EnvironmentSelection", null)]
        public virtual void CreatingANewCollectionUserCanSelectAnEnvironmentAndContinueToPhotoSelection(string selectedCheckbox, string page, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("selectedCheckbox", selectedCheckbox);
            argumentsOfScenario.Add("Page", page);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating a new collection, User can select an environment and continue to photo s" +
                    "election", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 40
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
#line 13
this.FeatureBackground();
#line hidden
#line 41
 testRunner.Given("I am a User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 42
   testRunner.And("I am a logged in user on the HomePage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
   testRunner.And("I am on the \'EnvironmentSelection\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
   testRunner.And(string.Format("I select the \'{0}\' checkbox", selectedCheckbox), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
   testRunner.When("I Click the \'continue_on\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.Then(string.Format("I am redirected to the \'{0}\' page", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A Logged In User can view all the public seeded gallery iCollections")]
        [NUnit.Framework.TestCaseAttribute("2", "The only Cards I got left", "Card Gallery", null)]
        [NUnit.Framework.TestCaseAttribute("3", "This is the dog toy gallery description section area that ha", "Dog Toy Gallery", null)]
        [NUnit.Framework.TestCaseAttribute("5", "The fish in the gallery", "Fish Gallery", null)]
        [NUnit.Framework.TestCaseAttribute("7", "All the covid puzzels", "Puzzel Gallery", null)]
        [NUnit.Framework.TestCaseAttribute("9", "Some of my most used tools", "Tool Gallery", null)]
        [NUnit.Framework.TestCaseAttribute("11", "toys", "FLUFFYS FRIENDS", null)]
        [NUnit.Framework.TestCaseAttribute("13", "blah", "8 puzzel gallery", null)]
        [NUnit.Framework.TestCaseAttribute("15", "last one", "plyer screwdriver gallery", null)]
        public virtual void ALoggedInUserCanViewAllThePublicSeededGalleryICollections(string collectionId, string collectionDescription, string collectionTitle, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CollectionId", collectionId);
            argumentsOfScenario.Add("CollectionDescription", collectionDescription);
            argumentsOfScenario.Add("CollectionTitle", collectionTitle);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A Logged In User can view all the public seeded gallery iCollections", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 54
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
#line 13
this.FeatureBackground();
#line hidden
#line 55
 testRunner.Given("I am a User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 56
   testRunner.And("I am a logged in user on the HomePage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
   testRunner.When(string.Format("I view the gallery iCollection with \'{0}\' as the Id", collectionId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 58
 testRunner.Then(string.Format("I can view the \'{0}\' title on the page", collectionTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.And(string.Format("I can view the \'{0}\' description on the page", collectionDescription), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A Logged In User can view all the public seeded ocean iCollections")]
        [NUnit.Framework.TestCaseAttribute("1", "Royal Caribbean", "Royal Ocean", null)]
        [NUnit.Framework.TestCaseAttribute("4", "THIS IS THE DESCRIPTION ICEBERG", "Toys Overboard", null)]
        [NUnit.Framework.TestCaseAttribute("6", "How did he get there", "How did I get Here Ocean", null)]
        [NUnit.Framework.TestCaseAttribute("8", "The puzzels that have ocean in them or water", "Water Puzzels in Ocean", null)]
        [NUnit.Framework.TestCaseAttribute("10", "oh noes the rust is coming", "sea saws and clam clamps", null)]
        [NUnit.Framework.TestCaseAttribute("12", "baths", "Bath Time Buddies", null)]
        [NUnit.Framework.TestCaseAttribute("14", "tired", "puzzel ocean", null)]
        [NUnit.Framework.TestCaseAttribute("16", "get it", "ocean with the allens and phil", null)]
        public virtual void ALoggedInUserCanViewAllThePublicSeededOceanICollections(string collectionId, string collectionDescription, string collectionTitle, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CollectionId", collectionId);
            argumentsOfScenario.Add("CollectionDescription", collectionDescription);
            argumentsOfScenario.Add("CollectionTitle", collectionTitle);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A Logged In User can view all the public seeded ocean iCollections", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 71
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
#line 13
this.FeatureBackground();
#line hidden
#line 72
 testRunner.Given("I am a User", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 73
   testRunner.And("I am a logged in user on the HomePage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
   testRunner.When(string.Format("I view the ocean iCollection with \'{0}\' as the Id", collectionId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.Then(string.Format("I can view the \'{0}\' title on the page", collectionTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
 testRunner.And(string.Format("I can view the \'{0}\' description on the page", collectionDescription), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
