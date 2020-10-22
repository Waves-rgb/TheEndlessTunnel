using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRender : MonoBehaviour
{
    void Start()
    {
        GetComponentInParent<Renderer>().enabled = false;
    }
}
