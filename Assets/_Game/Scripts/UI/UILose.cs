using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UILose : UICanvas
{
    [SerializeField] TextMeshProUGUI textScore, textLevel;
    [SerializeField] Button btnPlayAgain;
    private void Awake()
    {
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
