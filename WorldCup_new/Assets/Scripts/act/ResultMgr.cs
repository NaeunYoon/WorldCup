using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResultMgr : Mgrs
{
    public MatchPrefab result = null;
    public BtnPrefab[] btnImg = new BtnPrefab[2];
    public bool isChecked =false;
    
    public override void Create()
    {
        base.Create();
    }

    public override void Show()
    {
        base.Show();
        isChecked = false;
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5f);
        if (!isChecked)
        {
            Hide(() =>
            {
                App.inst.controller.isGameStarted = false;
                App.inst.uiMgr.openingMgr.Show();
                StopCoroutine(   "Delay");;
                
            });
        }
    }
    
    public void UserSelected()
    {
        isChecked = true;
        StopCoroutine(Delay());
    }
}
