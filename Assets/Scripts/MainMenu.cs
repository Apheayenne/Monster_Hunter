using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    private Boolean clicked = false;

    private Color trans = new Vector4(1, 1, 1, 0.5f);
    public void dimButton(Button b1)
    {
        b1.GetComponent<Image>().color = trans;
        clicked = false;
    }
    public void resetButton(Button b1)
    {
        //if this button was clicked once before
        if (clicked) 
        {
            switch (b1.name) {
                case "B_World":
                    Debug.Log(b1.name + " was clicked!");
                    // WorldManager.isDLC = false;
					break;
                case "B_World_Iceborne":
                    Debug.Log(b1.name + " was clicked!");
					// WorldManager.isDLC = false;
					break;
				case "B_Rise":
                    Debug.Log(b1.name + " was clicked!");
                    RiseManager.isDLC = false;
                    SceneManager.LoadScene("MH_Rise");
					break;
				case "B_Rise_Sunbreak":
                    Debug.Log(b1.name + " was clicked!");
                    RiseManager.isDLC = true;
					SceneManager.LoadScene("MH_Rise");
					break;
				case "B_Wilds":
                    Debug.Log(b1.name + " was clicked!");
                    // WildsManager.isDLC = false;
					break;
			}
		}

        // If this is the first time this button was clicked.
        b1.GetComponent<Image>().color = new Vector4(1, 1, 1, 1);
        clicked = true;
    }


    public void Show()
    {
        myUIGroup.alpha = 1;
        // SceneManager.LoadScene("Main");
    }
}
