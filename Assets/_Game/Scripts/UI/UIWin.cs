using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIWin : UICanvas
{
    [SerializeField] TextMeshProUGUI textScore, textLevel;
    [SerializeField] Button btnPlayAgain, btnNextLevel;
    private void Awake()
    {
        btnNextLevel.onClick.AddListener(() =>
        {
            CloseDirectly();
            LevelManager.Ins.NextLevel();
        });

        btnPlayAgain.onClick.AddListener(() =>
        {
            CloseDirectly();
            LevelManager.Ins.PlayAgain();
        });
    }

    public override void Open()
    {
        base.Open();
        textScore.text = GameManager.Ins.Score.ToString();
        textLevel.text = "Level " + (LevelManager.Ins.currentLevelIndex + 1).ToString();
    }
}
