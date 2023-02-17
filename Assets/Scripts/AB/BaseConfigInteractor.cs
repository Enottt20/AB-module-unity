using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.AB;
using UnityEngine;

public abstract class BaseConfigInteractor<T> where T : BaseConfig
{
    private List<T> _configs = new List<T>();

    public BaseConfigInteractor(ABTestInteractor testInteractor)
    {
        var finalConfigs = testInteractor.FinalConfigs();
        foreach (var configs in finalConfigs)
        {
            foreach (var config in configs)
            {
                if (config is T o)
                {
                    _configs.Add(o);
                }
            }
        }
    }


    public T FinalConfig()
    {
        BaseConfig baseConfig = new BaseConfig(0);
        
        foreach (var config in _configs)
        {
            if (baseConfig.priority < config.priority)
            {
                baseConfig = config;
            }
        }
        
        return (T)baseConfig;
    }
}
