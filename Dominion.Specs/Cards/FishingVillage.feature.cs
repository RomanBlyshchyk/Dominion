// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:2.0.50727.4952
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs.Cards
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FishingVillage")]
    public partial class FishingVillageFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FishingVillage.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FishingVillage", "", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Fishing Village Initial Effect")]
        public virtual void FishingVillageInitialEffect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fishing Village Initial Effect", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 2 players");
#line 5
testRunner.And("Player1 has a FishingVillage in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a FishingVillage");
#line 7
testRunner.Then("Player1 should have 2 remaining action");
#line 8
testRunner.And("Player1 should have 1 to spend");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Fishing Village Second Effect")]
        public virtual void FishingVillageSecondEffect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fishing Village Second Effect", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given("A new game with 2 players");
#line 12
testRunner.And("Player1 has a FishingVillage in hand instead of a Copper");
#line 13
testRunner.When("Player1 plays a FishingVillage");
#line 14
testRunner.And("Player1 ends their turn");
#line 15
testRunner.And("Player2 ends their turn");
#line 16
testRunner.Then("Player1 is the active player");
#line 17
testRunner.And("Player1 should have 2 remaining action");
#line 18
testRunner.And("Player1 should have 1 to spend");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Fishing Village is not Discarded Immediately")]
        public virtual void FishingVillageIsNotDiscardedImmediately()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fishing Village is not Discarded Immediately", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
testRunner.Given("A new game with 2 players");
#line 22
testRunner.And("Player1 has a FishingVillage in hand instead of a Copper");
#line 23
testRunner.When("Player1 plays a FishingVillage");
#line 24
testRunner.And("Player1 ends their turn");
#line 25
testRunner.Then("Player1 should have 4 cards in the discard pile");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Fishing Village is Discarded After Second Turn")]
        public virtual void FishingVillageIsDiscardedAfterSecondTurn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fishing Village is Discarded After Second Turn", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
testRunner.Given("A new game with 2 players");
#line 29
testRunner.And("Player1 has a FishingVillage in hand instead of a Copper");
#line 30
testRunner.When("Player1 plays a FishingVillage");
#line 31
testRunner.And("Player1 ends their turn");
#line 32
testRunner.And("Player2 ends their turn");
#line 33
testRunner.And("Player1 ends their turn");
#line 34
testRunner.Then("Player1 should have 0 cards in the discard pile");
#line 35
testRunner.And("Player1 should have a deck of 5 cards");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Fishing Village Has No Effect After Two Turns")]
        public virtual void FishingVillageHasNoEffectAfterTwoTurns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fishing Village Has No Effect After Two Turns", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
testRunner.Given("A new game with 2 players");
#line 39
testRunner.And("Player1 has a FishingVillage in hand instead of a Copper");
#line 40
testRunner.When("Player1 plays a FishingVillage");
#line 41
testRunner.And("Player1 ends their turn");
#line 42
testRunner.And("Player2 ends their turn");
#line 43
testRunner.And("Player1 ends their turn");
#line 44
testRunner.And("Player2 ends their turn");
#line 45
testRunner.Then("Player1 is the active player");
#line 46
testRunner.And("Player1 should have 1 remaining action");
#line 47
testRunner.And("Player1 should have 0 to spend");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion