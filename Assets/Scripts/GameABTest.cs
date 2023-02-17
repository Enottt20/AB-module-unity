using System;
using Assets.Scripts.AB;

namespace Assets.Scripts
{
    public class GameABTest : BaseABTest
    {
        public GameABTest(string testName, Group[] groups) : base(testName, groups)
        {
        }

        public override bool LaunchConditions()
        {
            return true;
        }

        public override bool CompletionConditions()
        {
            return false;
        }
    }
}