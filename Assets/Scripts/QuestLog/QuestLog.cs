using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLog
{
  private List<ActiveMissionDto> activeMissionList;

  public QuestLog()
  {
    activeMissionList = new List<ActiveMissionDto>();
  }

  public void SetQuestLog(QuestLogDto questLog)
  {
    this.activeMissionList = questLog.activeMissionList;
  }

  public List<ActiveMissionDto> GetActiveMissionList() { return activeMissionList; }
}
