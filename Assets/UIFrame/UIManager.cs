using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public static UIManager Instance;
    private void Awake()
    {
        Instance = this;
        allChill = new Dictionary<string, Dictionary<string, GameObject>>();
    }
    //第一个string，存的是那个panel
    //第二个字典，string panel上那个子空间的名字
    public Dictionary<string, Dictionary<string, GameObject>> allChill;
    public void RegistGameObject(string panelName,string wedgetName,GameObject obj ) {
        if (!allChill.ContainsKey(panelName)) {
            allChill[panelName] = new Dictionary<string, GameObject>();
        }
        if (!allChill[panelName].ContainsKey(wedgetName)) {
            Debug.Log("child==" + obj.name);
            allChill[panelName].Add(wedgetName, obj);
        }
    }
    public GameObject GetGameObject(string panelName, string widgetName)
    {
        if (allChill.ContainsKey(panelName))
        {
            return allChill[panelName][widgetName];
        }
        return null;
    }

}
