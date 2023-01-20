using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HistoryLevelSystemUI : MonoBehaviour
{
  private Text levelValue;
  private Slider experienceBar;
  private Text experienceValue;

  public void SetLevelSystem(LevelSystemDto levelSystem)
  {
    SetLevel(levelSystem.level);
    SetExperience(levelSystem.experience);
  }

  private void SetLevel(int value) { levelValue.text = $"{value}"; }
  private void SetExperience(int value)
  {
    experienceBar.value = value;
    experienceValue.text = $"{value} %";
  }
  void Awake()
  {
    levelValue = transform.Find("LevelValue").GetComponent<Text>();
    experienceBar = transform.Find("ExperienceBar").GetComponent<Slider>();
    experienceValue = transform.Find("ExperienceValue").GetComponent<Text>();
  }
}
