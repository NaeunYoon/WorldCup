using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundMgr : Mgrs
{
    public List<RoundPrefab> roundList = null;
    public override void Create()
    {
        base.Create();
        
    }

    public override void Show()
    {
        base.Show();
        SelectedItem(0);
        App.inst.controller.selectedRound = roundList[0].round;
    }
    
    public void SelectedItem(int idx)
    {
        for (int i = 0; i < roundList.Count; i++)
        {
            roundList[i].NoneSelected();
        }
        roundList[idx].Selected();
    }
    
    public override void Hide()
    {
        base.Hide();
    }
}
