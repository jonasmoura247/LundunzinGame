using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
  private const int INVENTORY_SPACES = 16;
  public List<ItemDto> itemList;

  public Inventory() { itemList = new List<ItemDto>(); }
  public void SetItemList(List<ItemDto> itemList) { this.itemList = itemList; }
  public void AddItem(ItemDto item) { itemList.Add(item); }
  public void RemoveItem(ItemDto item) { itemList.Remove(item); }
  public List<ItemDto> GetItemList() { return itemList; }
  public bool HasEmptySlot() { return itemList.Count < INVENTORY_SPACES; }
}
