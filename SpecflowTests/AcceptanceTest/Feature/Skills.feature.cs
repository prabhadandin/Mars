﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecflowTests.AcceptanceTest.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SkillsTabFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Skills.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Skills Tab", "\t  As a Skill Trader\r\n      I want to be able to Add,update,delete skills \r\n     " +
                    " In order to update my profile details", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Skills Tab")))
            {
                global::SpecflowTests.AcceptanceTest.Feature.SkillsTabFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AddSkill(string skillname, string skillLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "automation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Skill", @__tags);
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When(string.Format("I add new skill\'{0}\', \'{1}\'", skillname, skillLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("i should see the skill \'{0}\'displayed on my listings", skillname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Skill: Java")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Java")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Skillname", "Java")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SkillLevel", "Beginner")]
        public virtual void AddSkill_Java()
        {
#line 8
this.AddSkill("Java", "Beginner", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Skill: Csharp")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Csharp")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Skillname", "Csharp")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SkillLevel", "Expert")]
        public virtual void AddSkill_Csharp()
        {
#line 8
this.AddSkill("Csharp", "Expert", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Skill: C++")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "C++")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Skillname", "C++")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SkillLevel", "Expert")]
        public virtual void AddSkill_C()
        {
#line 8
this.AddSkill("C++", "Expert", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Skill: Python")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Python")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Skillname", "Python")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:SkillLevel", "Expert")]
        public virtual void AddSkill_Python()
        {
#line 8
this.AddSkill("Python", "Expert", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddExistingSkillFromList(string errorMessage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add existing Skill from list", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When("I add existing skill from list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then(string.Format("i should see the\'{0}\'displayed on my listings", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add existing Skill from list: This Skill Already exists in your skill list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "This Skill Already exists in your skill list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ErrorMessage", "This Skill Already exists in your skill list")]
        public virtual void AddExistingSkillFromList_ThisSkillAlreadyExistsInYourSkillList()
        {
#line 19
this.AddExistingSkillFromList("This Skill Already exists in your skill list", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddExistingSkillFromListWithDifferentSkillLevel(string errorMessage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add existing Skill from list with different SkillLevel", exampleTags);
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.When("I add existing skill from list with different SkillLevel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then(string.Format("i should see the\'{0}\'displayed on my listings", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add existing Skill from list with different SkillLevel: This Skill Already exists" +
            " in your skill list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "This Skill Already exists in your skill list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ErrorMessage", "This Skill Already exists in your skill list")]
        public virtual void AddExistingSkillFromListWithDifferentSkillLevel_ThisSkillAlreadyExistsInYourSkillList()
        {
#line 27
this.AddExistingSkillFromListWithDifferentSkillLevel("This Skill Already exists in your skill list", ((string[])(null)));
#line hidden
        }
        
        public virtual void AddSkillWithoutMandatoryDetails(string errorMessage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Skill without Mandatory details", exampleTags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.When("I dont provide skill Mandatory details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then(string.Format("i should see \'{0}\'displayed on screen", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Skill without Mandatory details: Please Enter Skill and SkillLevel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Please Enter Skill and SkillLevel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ErrorMessage", "Please Enter Skill and SkillLevel")]
        public virtual void AddSkillWithoutMandatoryDetails_PleaseEnterSkillAndSkillLevel()
        {
#line 36
this.AddSkillWithoutMandatoryDetails("Please Enter Skill and SkillLevel", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update Skill")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automation")]
        public virtual void UpdateSkill()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Skill", new string[] {
                        "automation"});
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
 testRunner.When("I update skill", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("i should see updated skill displayed on my listings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void UpdateWithExistingSkillFromList(string errorMessage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update with existing Skill from list", exampleTags);
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.When("I update with existing skill  from list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then(string.Format("i should see the\'{0}\'displayed on my listings", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update with existing Skill from list: This Skill Already exists in your skill lis" +
            "t")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "This Skill Already exists in your skill list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ErrorMessage", "This Skill Already exists in your skill list")]
        public virtual void UpdateWithExistingSkillFromList_ThisSkillAlreadyExistsInYourSkillList()
        {
#line 50
this.UpdateWithExistingSkillFromList("This Skill Already exists in your skill list", ((string[])(null)));
#line hidden
        }
        
        public virtual void UpdateWithExistingSkillFromListWithDifferentSkillLevel(string errorMessage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update with existing Skill from list with different SkillLevel", exampleTags);
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
 testRunner.When("I update with existing skill from list with different SkillLevel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then(string.Format("i should see the\'{0}\'displayed on my listings", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update with existing Skill from list with different SkillLevel: This Skill Alread" +
            "y exists in your skill list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "This Skill Already exists in your skill list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ErrorMessage", "This Skill Already exists in your skill list")]
        public virtual void UpdateWithExistingSkillFromListWithDifferentSkillLevel_ThisSkillAlreadyExistsInYourSkillList()
        {
#line 58
this.UpdateWithExistingSkillFromListWithDifferentSkillLevel("This Skill Already exists in your skill list", ((string[])(null)));
#line hidden
        }
        
        public virtual void UpdateSkillWithoutMandatoryDetails(string errorMessage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Skill without Mandatory details", exampleTags);
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.When("I dont provide skill  Mandatory details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then(string.Format("i should see \'{0}\'displayed on screen", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update Skill without Mandatory details: Please Enter Skill and SkillLevel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Please Enter Skill and SkillLevel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ErrorMessage", "Please Enter Skill and SkillLevel")]
        public virtual void UpdateSkillWithoutMandatoryDetails_PleaseEnterSkillAndSkillLevel()
        {
#line 66
this.UpdateSkillWithoutMandatoryDetails("Please Enter Skill and SkillLevel", ((string[])(null)));
#line hidden
        }
        
        public virtual void DeleteSkill(string skillname, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "automation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Skill", @__tags);
#line 75
this.ScenarioSetup(scenarioInfo);
#line 76
    testRunner.Given("I clicked on the Skills tab under Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
 testRunner.When(string.Format("I delete skill \'{0}\'", skillname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then(string.Format("i should not see deleted skill \'{0}\'displayed on my listings", skillname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete Skill: AJAX")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Skills Tab")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "AJAX")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Skillname", "AJAX")]
        public virtual void DeleteSkill_AJAX()
        {
#line 75
this.DeleteSkill("AJAX", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
