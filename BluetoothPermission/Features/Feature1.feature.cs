﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BluetoothPermission.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("bluetoothpermission")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    public partial class BluetoothpermissionFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "bluetoothpermission", @"![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BluetoothPermission/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "Feature1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify option to request bluetooth permission")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyOptionToRequestBluetoothPermission()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify option to request bluetooth permission", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 10
  await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 11
  await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 12
     await testRunner.ThenAsync("verify \'Ok\' is \'displayed\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify option to open settings in bluetooth permission page")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyOptionToOpenSettingsInBluetoothPermissionPage()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify option to open settings in bluetooth permission page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 16
     await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 17
     await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 18
     await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 19
     await testRunner.WhenAsync("I \'Deny\' permission request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 20
     await testRunner.ThenAsync("verify \'OpenSettings\' is \'displayed\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify bluetooth permissions granted already")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyBluetoothPermissionsGrantedAlready()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify bluetooth permissions granted already", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 24
     await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 25
     await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 26
     await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 27
     await testRunner.WhenAsync("I \'Grant\' permission request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 28
     await testRunner.AndAsync("I terminate and relaunch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 29
     await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 30
     await testRunner.ThenAsync("verify plugin is completed", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify rationale on granting the bluetooth permissions")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyRationaleOnGrantingTheBluetoothPermissions()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify rationale on granting the bluetooth permissions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 34
        await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 35
        await testRunner.WhenAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 36
        await testRunner.ThenAsync("verify \'BluetoothPermissionHeader\' is \'displayed\' on \'BluetoothPermissionPluginPa" +
                        "ge\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 37
        await testRunner.AndAsync("verify \'BluetoothPermissionBody\' is \'displayed\' on \'BluetoothPermissionPluginPage" +
                        "\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify bluetooth permission request through OS")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyBluetoothPermissionRequestThroughOS()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify bluetooth permission request through OS", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 41
        await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 42
        await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 43
        await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 44
        await testRunner.ThenAsync("verify permission request alert is displayed and close alert", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify bluetooth permission is granted through OS")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyBluetoothPermissionIsGrantedThroughOS()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify bluetooth permission is granted through OS", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 47
        await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 48
        await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 49
        await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 50
        await testRunner.WhenAsync("I \'Grant\' permission request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 51
        await testRunner.ThenAsync("verify plugin is completed", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify rationale on not granting the bluetooth permissions")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyRationaleOnNotGrantingTheBluetoothPermissions()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify rationale on not granting the bluetooth permissions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 54
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 55
        await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 56
        await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 57
        await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 58
        await testRunner.WhenAsync("I \'Deny\' permission request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 59
        await testRunner.ThenAsync("verify \'Bluetooth permission app settings header\' is \'displayed\' on \'BluetoothPer" +
                        "missionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 60
        await testRunner.AndAsync("verify \'OpenSettingsPermissionBody\' is \'displayed\' on \'BluetoothPermissionPluginP" +
                        "age\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify the app settings are displayed through OS for bluetooth permissions for An" +
            "droid")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyTheAppSettingsAreDisplayedThroughOSForBluetoothPermissionsForAndroid()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify the app settings are displayed through OS for bluetooth permissions for An" +
                    "droid", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 63
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 64
        await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 65
        await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 66
        await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 67
        await testRunner.WhenAsync("I \'Deny\' permission request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 68
        await testRunner.AndAsync("I press \'OpenSettings\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 69
        await testRunner.ThenAsync("verify \'Permissions\' is \'displayed\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify permission flow is completed on granting bluetooth for Android")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyPermissionFlowIsCompletedOnGrantingBluetoothForAndroid()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify permission flow is completed on granting bluetooth for Android", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 72
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 73
        await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 74
        await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 75
        await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 76
        await testRunner.WhenAsync("I \'Deny\' permission request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 77
        await testRunner.AndAsync("I relaunch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 78
        await testRunner.AndAsync("I press \'OpenSettings\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 79
        await testRunner.AndAsync("I press \'Permissions\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 80
        await testRunner.AndAsync("I scroll \'Down\' and press \'NearbyDevices\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 81
        await testRunner.AndAsync("I press \'NativeSettingsAllow\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 82
        await testRunner.AndAsync("I terminate and relaunch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 83
        await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 84
        await testRunner.ThenAsync("verify plugin is completed", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify permission flow is not proceeded on denying bluetooth for Android")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyPermissionFlowIsNotProceededOnDenyingBluetoothForAndroid()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify permission flow is not proceeded on denying bluetooth for Android", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 87
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 88
        await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 89
        await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 90
        await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 91
        await testRunner.WhenAsync("I \'Deny\' permission request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 92
        await testRunner.AndAsync("I press \'OpenSettings\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 93
        await testRunner.AndAsync("I press \'Permissions\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 94
        await testRunner.AndAsync("I scroll \'Down\' and press \'NearbyDevices\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 95
        await testRunner.AndAsync("I press \'NativeSettingsDeny\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 96
        await testRunner.AndAsync("I relaunch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 97
        await testRunner.ThenAsync("verify \'OpenSettings\' is \'displayed\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify flow is completed on denying through OS for bluetooth permission")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public async System.Threading.Tasks.Task VerifyFlowIsCompletedOnDenyingThroughOSForBluetoothPermission()
        {
            string[] tagsOfScenario = new string[] {
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify flow is completed on denying through OS for bluetooth permission", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 99
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 100
        await testRunner.GivenAsync("I launch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 101
        await testRunner.AndAsync("I scroll \'Down\' and launch plugin \'BluetoothPermissionPlugin\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 102
        await testRunner.AndAsync("I press \'Ok\' on \'BluetoothPermissionPluginPage\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 103
        await testRunner.WhenAsync("I \'Deny\' permission request", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 104
        await testRunner.AndAsync("I terminate and relaunch the plugin app", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 105
        await testRunner.ThenAsync("verify plugin is completed", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
