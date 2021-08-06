using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChange : MonoBehaviour
{
    //　現在どのキャラクターを操作しているか
    private int nowChara;
    //　操作可能なゲームキャラクター
    [SerializeField]
    private List<GameObject> charaList;
    // Start is called before the first frame update
    void Start()
    {
        charaList[0].SetActive(true);
        charaList[1].SetActive(false);
        charaList[0].GetComponent<CharacterMove>();
    }

    public void ChangeCharacter(int tempNowChara)
    {
        //　現在操作しているキャラクターを動かなくする
        charaList[tempNowChara].SetActive(false);
        //　次のキャラクターの番号を設定
        var nextChara = tempNowChara + 1;

        //　次のキャラクターを動かせるようにする
        charaList[nextChara].SetActive(true);
        charaList[nextChara].GetComponent<CharacterMove>();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
