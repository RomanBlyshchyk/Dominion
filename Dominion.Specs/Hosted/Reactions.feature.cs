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
namespace Dominion.Specs.Hosted
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Reactions")]
    public partial class ReactionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Reactions.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Reactions", "In order to play the game to it\'s fullest potential\r\nAs a dominion player\r\nI want" +
                    " to be able to pull neat tricks with reactions", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Player uses Secret Chamber, draws a Moat, uses Moat, uses Secret Chamber again pu" +
            "tting both reactions back on top of the deck")]
        public virtual void PlayerUsesSecretChamberDrawsAMoatUsesMoatUsesSecretChamberAgainPuttingBothReactionsBackOnTopOfTheDeck()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player uses Secret Chamber, draws a Moat, uses Moat, uses Secret Chamber again pu" +
                    "tting both reactions back on top of the deck", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("A new hosted game with 3 players");
#line 8
testRunner.And("Player1 has a Militia in hand instead of a Copper");
#line 9
testRunner.And("Player2 has a hand of SecretChamber, Copper, Copper, Copper, Estate");
#line 10
testRunner.And("Player2 has a deck of Moat, Estate, Estate, Copper, Copper");
#line 11
testRunner.When("Player1 tells the host to play Militia");
#line 12
testRunner.And("Player2 tells the host to reveal SecretChamber");
#line 13
testRunner.And("Player2 tells the host to put Copper on top");
#line 14
testRunner.And("Player2 tells the host to put Copper on top");
#line 15
testRunner.And("Player2 tells the host to reveal Moat");
#line 16
testRunner.And("Player2 tells the host to reveal SecretChamber");
#line 17
testRunner.And("Player2 tells the host to put SecretChamber on top");
#line 18
testRunner.And("Player2 tells the host to put Moat on top");
#line 19
testRunner.Then("Player2 should have a hand of Copper, Estate, Estate, Copper, Copper");
#line 20
testRunner.And("Player2 should have a deck of: Moat, SecretChamber, Estate, Copper, Copper");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
