using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;

public class LoadData : MonoBehaviour
{
    
//    [SerializeField]
//    private string GameName;
    public TextMeshProUGUI Textbox;
    public UnityEvent onClick;

    public void Start() { }



	public void debug() {
        Debug.Log("Pressed Button");
	}

	public void setText(string GameName){
        Debug.Log("Setting text to: <" + GameName + ">");
        Textbox.GetComponent<TextMeshProUGUI>().text = GameName;
    }

	public void setAlpha() { }

	
}
    