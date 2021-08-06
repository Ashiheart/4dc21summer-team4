using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randam : MonoBehaviour
{
    public GameObject[] Meteo;
    private int number;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Make", 1f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Make()
    {
        Vector3 randomPos = Vector3.zero;
        randomPos.y = Random.Range(-20, 20);

        number = Random.Range(0, Meteo.Length);
        Instantiate(Meteo[number], transform.position + randomPos, transform.rotation);
        Invoke("Make", 1f);
    }
}
