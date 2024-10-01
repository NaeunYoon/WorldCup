using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class MatchPrefab : PrefabMgr
{
    public Image img = null;
    public RectTransform rect = null;

    public void WinLeft()
    {
        rect.sizeDelta = new Vector2(888, 1014);
    }

    public void WinRight()
    {
        rect.sizeDelta = new Vector2(888, 1014);
    }

    public override void Selected()
    {
        rect.sizeDelta = new Vector2(808, 934);
    }

    public override void NoneSelected()
    {
        rect.sizeDelta = new Vector2(788, 914);
    }
}
