﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Variants.NUnitProvider.IntegrationTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NUnitDemoFeatureTests")]
    [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
    [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
    public partial class NUnitDemoFeatureTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NUnitDemoFeatureTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NUnitDemoFeatureTests", "\tIn order to verify the SpecFlow variants plugin for features\r\n\tAs a developer\r\n\t" +
                    "I want to be able to run integration tests to validate the plugin", ProgrammingLanguage.CSharp, new string[] {
                        "Browser:Chrome",
                        "Browser:Firefox"});
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
        public virtual void ScenarioTearDown()
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
#line 8
#line 9
 testRunner.Given("I am on the Google home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A single test without examples or tags: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        public virtual void ASingleTestWithoutExamplesOrTags_Chrome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A single test without examples or tags", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 12
 testRunner.When("I search for \'totaltest github\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("the following result should be listed:", "TotalTest (Prab) · GitHub", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A single test without examples or tags: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        public virtual void ASingleTestWithoutExamplesOrTags_Firefox()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A single test without examples or tags", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 12
 testRunner.When("I search for \'totaltest github\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("the following result should be listed:", "TotalTest (Prab) · GitHub", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A test with non-variant tags: Chrome")]
        [NUnit.Framework.CategoryAttribute("Browser:Chrome")]
        [NUnit.Framework.CategoryAttribute("Settings")]
        [NUnit.Framework.CategoryAttribute("Tools")]
        public virtual void ATestWithNon_VariantTags_Chrome()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with non-variant tags", null, new string[] {
                        "Settings",
                        "Tools"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 21
 testRunner.When("I search for \'totaltest github\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("there should be links to the tags specified", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A test with non-variant tags: Firefox")]
        [NUnit.Framework.CategoryAttribute("Browser:Firefox")]
        [NUnit.Framework.CategoryAttribute("Settings")]
        [NUnit.Framework.CategoryAttribute("Tools")]
        public virtual void ATestWithNon_VariantTags_Firefox()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with non-variant tags", null, new string[] {
                        "Settings",
                        "Tools"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 21
 testRunner.When("I search for \'totaltest github\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("there should be links to the tags specified", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestCaseAttribute("totaltest.github.io", "https://github.com/TotalTest/totaltest.github.io", "Chrome", null, Category="Browser:Chrome", TestName="ATestWithVariantTagsAndExamples with Chrome and \"totaltest_github_io\", \"https://g" +
            "ithub_com/TotalTest/totaltest_github_io\"")]
        [NUnit.Framework.TestCaseAttribute("totaltest.github.io", "https://github.com/TotalTest/totaltest.github.io", "Firefox", null, Category="Browser:Firefox", TestName="ATestWithVariantTagsAndExamples with Firefox and \"totaltest_github_io\", \"https://" +
            "github_com/TotalTest/totaltest_github_io\"")]
        [NUnit.Framework.TestCaseAttribute("SpecFlow.Variants", "https://github.com/TotalTest/SpecFlow.Variants", "Chrome", null, Category="Browser:Chrome", TestName="ATestWithVariantTagsAndExamples with Chrome and \"SpecFlow_Variants\", \"https://git" +
            "hub_com/TotalTest/SpecFlow_Variants\"")]
        [NUnit.Framework.TestCaseAttribute("SpecFlow.Variants", "https://github.com/TotalTest/SpecFlow.Variants", "Firefox", null, Category="Browser:Firefox", TestName="ATestWithVariantTagsAndExamples with Firefox and \"SpecFlow_Variants\", \"https://gi" +
            "thub_com/TotalTest/SpecFlow_Variants\"")]
        public virtual void ATestWithVariantTagsAndExamples(string repo, string site, string browser, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A test with variant tags and examples", null, exampleTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 25
 testRunner.And("I navigate to the \'TotalTest\' Github page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When(string.Format("I drill into the \'{0}\' repository", repo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then(string.Format("I should be on the website \'{0}\'", site), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

