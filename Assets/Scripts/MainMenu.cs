using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    private Boolean clicked = false;

    private Color trans = new Vector4(1, 1, 1, 0.5f);
    public void dimButton(Button b1)
    {

        b1.GetComponent<Image>().color = trans;        
    }
    public void resetButton(Button b1)
    {

        b1.GetComponent<Image>().color = new Vector4(1, 1, 1, 1);
    }


    public void Show()
    {

        myUIGroup.alpha = 1;
        // SceneManager.LoadScene("Main");
    }
}
