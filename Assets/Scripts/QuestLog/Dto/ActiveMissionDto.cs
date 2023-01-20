using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ActiveMissionDto
{
  public string missionId;
  public string missionName;
  public string description;
  public ActiveChallengeDto activeChallenge;
}