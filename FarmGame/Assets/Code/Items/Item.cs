using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    [SerializeField]
    new private string name = "New Name";
    [SerializeField]
    private Sprite icon = null;
    [SerializeField]
    private int worth = 0;

    //When the player double left clicks on the object
    public virtual void Use()
    {

    }

    public void changeWorth(int x)
    {
        worth = x;
    }
}
