using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int currentSprite;
    public string injuryName;
    public bool AdminSetting;
    bool isSpriteChanger = false;
    bool FirstTime = false;
    private Dictionary<string, bool> injuries = new Dictionary<string, bool>();
    // Start is called before the first frame update
    void Start()
    {
        GameObject ir = GameObject.Find("InfoRecorder");
        injuries = ir.GetComponent<InfoToBeBroughtOver>().getInjuries();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentSprite = 0;
        AdminSetting = injuries[injuryName];
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
            isSpriteChanger = false;
            Debug.Log("is Sprite Change to false");
        }

        else if(AdminSetting && currentSprite < spriteArray.Length )
        {
            currentSprite++;
            spriteRenderer.sprite = spriteArray[currentSprite];
            AdminSetting = false;
            isSpriteChanger = false;
            Debug.Log("is Sprite Change to false");
        }

        else if (!isSpriteChanger && !FirstTime)
        {
            Debug.Log("Requirement not fulfill");
            FirstTime = true;
        }
            
    }
}
