using UnityEngine;
using UnityEngine.Events;

public class UIBase : MonoBehaviour {

    private void Awake()
    {
        Transform[] allchild = transform.transform.GetComponentsInChildren<Transform>();
        //"_N"结尾的代表需要挂载UIBehaviour
        for (int i = 0; i < allchild.Length; i++)
        {
            if (allchild[i].name.EndsWith("_N"))
            {
                allchild[i].gameObject.AddComponent<UIBehaviour>();
            }
        }
    }
    public GameObject GetGameWidget(string widgetName)
    {
        return UIManager.Instance.GetGameObject(transform.name, widgetName);
    }
    public UIBehaviour GetIBehaviour(string widgetName)
    {
        GameObject temObj = GetGameWidget(widgetName);
        if (temObj != null) {
            return temObj.GetComponent<UIBehaviour>();
        }
        return null;
    }
    public void AddButtonListener(string widgetName,UnityAction action) {
        UIBehaviour temBehavoiur = GetIBehaviour(widgetName);
        if (temBehavoiur != null) {
            temBehavoiur.AddbuttonListion(action);
        }
    }
}
