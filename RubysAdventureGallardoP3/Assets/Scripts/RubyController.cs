using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        //New Variable
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Creating the two variables that use the pre built axes
         horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");
    }

     void FixedUpdate()
    {
        //Create the movement vector
        Vector2 position = rigidbody2d.position;

        //Changing the x and y position
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        //Set the updated position
        rigidbody2d.MovePosition(position);
    }
}
