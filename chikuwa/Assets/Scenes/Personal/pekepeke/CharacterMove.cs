using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] private float JumpPower = 9;
    [SerializeField] private float MovePower = 5;
    private Rigidbody2D rb;
    private int JumpCount = 0;
    private int RightCount = 0;
    private int LeftCount = 1;
    private int MaxJump = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow) && LeftCount < 1)
        {
            transform.Translate(-10, 0, 0);     //左ワープ
            LeftCount++;
            RightCount = 0;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && RightCount < 1)
        {
            transform.Translate(10, 0, 0);      //右ワープ
            RightCount++;
            LeftCount = 0;

        }


        this.rb.velocity = new Vector3(MovePower,GetComponent<Rigidbody2D>().velocity.y, 0);    //右移動

        if (JumpCount <= MaxJump)//  もし、Groundedがtrueなら、
        {
            if (Input.GetKeyDown(KeyCode.Space))//  もし、スペースキーがおされたなら、  
            {
                JumpCount++;//  Groundedをfalseにする
                this.rb.velocity = new Vector3(GetComponent<Rigidbody2D>().velocity.x, JumpPower, 0);    //ジャンプ
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            JumpCount = 0;//  Groundedをtrueにする
        }

        if (collision.gameObject.tag == "Item")//  もしItemというタグがついたオブジェクトに触れたら、
        {
            MaxJump++;  //ジャンプ回数を増やす
        }
    }
        
}
