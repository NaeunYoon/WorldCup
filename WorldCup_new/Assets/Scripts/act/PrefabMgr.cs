using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrefabMgr : MonoBehaviour
{
    public Image selectedMark = null;
    public TextMeshProUGUI text = null;
    
    public virtual void Selected()
    {
        selectedMark.gameObject.SetActive(true);
    }
    public virtual void NoneSelected()
    {
        selectedMark.gameObject.SetActive(false);
    }
    
}
