using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CategoryMgr : Mgrs
{
   public CategoryPrefab prefab = null;
   public GameObject content = null;
   public List<CategoryPrefab> categoryList = null;
   public ScrollRect rect = null;

   public List<Dictionary<string, Sprite>> DirectoryImgList => App.inst.uiMgr.matchTableMgr.directoryImgList;
   
   
   public override void Create()
   {
      base.Create();
      InstantiatePrefabs();  
   }
   public override void Show()
   {
      base.Show();
      SelectedItem(0);
      App.inst.controller.selectedcategoryName = categoryList[0].name;
   }
   

   public void InstantiatePrefabs()
   {
      for (int i = 0; i < DirectoryImgList.Count; i++)
      {
         var t_prefab = Instantiate(prefab,content.transform);
         t_prefab.name = App.inst.dataMgr.directories[i];
         t_prefab.text.text = App.inst.dataMgr.directories[i];
         
         if (!Validation(DirectoryImgList[i]))
         {
            t_prefab.text.color = Color.red;
         }
         categoryList.Add(t_prefab);
      }
   }
   
   public bool Validation(Dictionary<string, Sprite> dir )
   {
      if (dir.Count < 36)
      {
         return false;
      }
      return true;
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
