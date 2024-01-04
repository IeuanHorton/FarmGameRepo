using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Animation[] animationList;
    private float timer = 0;
    private int spriteFrame = 0;
    public float animationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // set sprite to first frame
        spriteRenderer.sprite = animationList[0].spriteArray[0];
    }

    // these functions work by checking if a certain amount of time has elapsed and if so, it goes to the next frame and cycles
    void PlayAnimation(string aName)
    {
        Animation animation = animationList[0];
        timer += Time.deltaTime;
        if (timer > animationSpeed)
        {
            spriteRenderer.sprite = animation.spriteArray[(spriteFrame % 4)];
            timer -= animationSpeed;
            spriteFrame = ((spriteFrame + 1) % 4);
        }
    }
}
