using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int currentSprite;
    bool isSpriteChanger = false;
    bool FirstTime = false;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentSprite = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
    }

    public void Change()
    {
        isSpriteChanger = true;
        Debug.Log("is Sprite Change to true");
    }
    public void ChangeSprite()
    {

        if (isSpriteChanger && currentSprite < spriteArray.Length)
        {
            spriteRenderer.sprite = spriteArray[currentSprite];
            currentSprite++;
            bool isSpriteChange = false;
            Debug.Log("is Sprite Change to false");
        }

        else if (!isSpriteChanger && !FirstTime)
        {
            Debug.Log("Requirement not fulfill");
            FirstTime = true;
        }
            
    }
}
