using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
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
            PlayAnimation(AnimationStart.Up);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            PlayAnimation(AnimationStart.Left);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            PlayAnimation(AnimationStart.Down);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            PlayAnimation(AnimationStart.Right);
        }

        // if a key is released, we put the sprite into its last stable frame
        if (Input.GetKeyUp(KeyCode.W))
        {
            spriteRenderer.sprite = spriteArray[(int)AnimationStart.Up];
            spriteFrame = 0;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            spriteRenderer.sprite = spriteArray[(int)AnimationStart.Left];
            spriteFrame = 0;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            spriteRenderer.sprite = spriteArray[(int)AnimationStart.Down];
            spriteFrame = 0;

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            spriteRenderer.sprite = spriteArray[(int)AnimationStart.Right];
            spriteFrame = 0;
        }
    }

    // these functions work by checking if a certain amount of time has elapsed and if so, it goes to the next frame and cycles
    void PlayAnimation(AnimationStart aStart)
    {
        int start = (int)aStart;
        timer += Time.deltaTime;
        if (timer > animationSpeed)
        {
            spriteRenderer.sprite = spriteArray[(spriteFrame % 4) + start];
            timer -= animationSpeed;
            spriteFrame = ((spriteFrame + 1) % 4) + start;
        }
    }
}

enum AnimationStart : int
{
    //These animations only have 4 frames
    Down = 0,
    Up = 4,
    Right = 8,
    Left = 12
}