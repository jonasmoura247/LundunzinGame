using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudUI : MonoBehaviour
{
  private Text playerName;
  private Text levelValue;
  private Slider experienceBar;
  private Text experienceValue;

  public void SetHud(string playerName, LevelSystemDto levelSystem)
  {
    SetPlayerName(playerName);
    SetLevel(levelSystem.level);
    SetExperience(levelSystem.experience);
  }

  private void SetPlayerName(string name) { playerName.text = name; }
  private void SetLevel(int value) { levelValue.text = $"{value}"; }
  private void SetExperience(int value)
  {
    experienceBar.value = value;
    experienceValue.text = $"{value} %";
  }

  void Awake()
  {
    playerName = transform.Find("PlayerName").GetComponent<Text>();
    levelValue = transform.Find("LevelValue").GetComponent<Text>();
    experienceBar = transform.Find("ExperienceBar").GetComponent<Slider>();
    experienceValue = transform.Find("ExperienceValue").GetComponent<Text>();
  }
}
