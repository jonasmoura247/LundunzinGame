using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotUI : MonoBehaviour
{
  private Image image;
  private Text label;

  public void SetItem(ItemDto itemDto) { image.sprite = itemDto.sprite; }
  public void SetLabel(string value) { label.text = value; }
  public void SetSlot(ItemDto itemDto) 
  {
    SetItem(itemDto);
    SetLabel(itemDto.itemName);
  }

  void Awake()
  {
    image = transform.Find("Image").GetComponent<Image>();
    label = transform.Find("Label").GetComponent<Text>();
  }
}
