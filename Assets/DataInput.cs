using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInput : MonoBehaviour
{
    public Text txtUserName;

    public void ShowGreeting()
    {
        Debug.Log("Hola" + txtUserName.text);
    }
}
