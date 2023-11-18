using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody2D body;
    public SpriteRenderer spriteRenderer;
    public List<Sprite> nSprites;
    public List<Sprite> eSprites;
    public List<Sprite> sSprites;
    public List<Sprite> idleSprites;
    public float walkSpeed;
    public float frameRate;
    float idleTime;

    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get direction of input
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        

        // set walk speed based on direction
        body.velocity = direction * walkSpeed;
        
        //handle direction
        HandleSpriteFlip();

        List<Sprite> directionSprites = GetSpriteDirection();

        if(directionSprites != null){
            float playTime = Time.time - idleTime;
            int totalFrames = (int)(playTime * frameRate);
            int frame = (int)(totalFrames % directionSprites.Count);

            spriteRenderer.sprite = directionSprites[frame];

        } else{
            idleTime = Time.time;
        }
    }

    void HandleSpriteFlip(){
        if(!spriteRenderer.flipX && direction.x < 0){
            spriteRenderer.flipX = true;
        } else if (spriteRenderer.flipX && direction.x > 0){
            spriteRenderer.flipX = false;
        }

    }

    List<Sprite> GetSpriteDirection(){

        List<Sprite> selectedSprites = null;

        if (direction.y > 0){
            selectedSprites = nSprites;
        } else if (direction.y < 0){
            selectedSprites = sSprites;
        } else if (direction.x > 0){
            selectedSprites = eSprites;
        } else if (direction.x < 0){
            selectedSprites = eSprites;
        } else{
            //selectedSprites = idleSprites;
        }

        return selectedSprites;
    }
}
