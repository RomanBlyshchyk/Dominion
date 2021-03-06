// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
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
    [NUnit.Framework.DescriptionAttribute("Apothecary")]
    public partial class ApothecaryFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Apothecary.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Apothecary", "", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Play Apothecary with all potions and coppers on top")]
        public virtual void PlayApothecaryWithAllPotionsAndCoppersOnTop()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play Apothecary with all potions and coppers on top", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has an Apothecary in hand instead of a Copper");
#line 6
testRunner.And("Player1 has a deck of Estate, Copper, Potion, Copper, Copper");
#line 7
testRunner.When("Player1 plays an Apothecary");
#line 8
testRunner.Then("All actions should be resolved");
#line 9
testRunner.And("Player1 should have 9 cards in hand");
#line 10
testRunner.And("Player1 should have 1 action remaining");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Play Apothecary with no potions or coppers on top")]
        public virtual void PlayApothecaryWithNoPotionsOrCoppersOnTop()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Play Apothecary with no potions or coppers on top", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
testRunner.Given("A new game with 3 players");
#line 14
testRunner.And("Player1 has an Apothecary in hand instead of a Copper");
#line 15
testRunner.And("Player1 has a deck of Copper, Estate, Curse, Silver, Gold");
#line 16
testRunner.When("Player1 plays an Apothecary");
#line 17
testRunner.Then("Player1 must select a revealed card from: Estate, Curse, Silver, Gold");
#line 18
testRunner.When("Player1 selects Estate from the revealed cards");
#line 19
testRunner.Then("Player1 must select a revealed card from: Curse, Silver, Gold");
#line 20
testRunner.When("Player1 selects Silver from the revealed cards");
#line 21
testRunner.Then("Player1 must select a revealed card from: Curse, Gold");
#line 22
testRunner.When("Player1 selects Curse from the revealed cards");
#line 23
testRunner.Then("Player1 should have a deck of: Gold, Curse, Silver, Estate");
#line 24
testRunner.And("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Apothecary is played with no other cards in hand, no discards and no deck")]
        public virtual void ApothecaryIsPlayedWithNoOtherCardsInHandNoDiscardsAndNoDeck()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Apothecary is played with no other cards in hand, no discards and no deck", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
testRunner.Given("A new game with 3 players");
#line 28
testRunner.And("Player1 has a hand of Apothecary");
#line 29
testRunner.And("Player1 has an empty deck");
#line 30
testRunner.When("Player1 plays a Apothecary");
#line 31
testRunner.Then("Player1 should have 0 cards in hand");
#line 32
testRunner.And("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
