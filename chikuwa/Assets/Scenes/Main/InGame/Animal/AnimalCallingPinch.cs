using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class AnimalCallingPinch : MonoBehaviour
{
    [SerializeField] private ChikuwaHitPoint chikuwaHp;

    [SerializeField] private AnimalMove animalMove;

    // Start is called before the first frame update
    void Start()
    {
        if (chikuwaHp == null) Debug.LogError("ChikuwaHp is null");

        chikuwaHp
            .CurrentHitPoint
            .Subscribe(_ => animalMove.Pinch(animalMove.timer, animalMove.pos))
            ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
