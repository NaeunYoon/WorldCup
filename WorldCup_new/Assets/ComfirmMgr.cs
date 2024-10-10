using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComfirmMgr : UIBase
{
    public TextMeshProUGUI title = null;
    public TextMeshProUGUI num = null;
    public override void Show()
    {
        App.inst.bgm.clip = App.inst.bgmSource[1];
        App.inst.bgm.Play();
        
        base.Show();
        title.text = App.inst.controller.selectedcategoryName.ToString();
        num.text = App.inst.controller.selectedRound.ToString();
    }
}
