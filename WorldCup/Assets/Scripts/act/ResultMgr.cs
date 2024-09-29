using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResultMgr : UIBase
{
    public MatchPrefab result = null;
    public Image[] btnImg = new Image[2];
    public override void Create()
    {
        base.Create();
    }

    public override void Show()
    {
        base.Show();
        Invoke("EventMethod", 5f);
    }
   
    void EventMethod()
    {
        Hide(() =>
        {
            App.inst.controller.isGameStarted = false;
            App.inst.uiMgr.openingMgr.Show();
            
        });
    }
    
    
}
