using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_Sprite_Animator : MonoBehaviour
{

    [SerializeField]
    Sprite[] run;

    private void Start()
    {
        Debug.Log("Anzahl Elemente " + run.Length);
    }
}
