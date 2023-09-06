using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintMessage : MonoBehaviour
{
    public Text text;

    private void Start()
    {
        Invoke("destroy", 0.5f);
    }

    private void destroy()
    {
        Destroy(gameObject);
    }

    public void MsgSet(string msg)
    {
        text.text = msg;
    }

}
