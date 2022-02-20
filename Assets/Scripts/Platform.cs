using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    public float jump = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var rb = collision.GetComponent<Rigidbody2D>();
        if(rb.velocity.y<0)
        {
            var y = rb.velocity;
            y.y = jump;
            rb.velocity = y;
        }
            
    }
}
