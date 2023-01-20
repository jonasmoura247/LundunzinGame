using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController
{
  private PlayerService playerService;

  public PlayerController() { playerService = new PlayerService(); }
  public PlayerDto GetPlayer() { return playerService.GetPlayer(); }
  public void AddMathXP(int experience) { playerService.AddMathXP(experience); }
  public void AddHistoryXP(int experience) { playerService.AddHistoryXP(experience); }
  public void AddItem(ItemDto itemDto) { playerService.AddItem(itemDto); }
  public void AddCoins(int coins) { playerService.AddCoins(coins); }
  public bool HasInventorySpace() { return playerService.HasInventorySpace(); }
  public void ReceiveReward(RewardDto rewardDto) { playerService.ReceiveReward(rewardDto); }
}
