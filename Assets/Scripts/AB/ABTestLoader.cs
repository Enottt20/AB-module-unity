using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.AB
{
    /// <summary>
    /// В теории подгрузка удаленных конфигов должна быть в этом классе. Подгружать их можно без обновления самой игры. 
    /// </summary>
    public class ABTestLoader : MonoBehaviour
    {
        public List<BaseABTest> Tests { get; } = new List<BaseABTest>();
        
        public ABTestInteractor TestInteractor { get; private set; }

        private void Start()
        {
            var test1 = new GameABTest("Test1",new []
            {
                new Group(0.5f, new []
                {
                    new GameConfig(1, 1, 2, 2)
                }),
                new Group(0.5f, new []
                {
                    new GameConfig(2, 2, 2, 2)
                }),
                new Group(0.5f, new []
                {
                    new GameConfig(3, 3, 2, 2)
                })
            });
            
            Tests.Add(test1);
            
            var test2 = new GameABTest("Test2",new []
            {
                new Group(0.5f, new []
                {
                    new GameConfig(4, 4, 2, 2)
                }),
                new Group(0.5f, new []
                {
                    new GameConfig(5, 5, 2, 2)
                }),
                new Group(0.5f, new []
                {
                    new GameConfig(6, 6, 2, 2)
                })
            });
            
            Tests.Add(test2);
            
            var test3 = new GameABTest("Test3",new []
            {
                new Group(0.5f, new []
                {
                    new GameConfig(7, 7, 2, 2)
                }),
                new Group(0.5f, new []
                {
                    new GameConfig(8, 8, 2, 2)
                }),
                new Group(0.5f, new []
                {
                    new GameConfig(9, 9, 2, 2)
                })
            });
            
            Tests.Add(test3);
            
            var test4 = new GameABTest("Test4",new []
            {
                new Group(0.1f, new []
                {
                    new GameConfig(10, 10, 2, 2)
                }),
                new Group(0.1f, new []
                {
                    new GameConfig(11, 11, 2, 2)
                }),
                new Group(0.1f, new []
                {
                    new GameConfig(12, 12, 2, 2)
                })
            });
            
            Tests.Add(test4);
            
            
            
            TestInteractor = new ABTestInteractor(this);
        }
    }
}