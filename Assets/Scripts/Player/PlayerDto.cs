using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerDto
{
  public string playerId;
  public string playerName;
  public int coins;
  public LevelSystemDto levelSystem;
  public LevelSystemDto mathLevelSystem;
  public LevelSystemDto historyLevelSystem;
  public InventoryDto inventory;
  public QuestLogDto questLog;
}
