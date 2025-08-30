using UnityEngine;

public class Player : MonoBehaviour
{ 

    Rigidbody2D RB2D;
    Animator MyAnimator;
    public float Speed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
        MyAnimator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RB2D.linearVelocity = Vector3.left* Speed;
            MyAnimator.SetInteger("Direction", 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RB2D.linearVelocity = Vector3.right * Speed;
            MyAnimator.SetInteger("Direction", 3);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            RB2D.linearVelocity = Vector3.up * Speed;
            MyAnimator.SetInteger("Direction", 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            RB2D.linearVelocity = Vector3.down * Speed;
            MyAnimator.SetInteger("Direction", 2);
        }
        else {
            RB2D.linearVelocity = Vector3.zero;
            MyAnimator.SetInteger("Direction", -1);
        }

    }
}