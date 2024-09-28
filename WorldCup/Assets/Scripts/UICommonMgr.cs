using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICommonMgr : MonoBehaviour
{
  public OpeningMgr openingMgr = null;
  public CategoryMgr categoryMgr = null;
  public RoundMgr roundMgr = null;
  public MatchTableMgr matchTableMgr = null;
  
  public virtual void Create() 
  {
    openingMgr.Create();
    categoryMgr.Create();
    roundMgr.Create();
    matchTableMgr.Create();
  }
  
  public virtual void Delete() 
  {
    matchTableMgr.Delete();
    roundMgr.Delete();
    categoryMgr.Delete();
    openingMgr.Delete();
  }
  
  
}
