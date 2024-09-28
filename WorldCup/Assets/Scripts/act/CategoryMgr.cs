using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CategoryMgr : UIBase
{
   public CategoryPrefab prefab = null;
   public GameObject content = null;
   public List<CategoryPrefab> categoryList = null;
   public ScrollRect rect = null;
   public override void Create()
   {
      base.Create();
        
   }
   public override void Show()
   {
      base.Show();
      InstantiatePrefabs();
      categoryList[0].Selected();
      App.inst.controller.selectedcategoryName = categoryList[0].name;
   }

   public void InstantiatePrefabs()
   {
      for (int i = 0; i < App.inst.dataMgr.directories.Length; i++)
      {
         var t_prefab = Instantiate(prefab,content.transform);
         t_prefab.name = App.inst.dataMgr.directories[i];
         t_prefab.text.text = App.inst.dataMgr.directories[i];
         categoryList.Add(t_prefab);
      }
   }

   public void SelectedItem(int idx)
   {
      for (int i = 0; i < categoryList.Count; i++)
      {
         categoryList[i].NoneSelected();
      }
      categoryList[idx].Selected();
   }
   

   
   
   public override void Hide()
   {
      base.Hide();
   }
}
