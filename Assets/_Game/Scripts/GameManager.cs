using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private int score;
    public int Score => score;

    public void Start()
    {
        this.RegisterListener(EventID.OnInitLevel, (param) => OnInit());
        UIManager.Ins.OpenUI<UIMainmenu>();
    }

    public void OnInit()
    {
        score = 0;
        UIManager.Ins.OpenUI<UIGameplay>();
        UIManager.Ins.GetUI<UIGameplay>().UpdateTextScore();
        UIManager.Ins.GetUI<UIGameplay>().UpdateTextLevel();
    }

    public void AddScore(int score)
    {
        this.score += score;
        UIManager.Ins.GetUI<UIGameplay>().UpdateTextScore();
    }
}
