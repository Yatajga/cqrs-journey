﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.UserInterface.Views.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceHappyPathFeature : Xunit.IUseFixture<RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceHappyPathFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroupRegistrationEndToEndHappy.feature"
#line hidden
        
        public RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceHappyPathFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registrant workflow for registering a group of Attendees for a conference (happy " +
                    "path)", "In order to register for conference a group of Attendees\r\nAs a Registrant\r\nI want" +
                    " to be able to select Order Items from one or many available Order Items and mak" +
                    "e a Reservation", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 20
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "100"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "100"});
#line 21
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "3"});
            table2.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 26
 testRunner.And("the selected Order Items", ((string)(null)), table2);
#line hidden
        }
        
        public virtual void SetFixture(RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceHappyPathFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (happy " +
            "path)")]
        [Xunit.TraitAttribute("Description", "All the Order Items are available and all get selected, then all get reserved")]
        public virtual void AllTheOrderItemsAreAvailableAndAllGetSelectedThenAllGetReserved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are available and all get selected, then all get reserved", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line 36
 testRunner.When("the Registrant proceed to make the Reservation");
#line 37
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "General admission",
                        "3"});
            table3.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table3.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 38
 testRunner.And("these Order Items should be reserved", ((string)(null)), table3);
#line 43
 testRunner.And("the total should read $1197");
#line 44
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (happy " +
            "path)")]
        [Xunit.TraitAttribute("Description", "Checkout:Registrant Details")]
        public virtual void CheckoutRegistrantDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Registrant Details", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line 47
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table4.AddRow(new string[] {
                        "William",
                        "Weber",
                        "William@Weber.com"});
#line 48
 testRunner.And("the Registrant enter these details", ((string)(null)), table4);
#line 51
 testRunner.When("the Registrant proceed to Checkout:Payment");
#line 52
 testRunner.Then("the payment options should be offered for a total of $1197");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (happy " +
            "path)")]
        [Xunit.TraitAttribute("Description", "Checkout:Payment and sucessfull Order completed")]
        public virtual void CheckoutPaymentAndSucessfullOrderCompleted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Payment and sucessfull Order completed", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line 55
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table5.AddRow(new string[] {
                        "William",
                        "Weber",
                        "William@Weber.com"});
#line 56
 testRunner.And("the Registrant enter these details", ((string)(null)), table5);
#line 59
 testRunner.And("the Registrant proceed to Checkout:Payment");
#line 60
 testRunner.When("the Registrant proceed to confirm the payment");
#line 61
    testRunner.Then("the Registration process was successful");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table6.AddRow(new string[] {
                        "General admission",
                        "3"});
            table6.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table6.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 62
 testRunner.And("the Order should be created with the following Order Items", ((string)(null)), table6);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (happy " +
            "path)")]
        [Xunit.TraitAttribute("Description", "Allocate all purchased Seats")]
        public virtual void AllocateAllPurchasedSeats()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allocate all purchased Seats", ((string[])(null)));
#line 69
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line 70
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table7.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 71
 testRunner.And("the Registrant enter these details", ((string)(null)), table7);
#line 74
 testRunner.And("the Registrant proceed to Checkout:Payment");
#line 75
 testRunner.And("the Registrant proceed to confirm the payment");
#line 76
    testRunner.And("the Registration process was successful");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table8.AddRow(new string[] {
                        "General admission",
                        "3"});
            table8.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table8.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 77
 testRunner.And("the Order should be created with the following Order Items", ((string)(null)), table8);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "first name",
                        "last name",
                        "email address"});
            table9.AddRow(new string[] {
                        "General admission",
                        "William",
                        "Weber",
                        "William@Weber.com"});
            table9.AddRow(new string[] {
                        "General admission",
                        "Gregory",
                        "Doe",
                        "GregoryDoe@live.com"});
            table9.AddRow(new string[] {
                        "General admission",
                        "Oliver",
                        "Weber",
                        "Oliver@Weber.com"});
            table9.AddRow(new string[] {
                        "CQRS Workshop",
                        "Tim",
                        "Martin",
                        "Tim@Martin.com"});
            table9.AddRow(new string[] {
                        "Additional cocktail party",
                        "Mani",
                        "Kris",
                        "Mani@Kris.com"});
            table9.AddRow(new string[] {
                        "Additional cocktail party",
                        "Jim",
                        "Gregory",
                        "Jim@Gregory.com"});
#line 82
 testRunner.When("the Registrant assign these seats", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table10.AddRow(new string[] {
                        "General admission",
                        "3"});
            table10.AddRow(new string[] {
                        "CQRS Workshop",
                        "1"});
            table10.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 90
 testRunner.Then("these seats are assigned", ((string)(null)), table10);
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceHappyPathFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceHappyPathFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
