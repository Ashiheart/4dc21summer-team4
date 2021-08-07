using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kakugen : MonoBehaviour
{
    public Text kakugen;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = Random.Range(0, 6);
        if(i == 0)
        {
            kakugen.text = "ちくわをのぞく時、ちくわもまたこちらをのぞいているのだ";
        }

        if (i == 1)
        {
            kakugen.text = "ちくわ大明神";
        }

        if (i == 2)
        {
            kakugen.text = "誰だ今の";
        }

        if (i == 3)
        {
            kakugen.text = "ちくわ入らずんばちくわ得ず";
        }

        if (i == 4)
        {
            kakugen.text = "そこのお前！\nちくわ1本あたりに含まれるスケトウダラはちくわ1本分だぜ";
        }

        if (i == 5)
        {
            kakugen.text = "今日僕はちくわの中をのぞいてしまった・・・";
        }

        if (i == 6)
        {
            kakugen.text = "ちくわ";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
