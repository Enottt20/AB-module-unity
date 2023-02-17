using UnityEngine;

namespace Assets.Scripts.AB
{
    public class GroupDistributor
    {
        private readonly BaseABTest _test;
        
        public GroupDistributor(BaseABTest test)
        {
            _test = test;
        }

        public Group FinalGroup()
        {
            if (new ABTestDataHandler().GroupNumber(_test.testName) != null)
            {
                return _test.groups[(int)new ABTestDataHandler().GroupNumber(_test.testName)];
            }
            
            float overallRatio = 0;
            
            foreach (var group in _test.groups)
            {
                overallRatio += group.Balance;
            }

            float winningRatio = Random.Range(0, overallRatio);
            
            Group finalGroup = null;

            for (int i = 0; i < _test.groups.Length; i++)
            {
                winningRatio -= _test.groups[i].Balance;
                
                if (winningRatio <= 0)
                {
                    finalGroup = _test.groups[i];
                    
                    new ABTestDataHandler().Save(_test.testName, i);
                    
                    break;
                }
            }

            return finalGroup;
        }
    }
}