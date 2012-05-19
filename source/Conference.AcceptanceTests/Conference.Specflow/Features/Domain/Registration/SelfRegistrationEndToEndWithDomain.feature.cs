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
namespace Conference.Specflow.Features.Domain.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteWithDoaminCommandsAndEventsFeature : Xunit.IUseFixture<SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteWithDoaminCommandsAndEventsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SelfRegistrationEndToEndWithDomain.feature"
#line hidden
        
        public SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteWithDoaminCommandsAndEventsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Self Registrant end to end scenario for making a Registration for a Conference si" +
                    "te with Doamin Commands and Events", "In order to register for a conference\r\nAs an Attendee\r\nI want to be able to regis" +
                    "ter for the conference, pay for the Registration Order and associate myself with" +
                    " the paid Order automatically", ProgrammingLanguage.CSharp, new string[] {
                        "SelfRegistrationEndToEndWithDomain",
                        "NoWatiN"});
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
        
        public virtual void SetFixture(SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteWithDoaminCommandsAndEventsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te with Doamin Commands and Events")]
        [Xunit.TraitAttribute("Description", "Make a reservation with the selected Order Items")]
        public virtual void MakeAReservationWithTheSelectedOrderItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a reservation with the selected Order Items", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
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
#line 23
testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 28
testRunner.And("the selected Order Items", ((string)(null)), table2);
#line 32
testRunner.When("the Registrant proceed to make the Reservation");
#line 34
testRunner.Then("the command to register the selected Order Items is received");
#line 36
testRunner.And("the event for Order placed is emitted");
#line 38
testRunner.And("the command for reserving the selected Seats is received");
#line 40
testRunner.And("the event for reserving the selected Seats is emitted");
#line 42
testRunner.And("the command for marking the selected Seats as reserved is received");
#line 44
testRunner.And("the event for completing the Order reservation is emitted");
#line 46
testRunner.And("the event for calculating the total of $249 is emitted");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteWithDoaminCommandsAndEventsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteWithDoaminCommandsAndEventsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
