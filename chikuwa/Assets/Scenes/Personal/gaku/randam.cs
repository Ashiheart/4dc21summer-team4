using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randam : MonoBehaviour
{
    public GameObject[] Meteo;
    private int number;
    private int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Make", 2f);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Make()
    {
        Vector3 randomPos = Vector3.zero;
        randomPos.y = Random.Range(-5, 5);

        number = Random.Range(0, Meteo.Length);
        Instantiate(Meteo[number], transform.position + randomPos, transform.rotation);
        if (count >= 0 && count <= 10)
        { Invoke("Make", 3f);
        }
        if(count >=11 && count <=20)
        {
          Invoke("Make", 2.5f);
         }
        if (count >= 21)
        {
            Invoke("Make", 2f);
        }
            count++;
        
    }
}
