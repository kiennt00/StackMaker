using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainmenu : UICanvas
{
    [SerializeField] Button btnPlay, btnShop;

    private void Awake()
    {
        btnPlay.onClick.AddListener(() =>
        {
            CloseDirectly();
            UIManager.Ins.OpenUI<UILevel>();
        });

        btnShop.onClick.AddListener(() =>
        {
            CloseDirectly();
            //UIManager.Ins.OpenUI<UIShop>();
        });
    }

    
}
