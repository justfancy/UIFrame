using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour {

    private void Awake()
    {
        UIBase temBase = GetComponentInParent<UIBase>();
        UIManager.Instance.RegistGameObject(temBase.name,transform.name,gameObject);
    }
    public void AddbuttonListion(UnityAction actin)
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(actin);
        }
    }
    public void AddInputFiled(UnityAction<string> action) {
        InputField inputField = GetComponent<InputField>();
        if (inputField != null)
        {
            inputField.onEndEdit.AddListener(action);
        }
    }
}
