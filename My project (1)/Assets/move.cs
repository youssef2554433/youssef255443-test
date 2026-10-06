using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float movespeed;
    public float jump;
    public KeyCode L;
    public KeyCode R;
    public KeyCode Space;

    public Transform groundcheck;
    public float r;
    public LayerMask whatIsGround;
    private bool grounded;

    void Start()
    {
        
    }

    
    void Update()
    {

        if(Input.GetKeyDown(Space))
{
    Jump();

}
    
        if(Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed,GetComponent<Rigidbody2D>().velocity.y);

            if(GetComponent<SpriteRenderer>()!=null)
            {
                GetComponent<SpriteRenderer>().flipX=true;
            }
        }


        if(Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed,GetComponent<Rigidbody2D>().velocity.y);

            if(GetComponent<SpriteRenderer>()!=null)
            {
                GetComponent<SpriteRenderer>().flipX=false;
            }
        }
        
        void Jump()
        {

        GetComponent<Rigidbody2D>().velocity= new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);

        }

    }
    
}
