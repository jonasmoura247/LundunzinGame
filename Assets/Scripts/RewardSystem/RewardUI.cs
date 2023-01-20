using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utils.PressedKey;

public class RewardUI : MonoBehaviour
{
  [SerializeField] private SlotUI coinsSlot;
  [SerializeField] private SlotUI experienceSlot;
  [SerializeField] private SlotUI itemSlot;
  private RewardDto deliveryReward;
  public void Activate() { gameObject.SetActive(true); }
  public void Disable() { gameObject.SetActive(false); }
  public bool IsActive() { return gameObject.activeSelf; }
  public void SetDeliveryReward(RewardDto reward){ deliveryReward = reward; }
  public RewardDto DeliverReward(){ return deliveryReward; }
  void Start()
  {
    coinsSlot.SetLabel($"{deliveryReward.coin}");
    experienceSlot.SetLabel($"{deliveryReward.experience}");
    itemSlot.SetSlot(deliveryReward.item);
  }
} 
