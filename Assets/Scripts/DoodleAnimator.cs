using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodleAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite LeftJump;
    public Sprite LeftFall;
    public Sprite RightJump;
    public Sprite RightFall;
    public SpriteRenderer sprites;
    public Rigidbody2D rigid;
    private float xVelocity;
    private float yVelocity;
    private bool isLeft=false;

    // Update is called once per frame
    void Update()
    {
        xVelocity = rigid.velocity.x;
        yVelocity = rigid.velocity.y;
        if(xVelocity>0)
        {
            isLeft = false;
            if(yVelocity>0)
            {
                sprites.sprite = RightJump;
            }
            else
            {
                sprites.sprite = RightFall;
            }
        }
        else if (xVelocity < 0)
        {
            isLeft = true;
            if (yVelocity > 0)
            {
                sprites.sprite = LeftJump;
            }
            else
            {
                sprites.sprite = LeftFall;
            }
        }
        else
        {
            if(isLeft)
            {
                if (yVelocity > 0)
                {
                    sprites.sprite = LeftJump;
                }
                else
                {
                    sprites.sprite = LeftFall;
                }
            }
            else
            {
                if (yVelocity > 0)
                {
                    sprites.sprite = RightJump;
                }
                else
                {
                    sprites.sprite = RightFall;
                }
            }
        }
    }
}
