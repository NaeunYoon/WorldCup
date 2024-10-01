using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CategoryPrefab : PrefabMgr
{
   public string name = null;
   public RectTransform rect = null;

   public void ChangeBiggerSize()
   {
      rect.sizeDelta = new Vector2(500, 700);
   }
   public void ChangeSmallerSize()
   {
      rect.sizeDelta = new Vector2(400, 600);
   }
   
}
