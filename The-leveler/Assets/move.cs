using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{


    public float moveHorizontal;
    public float moveVertical;
    public float speed;
    public Rigidbody2D player;
    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        moveHorizontal = Input.GetAxis("Horizontal") * speed;
        moveVertical = Input.GetAxis("Vertical") * speed;

        movement = new Vector2(moveHorizontal, moveVertical);
        player.velocity = movement * speed;


    }
}
