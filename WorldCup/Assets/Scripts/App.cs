using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public static App inst { get; private set; } = null;
    [Header("Managers")][Space(5f)]
    public UICommonMgr uiMgr = null;
    public Controller controller = null;
    public DataLoad dataMgr = null;
    
    
    public void Start()
    {
        inst = this;
        inst.Create();
    }
    
    public void Create()
    {
        Debug.Log("App.Create.0");
        Application.targetFrameRate = 60;

        OnCreste();
    }
    public void OnCreste()
    {
        dataMgr.Create();
        uiMgr.Create();
    }
    
    public void OnApplicationQuit()
    {
        inst.Delete();
        inst = null;
    }
    public void Delete()
    {
        uiMgr.Delete();
    }
}
