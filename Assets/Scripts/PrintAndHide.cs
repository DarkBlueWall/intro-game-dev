using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    private int i;
    void Start()
    {
        i=3;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + i.ToString());
        i+=1;
    }
}
