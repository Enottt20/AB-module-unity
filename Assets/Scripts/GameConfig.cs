using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.AB;
using UnityEngine;

public class GameConfig : BaseConfig
{
    public int startCoins;
    public int startMultiplier;
    public int startReward;

    public GameConfig(int priority, int startCoins, int startMultiplier, int startReward) : base(priority)
    {
        this.startCoins = startCoins;
        this.startMultiplier = startMultiplier;
        this.startReward = startReward;

    }
}
