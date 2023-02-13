using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Crop")]
public class Crop : Item
{
    [SerializeField]
    private CropType type;

    
}

public enum CropType {Fruit, Vegetable}