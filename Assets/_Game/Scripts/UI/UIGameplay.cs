using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameplay : UICanvas
{
    [SerializeField] TextMeshProUGUI textScore, textLevel;

    public void UpdateTextScore()
    {
        textScore.text = GameManager.Ins.Score.ToString();
    }

    public void UpdateTextLevel()
    {
        textLevel.text = "Level " + (LevelManager.Ins.currentLevelIndex + 1).ToString();
    }
}
