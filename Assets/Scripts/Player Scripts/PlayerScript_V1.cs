using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript_V1 : MonoBehaviour
{
    //Variables
    [SerializeField]
    private float z_MoveSpeed;
    private BoxCollider2D z_BoxCollider;

    //Methods

    private void Start()
    {
        //fetches the boxcollider component
        z_BoxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement() //directional
    {
        //get input x,y
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        //cache it in a vector
        //how much value you want to apply for the movement
        Vector2 moveDelta = new Vector2(moveX, moveY);

        //flip the player according to move direction
        //works in scale, we can check moveDelta or X value
        if (moveDelta.x > 0) //going right
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveDelta.x <0) //going left
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


        //Collision check
        RaycastHit2D castResult;
        castResult = Physics2D.BoxCast(transform.position,z_BoxCollider.size,0,new Vector2(moveX,0),Mathf.Abs(moveX * Time.deltaTime),LayerMask.GetMask("Collision"));


        //Apply the movement after the previous check
    }


}
