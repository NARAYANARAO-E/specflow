using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Gherkin.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_BDDFramework.Reports
{
    //public class ExtentReports
    //{

    //    private static ScenarioContext _scenariocontext;
    //    private static FeatureContext _Featurecontext;
    //    private static ExtentReports _extentreports;
    //    private static ExtentHtmlReporter _extenthtmlreports;
    //    private static ExtentTest _feature;
    //    private static ExtentTest _scenario;

    //    [BeforeTestRun]
    //    public static void Beforetestrun()
    //    {
    //        _extenthtmlreports = new ExtentHtmlReporter("S:\\Selenium_C#Project\\Specflow_Bdd\\TestResults");
    //        _extentreports = new ExtentReports();
    //        _extentreports.AttachReporter(_extenthtmlreports);
    //    }
    //    [BeforeFeature]
    //    public static void BeforeFeatureStart(FeatureContext featurecontext)
    //    {

    //        if (null != featurecontext)
    //        {
    //            _feature = _extentreports.CreateTest<AventStack.ExtentReports.Gherkin.Model.Feature>(featurecontext.FeatureInfo.Title, featurecontext.FeatureInfo.Description);

    //        }
    //    }
    //    [BeforeScenario]
    //    public static void Beforescenariostart(ScenarioContext scenariocontext)
    //    {
    //        if (null != scenariocontext)
    //        {
    //            _scenariocontext = scenariocontext;
    //            _scenario = _feature.CreateNode<AventStack.ExtentReports.Gherkin.Model.Scenario>(scenariocontext.ScenarioInfo.Title, scenariocontext.ScenarioInfo.Description);
    //        }
    //    }
    //    [AfterStep]
    //    public static void AfterEachStep()
    //    {
    //        ScenarioBlock scenarioBlock = _scenariocontext.CurrentScenarioBlock;
    //        switch (scenarioBlock)
    //        {
    //            case ScenarioBlock.Given:
    //                _scenario.CreateNode<Given>(_scenariocontext.StepContext.StepInfo.Text);
    //                break;
    //            case ScenarioBlock.When:
    //                _scenario.CreateNode<When>(_scenariocontext.StepContext.StepInfo.Text);
    //                break;
    //            case ScenarioBlock.Then:
    //                _scenario.CreateNode<Then>(_scenariocontext.StepContext.StepInfo.Text);
    //                break;
    //        }
    //    }
    //    public static void AfterTestrun()
    //    {
    //        _extentreports.Flush();
    //    }
    //}

}

