using UnityEngine;

namespace Assets.Scripts.AB
{ 
    public abstract class BaseABTest
    {

        public readonly string testName;

        public readonly Group[] groups;
        
        public BaseABTest(string testName, Group[] groups)
        {
            this.testName = testName;
            this.groups = groups;
        }
        
        public abstract bool LaunchConditions();

        public abstract bool CompletionConditions();
        
    }
}