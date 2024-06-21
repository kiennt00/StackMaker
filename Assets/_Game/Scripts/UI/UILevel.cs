using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILevel : UICanvas
{
    [SerializeField] Button btnBack;

    [SerializeField] ButtonLevel btnLevelPrefab;
    [SerializeField] Transform btnLevelParent;
    private List<ButtonLevel> btnLevels = new();

    private int highestLevel;

    private void Awake()
    {
        btnBack.onClick.AddListener(() =>
        {
            CloseDirectly();
            UIManager.Ins.OpenUI<UIMainmenu>();
        });

        if (LevelManager.Ins.levels.Count > 0)
        {
            for (int i = 0; i < LevelManager.Ins.levels.Count; i++)
            {
                ButtonLevel btnLevel = Instantiate(btnLevelPrefab, btnLevelParent);
                btnLevel.InitButtonLevel(i);

                btnLevels.Add(btnLevel);
            }
        }
    }

    public override void Open()
    {
        base.Open();

        highestLevel = LevelManager.Ins.highestLevel;

        for (int i = 0; i < LevelManager.Ins.levels.Count; i++)
        {
            if (i <= highestLevel)
            {
                btnLevels[i].btnLevel.interactable = true;
            }
            else
            {
                btnLevels[i].btnLevel.interactable = false;
            }
        }
    }
}
