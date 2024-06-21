using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLevel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textButtonLevel;
    public Button btnLevel;
    private int levelIndex;

    public void InitButtonLevel(int levelIndex)
    {
        this.levelIndex = levelIndex;
        textButtonLevel.text = (this.levelIndex + 1).ToString();

        btnLevel.onClick.AddListener(() =>
        {
            UIManager.Ins.GetUI<UILevel>().CloseDirectly();
            LevelManager.Ins.OnLoadLevel(this.levelIndex);
        });
    }

}
