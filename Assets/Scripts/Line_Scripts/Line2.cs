using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line2 : MonoBehaviour
{

    private bool triggered = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.CompareTag ("Player"))
        {

            if (triggered == true)
            {
                FindObjectOfType<AudioManager>().Play("Line2");
                triggered = false;
            }
        }
    }
}
