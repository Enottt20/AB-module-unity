using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.AB
{
    public class ABTestInteractor
    {
        private readonly List<BaseABTest> _tests;

        public ABTestInteractor(ABTestLoader abTestLoader)
        {
            _tests = abTestLoader.Tests;
        }

        public List<BaseConfig[]> FinalConfigs()
        {
            List<BaseConfig[]> finalConfigs = new List<BaseConfig[]>();
            
            foreach (var test in _tests)
            {
                if (test.LaunchConditions() && !test.CompletionConditions())
                {
                    Group group = new GroupDistributor(test).FinalGroup();

                    finalConfigs.Add(group.baseConfigs);
                }
            }
            
            return finalConfigs;
        }
    }
}