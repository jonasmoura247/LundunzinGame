using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Utils.PressedKey;


public class InventoryUI : MonoBehaviour
{
  [SerializeField] private SlotContainerUI slotContainerUi;
  private Text coinsValue;
  private InventoryDto inventoryDto;
  private int coins;


  public void Activate() { gameObject.SetActive(true); }
  public void Disable() { gameObject.SetActive(false); }
  public bool IsActive() { return gameObject.activeSelf; }


  public void SetCoinsValue(int value)
  {
    this.coinsValue.text = $"$ {value}";
  }

  public void SetInventoryUi(InventoryDto inventoryDto, int coins)
  {
    this.inventoryDto = inventoryDto;
    this.coins = coins;
  }

  public void HandleWindow()
  {
    if (Pressed.I() && !IsActive()) { Activate(); }
    else if (Pressed.I() && IsActive()) { Disable(); }
  }

  void Update()
  {
    if (IsActive())
    {
      slotContainerUi.SetSlotList(inventoryDto.items);
      SetCoinsValue(coins);
    }
  }

  void Awake()
  {
    coinsValue = transform.Find("CoinsValue").GetComponent<Text>();
  }
}
