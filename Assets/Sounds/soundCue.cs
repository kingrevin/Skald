using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundCue : MonoBehaviour
{

    public AudioSource Script;
    public float tiemr = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tiemr >= 0)
        {
            tiemr -= Time.deltaTime;

         
        }
        else if (tiemr <= 0)
        {
            
        }
    }
}
