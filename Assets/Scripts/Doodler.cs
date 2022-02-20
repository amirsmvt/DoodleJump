using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doodler : MonoBehaviour
{
    public Rigidbody2D rig;
    public float jumpPower;
    public float speed =0;
    private float movement =0;
    //private float rotation = 0f;
    public Transform Left;
    public Transform Right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * speed;
        if (transform.position.x < Left.position.x)
        {
            var tmp = transform.position;
            tmp.x = Right.position.x;
            transform.position = tmp;
        }        
        if (transform.position.x > Right.position.x)
        {
            var tmp = transform.position;
            tmp.x = Left.position.x;
            transform.position = tmp;
        }
        //rotation = Input.GetAxis("Vertical") * 1.5f;
    }
    private void FixedUpdate()
    {
        var velocity = rig.velocity;
        velocity.x = movement;
        //transform.Rotate(0, rotation, 0)  ;
        rig.velocity = velocity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform" && rig.velocity.y < 0)
        {
            var tmp = rig.velocity;
            tmp.y = jumpPower;
            rig.velocity = tmp;
        }
        else if(collision.tag=="Loser" )
        {
            rig.simulated = false;
        }
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.tag == "Platform" && rig.velocity.y < 0)
    //    {
    //        var tmp = rig.velocity;
    //        tmp.y = jumpPower;
    //        rig.velocity = tmp;
    //    }
    //}
}
