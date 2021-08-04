using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] private float JumpPower = 400;
    [SerializeField] private float MovePower = 100;
    [SerializeField] private float MaxMoveSpeed = 10;
    private Rigidbody2D rb;
    private int JumpCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Mathf.Abs(this.rb.velocity.x);

        if(speed < MaxMoveSpeed)
        {
            this.rb.AddForce(transform.right * MovePower);
        }

        if (JumpCount <= 1)//  もし、Groundedがtrueなら、
        {
            if (Input.GetKeyDown(KeyCode.Space))//  もし、スペースキーがおされたなら、  
            {
                JumpCount++;//  Groundedをfalseにする
                this.rb.AddForce(Vector3.up * JumpPower,ForceMode2D.Impulse);//  上にJumpPower分力をかける
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            JumpCount = 0;//  Groundedをtrueにする
        }
    }
        
}
