using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotContainerUI : MonoBehaviour
{
  private List<SlotUI> slotList;
  private const int SLOT_AMOUNT = 16;

  public void SetSlotList(List<ItemDto> itemList)
  {
    for (int i = 0; i < itemList.Count; i++)
    {
      slotList[i].SetSlot(itemList[i]);
    }
  }

  void Awake()
  {
    // slotList = new List<SlotUI>(SLOT_AMOUNT);
    // for (int indice = 0; indice < SLOT_AMOUNT; indice++)
    // {
    //   string slotName = $"Slot_{indice}";
    //   slotList.Add(GetComponent<SlotUI>());
    //   slotList[indice] = transform.Find(slotName).GetComponent<SlotUI>();
    // }
  }

  private void Start()
  {
    slotList = new List<SlotUI>(SLOT_AMOUNT);
    for (int indice = 0; indice < SLOT_AMOUNT; indice++)
    {
      string slotName = $"Slot_{indice}";
      slotList.Add(GetComponent<SlotUI>());
      slotList[indice] = transform.Find(slotName).GetComponent<SlotUI>();
    }
  }
}
