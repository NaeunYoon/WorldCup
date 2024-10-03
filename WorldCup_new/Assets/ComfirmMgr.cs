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
        base.Show();
        title.text = App.inst.controller.selectedcategoryName.ToString();
        num.text = App.inst.controller.selectedRound.ToString();
    }
}
