using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Player
{
  private string playerId;
  private string playerName;
  private LevelSystem levelSystem;
  private LevelSystem historyLevelSystem;
  private LevelSystem mathLevelSystem;

  private Inventory inventory;
  private int coins;
  private QuestLog questLog;

  public Player()
  {
    levelSystem = new LevelSystem();
    mathLevelSystem = new LevelSystem();
    historyLevelSystem = new LevelSystem();
    inventory = new Inventory();
    questLog = new QuestLog();
  }

  public void SetPlayer(PlayerDto playerDto)
  {
    SetId(playerDto.playerId);
    SetName(playerDto.playerName);
    SetLevelSystem(playerDto.levelSystem.level, playerDto.levelSystem.experience);
    SetMathLevelSystem(playerDto.mathLevelSystem.level, playerDto.mathLevelSystem.experience);
    SetHistoryLevelSystem(playerDto.historyLevelSystem.level, playerDto.historyLevelSystem.experience);
    SetCoins(playerDto.coins);
    inventory.SetItemList(playerDto.inventory.items);
    SetQuestLog(playerDto.questLog);
  }

  public void SetId(string id) { playerId = id; }
  public void SetName(string name) { playerName = name; }
  public void SetLevelSystem(int level, int experience)
  {
    this.levelSystem.SetLevelSystem(level, experience);
  }
  public void SetMathLevelSystem(int level, int experience)
  {
    this.mathLevelSystem.SetLevelSystem(level, experience);
  }
  public void SetHistoryLevelSystem(int level, int experience)
  {
    this.historyLevelSystem.SetLevelSystem(level, experience);
  }
  private void SetCoins(int coins) { this.coins = coins; }
  private void SetQuestLog(QuestLogDto questLog) { this.questLog.SetQuestLog(questLog); }

  public string GetId() { return this.playerId; }
  public string GetName() { return this.playerName; }
  public LevelSystem GetLevelSystem() { return levelSystem; }
  public LevelSystem GetMathLevelSystem() { return mathLevelSystem; }
  public LevelSystem GetHistoryLevelSystem() { return historyLevelSystem; }
  public Inventory GetInventory() { return inventory; }
  public int GetCoins() { return coins; }
  public QuestLog GetQuestLog() { return questLog; }
  public void GainXp(int xp) { levelSystem.AddExperience(xp); }
  public void GainMathXP(int xp) { mathLevelSystem.AddExperience(xp); }
  public void GainHistoryXP(int xp) { historyLevelSystem.AddExperience(xp); }
  public void GainItem(ItemDto itemDto) { inventory.AddItem(itemDto); }
  public void GainCoins(int coins) { this.coins += coins; }
  public bool HasInventorySpace() { return inventory.HasEmptySlot(); }
}
