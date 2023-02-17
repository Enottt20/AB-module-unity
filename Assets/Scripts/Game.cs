using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.AB;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Text coinsText;
    [SerializeField] private Button addCoinButton;
    [SerializeField] private ABTestLoader testLoader;
    private GameConfig gameConfig;
    
    private int _coins;
    private int _multiplier;
    private int _reward;

    private void Start()
    {
        gameConfig = new GameConfigInteractor(testLoader.TestInteractor).FinalConfig();

        _coins = gameConfig.startCoins;
        _multiplier = gameConfig.startMultiplier;
        _reward = gameConfig.startReward;

        addCoinButton.onClick.AddListener(OnClickAddCoinsButton);
        
        UpdateUi();
    }

    private void OnClickAddCoinsButton()
    {
        AddCoins();
        UpdateUi();
    }

    private void AddCoins()
    {
        _coins += _reward * _multiplier;
    }

    private void UpdateUi()
    {
        coinsText.text = _coins.ToString();
    }
}
