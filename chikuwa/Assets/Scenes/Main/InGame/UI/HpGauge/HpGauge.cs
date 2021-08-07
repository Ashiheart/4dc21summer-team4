using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UniRx;


public class HpGauge : MonoBehaviour
{
    [SerializeField] private ChikuwaHitPoint chikuwaHp;

    [SerializeField] private GameObject chikuwaLife;

    [SerializeField] private Vector3 initHpShow;

    [SerializeField] private Vector3 showStep;

    private List<GameObject> HpLifes;

    // Start is called before the first frame update
    void Start()
    {
        chikuwaHp
            .MaxHitPoint
            .Subscribe(n =>
            {
                HpLifes = new List<GameObject>();
                for (int i = 0; i < n; i++)
                {
                    HpLifes.Add(Instantiate(chikuwaLife));
                    HpLifes.Last().transform.position = initHpShow + showStep * i;
                    HpLifes.Last().GetComponent<SpriteRenderer>().enabled = true;
                }
            }
            )
            ;

        chikuwaHp
            .CurrentHitPoint
            .Subscribe(n =>
            {
                for (int i = 0; i < n; i++)
                {
                    HpLifes[i].GetComponent<SpriteRenderer>().enabled = true;
                }
                for(int i = n; i < HpLifes.Count; i++)
                {
                    HpLifes[i].GetComponent<SpriteRenderer>().enabled = false;
                }
            }
            )
            ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
