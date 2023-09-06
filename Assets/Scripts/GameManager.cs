using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager I;

    private void Awake()
    {
        I = this;

    }

    public Text TimeTxt;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        DateTime nowDate = DateTime.Now;
        TimeTxt.text = nowDate.Hour + ":" + nowDate.Minute;
    }


}
