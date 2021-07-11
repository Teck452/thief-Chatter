using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line3 : MonoBehaviour
{

    private bool triggered = true;

    public GameObject Rpikes;

    public GameObject Lpikes;

    private  Vector3 moverPikesStart;

    private Vector3 movelPikesStart;

    private Vector3 moverPikesEnd;

    private Vector3 movelPikesEnd;

    private float distance = 8f;

    private float timeTaken = 0.5f;

    private float currentTime = 0;

    private bool thief = false;

    public float rPikesDestroy = 5;

    public float lPikesDestroy = 5;

    public bool decay = false;
        


    // Start is called before the first frame update
    void Start()
    {
        moverPikesStart = Rpikes.transform.position;
        movelPikesStart = Lpikes.transform.position;
        moverPikesEnd = Rpikes.transform.position + Vector3.left * distance;
        movelPikesEnd = Lpikes.transform.position + Vector3.right * distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (thief == true)
        {
            currentTime += Time.deltaTime;
            if(currentTime >= timeTaken)
            {
                currentTime = timeTaken;
            }
            float Perc = currentTime / timeTaken;
            Rpikes.transform.position = Vector3.Lerp(moverPikesStart, moverPikesEnd, Perc);
            Lpikes.transform.position = Vector3.Lerp(movelPikesStart, movelPikesEnd, Perc);
        }

        if (decay == true)
        {
            rPikesDestroy -= Time.deltaTime;
            lPikesDestroy -= Time.deltaTime;
        }

        if (rPikesDestroy <= 0)
        {
            Destroy(Rpikes);
        }
        if (lPikesDestroy <= 0)
        {
            Destroy(Lpikes);
            decay = false;
            thief = false;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (triggered == true)
            {
                FindObjectOfType<AudioManager>().Play("Line3");
                triggered = false;
                thief = true;
                decay = true;
            }
           

            
         
        }
    }
}

