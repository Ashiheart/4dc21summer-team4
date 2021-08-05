using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramdom : MonoBehaviour
{
    public GameObject block;
    public GameObject AllTrans;
    public float Allspeed; //ブロックが右に流れていくスピード
    public float timeOut; //何秒ごとにブロックがくるか
    private float timeElapsed;

    private int BlockValueOver;
    private int BlockValueUnder;
    public float BlockBaseY;//画面端にくるブロックのY座標　
    public float BlockBaseX;//画面端にくるブロックのX座標　 大きければ遠くからくるから最初の波がくるのが遅くなる。
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AllTrans.transform.position += new Vector3(-Allspeed, 0, 0);

        timeElapsed += Time.deltaTime;


        if (timeElapsed >= timeOut)
        {
            BlockValueOver = Random.Range(1, 5);

            for (int i = 0; i <= BlockValueOver; i++)
            {
                GameObject Blockclone = GameObject.Instantiate(block) as GameObject; //複製
                Blockclone.transform.parent = AllTrans.transform;　//BlockcloneをAllTransの子オブジェクトに
                Blockclone.transform.position = new Vector3(BlockBaseX, i - BlockBaseY, 0);　//位置を調整
            }
            BlockValueUnder = Random.Range(1, 2);
            for (int j = 0; j <= BlockValueUnder; j++)
            {
                GameObject Blockclone = GameObject.Instantiate(block) as GameObject;
                Blockclone.transform.parent = AllTrans.transform;
                Blockclone.transform.position = new Vector3(BlockBaseX, -j + BlockBaseY, 0);
            }
            timeElapsed = 0.0f;
        }


    }
}
