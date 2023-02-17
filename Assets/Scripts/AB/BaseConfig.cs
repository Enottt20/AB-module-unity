using UnityEngine;

namespace Assets.Scripts.AB
{
    public class BaseConfig
    {
        //чем выше тем главнее
        public readonly int priority;
        public BaseConfig(int priority)
        {
            this.priority = priority;
        }
    }
}