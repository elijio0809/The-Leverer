using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class front_Behind : MonoBehaviour
{
    public Rigidbody2D player;
    public Rigidbody2D lever;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y > lever.transform.position.y){
            player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y, 2);
        } else if(player.transform.position.y < lever.transform.position.y){
            player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y, 0);
        }
    }
}
