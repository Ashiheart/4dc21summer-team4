using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class ChikuwaHitPoint : MonoBehaviour
{


    private IntReactiveProperty currentHitPoint;
    public IReadOnlyReactiveProperty<int> CurrentHitPoint => currentHitPoint;

    [SerializeField] private BigtikuwaMove bigChikuwaStatus;

    [SerializeField] private CharacterMove smallChikuwaStatus;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.ObserveEveryValueChanged()
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
