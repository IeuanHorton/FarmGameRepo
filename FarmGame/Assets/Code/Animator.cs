using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    private float timer = 0;
    private int spriteFrame = 0;
    public float animationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        // set sprite to first frame
        spriteRenderer.sprite = spriteArray[0];
    }

    // Update is called once per frame
    void Update()
    {
        // if a key is being held down we play an animation
        if (Input.GetKey(KeyCode.W))
        {
            playUpAnimation();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playLeftAnimation();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playDownAnimation();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playRightAnimation();
        }
        
        // if a key is released, we put the sprite into its last stable frame
        if (Input.GetKeyUp(KeyCode.W))
        {
            spriteRenderer.sprite = spriteArray[4];
            spriteFrame = 0;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            spriteRenderer.sprite = spriteArray[12];
            spriteFrame = 0;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            spriteRenderer.sprite = spriteArray[0];
            spriteFrame = 0;

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            spriteRenderer.sprite = spriteArray[8];
            spriteFrame = 0;
        }
    }

    // these functions work by checking if a certain amount of time has elapsed and if so, it goes to the next frame and cycles
    void playLeftAnimation()
    {
        timer += Time.deltaTime;
        if (timer > animationSpeed)
        {
            spriteRenderer.sprite = spriteArray[(spriteFrame % 4) + 12];
            timer -= animationSpeed;
            spriteFrame = ((spriteFrame + 1) % 4) + 12;
        }
    }

    void playRightAnimation()
    {
        timer += Time.deltaTime;
        if (timer > animationSpeed)
        {
            spriteRenderer.sprite = spriteArray[(spriteFrame % 4) + 8];
            timer -= animationSpeed;
            spriteFrame = ((spriteFrame + 1) % 4) + 8;
        }
    }

    void playUpAnimation()
    {
        timer += Time.deltaTime;
        if (timer > animationSpeed)
        {
            spriteRenderer.sprite = spriteArray[(spriteFrame % 4) + 4];
            timer -= animationSpeed;
            spriteFrame = ((spriteFrame + 1) % 4) + 4;
        }
    }

    void playDownAnimation()
    {
        timer += Time.deltaTime;
        if (timer > animationSpeed)
        {
            spriteRenderer.sprite = spriteArray[(spriteFrame % 4) + 0];
            timer -= animationSpeed;
            spriteFrame = ((spriteFrame + 1) % 4) + 0;
        }
    }
}
