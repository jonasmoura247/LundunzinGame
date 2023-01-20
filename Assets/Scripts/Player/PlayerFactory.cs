using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerFactory
{
  public static class Factory
  {
    public static LevelSystemDto LevelSystemDto(LevelSystem ls)
    {
      return new LevelSystemDto
      {
        level = ls.GetLevel(),
        experience = ls.GetExperience()
      };
    }

    public static InventoryDto InventoryDto(Inventory inventory)
    {
      return new InventoryDto { items = inventory.GetItemList() };
    }

    public static QuestLogDto QuestLogDto(QuestLog questLog)
    {
      return new QuestLogDto { activeMissionList = questLog.GetActiveMissionList() };
    }

    public static PlayerDto PlayerDto(Player p)
    {
      return new PlayerDto
      {
        playerId = p.GetId(),
        playerName = p.GetName(),
        coins = p.GetCoins(),
        levelSystem = LevelSystemDto(p.GetLevelSystem()),
        mathLevelSystem = LevelSystemDto(p.GetMathLevelSystem()),
        historyLevelSystem = LevelSystemDto(p.GetHistoryLevelSystem()),
        inventory = InventoryDto(p.GetInventory()),
        questLog = QuestLogDto(p.GetQuestLog())
      };
    }
  }
}

