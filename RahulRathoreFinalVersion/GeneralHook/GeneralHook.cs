﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumWebdriver.ComponentHelper;
using TechTalk.SpecFlow;

namespace SeleniumWebdriver.GeneralHook
{
    [Binding]
    public sealed class GeneralHook
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("BeforeTestRun Hook");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("AfterTestRun Hook");
        }

       [BeforeFeature("Tag1")]
        public static void BeforeFeature()
        {
            Console.WriteLine("BeforeFeature Hook");
        }

       [AfterFeature("Tag1")]
        public static void AfterFeature()
        {
            Console.WriteLine("AfterFeature Hook");
        }

       [BeforeScenario("Tag2")]
        public static void BeforeScenario()
        {
            Console.WriteLine("BeforeScenario Hook");
        }

       [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("AfterScenario Hook");
            Console.WriteLine(ScenarioContext.Current.ScenarioInfo.Title);
            Console.WriteLine(ScenarioContext.Current.TestError);

        }
    }
}
