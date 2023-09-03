using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer rend;
    private int i;
    private int target;
    void Start()
    {
        target = Random.Range(150, 251);
        i=3;
    }

    // Update is called once per frame
    void Update()
    {
        i+=1;
        Debug.Log(gameObject.name + ":" + i.ToString());
        if (gameObject.tag == "red" && i==100) {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "blue" && i==100) {
            gameObject.SetActive(false);
        }
    }
}
