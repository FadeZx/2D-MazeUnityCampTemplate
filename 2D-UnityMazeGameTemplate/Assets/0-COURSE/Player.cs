using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D MyRigidBody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MyRigidBody.linearVelocity = Vector2.right;
    }
}
