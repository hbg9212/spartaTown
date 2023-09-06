using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player P;

    private void Awake()
    {
        P = this;
    }
}
