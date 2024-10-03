using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;

public class BtnPrefab : MonoBehaviour
{
    public Image imgOn =null;
    public Image imgOff =null;

    public void OnBtn()
    {
        imgOn.gameObject.SetActive(true);
    }
    public void OffBtn()
    {
        imgOn.gameObject.SetActive(false);
    }
}
