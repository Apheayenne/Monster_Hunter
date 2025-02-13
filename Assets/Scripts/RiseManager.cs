using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class RiseManager : MonoBehaviour
{
    public static bool isDLC {  get; set; }
    public TextMeshProUGUI header;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "";
        if (isDLC)
	    {
            name = "Rise: Sunbreak";
	    } else 
        {
            name = "Rise";
        }   
        
        header.text = "Monster Hunter " + name;
    }



}
