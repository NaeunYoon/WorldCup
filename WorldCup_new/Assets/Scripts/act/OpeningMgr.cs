using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningMgr : Mgrs
{
    public override void Create()
    {
        base.Create();
        Show();
        
    }
    public override void Show()
    {
        base.Show();
        App.inst.bgm.clip = App.inst.bgmSource[0];
        App.inst.bgm.Play();
    }
    public override void Hide()
    {
        base.Hide();
    }
}
