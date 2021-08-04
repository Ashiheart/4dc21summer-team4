using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float InitVelocity;
    [SerializeField] float InitPosition;
    float timer;
    float pos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(InitPosition, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(InitVelocity, 0, 0);
    }

    void Pinch(float timer, float pos)
    {
        float i;
        for (i = 0; i <= timer; i += Time.deltaTime)
        {
            transform.position += new Vector3(InitVelocity, 0, 0);
        }
    }
}
