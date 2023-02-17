using Assets.Scripts.AB;
using UnityEngine;

public class Group
{
    public Group(float balance, BaseConfig[] baseConfigs)
    {
        Balance = balance;
        this.baseConfigs = baseConfigs;

    }
    //Баланс распределния участников
    private float _balance;
    
    /// <summary>
    /// Значения от 0 до 1
    /// </summary>
    public float Balance
    {
        get => _balance;

        private set
        {
            if (value > 1) 
                _balance = 1;
            else if (value < 0) 
                _balance = 0;
            else 
                _balance = value;
        }
    }
        
    public readonly BaseConfig[] baseConfigs;
}