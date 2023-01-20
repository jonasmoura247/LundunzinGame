using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerFactory;


public class PlayerService
{
  private LocalStorageService localStorageService;
  private Player player;
  private PlayerDto playerDto;

  public PlayerService()
  {
    localStorageService = new LocalStorageService(GameEntity.player);
    playerDto = GetPlayer();
    player = new Player();
    player.SetPlayer(playerDto);
  }

  public PlayerDto GetPlayer() { return localStorageService.Get<PlayerDto>(); }

  private void AddExperience(int experience)
  {
    player.GainXp(experience/2);
  }
  public void AddMathXP(int experience)
  {
    player.GainMathXP(experience);
    AddExperience(experience);
    Refresh();
  }
  public void AddHistoryXP(int experience)
  {
    player.GainHistoryXP(experience);
    AddExperience(experience);
    Refresh();
  }
  public void AddItem(ItemDto itemDto)
  {
    if(HasInventorySpace()) { player.GainItem(itemDto); }
    else Debug.Log("INVENTORY IS FULL!");
    Refresh();
  }

  public void AddCoins(int coins)
  {
    player.GainCoins(coins);
    Refresh();
  }

  public void ReceiveReward(RewardDto rewardDto)
  {
    AddCoins(rewardDto.coin);
    AddExperience(rewardDto.experience);
    AddItem(rewardDto.item);
    Refresh();
  }

  public bool HasInventorySpace() { return player.HasInventorySpace(); }
  private void Load() { playerDto = GetPlayer(); }

  private void Save()
  {
    playerDto = Factory.PlayerDto(player);
    localStorageService.Post<PlayerDto>(playerDto);
  }

  private void Refresh()
  {
    Save();
    Load();
  }
}
