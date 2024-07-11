using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test_ : MonoBehaviour
{
    public Slider bar;
    public GameObject fill;
    public float aaa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bar.value = aaa;
        if (aaa <= 0)
        {
            fill.SetActive(false);
        }
    }
}
