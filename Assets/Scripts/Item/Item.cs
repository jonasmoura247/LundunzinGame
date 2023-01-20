using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
  private string itemId;
  private string itemName;
  public Sprite sprite;

  public Item(ItemDto itemDto)
  {
    SetId(itemDto.itemId);
    SetName(itemDto.itemName);
    SetSprite(itemDto.sprite);
  }

  public void SetId(string id) { itemId = id; }
  public void SetName(string name) { itemName = name; }
  public void SetSprite(Sprite sprite)
  {
    this.sprite = sprite;
  }
}
