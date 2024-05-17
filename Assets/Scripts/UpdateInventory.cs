using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateInventory : MonoBehaviour
{
    public Image[] inventorySlots; 

    public void SetInventoryImage(Sprite itemSprite) {
        foreach (Image slot in inventorySlots) {
            if (!slot.enabled) 
            {
                slot.enabled = true; 
                slot.sprite = itemSprite; 
                return; 
            }
        }
    }
}
