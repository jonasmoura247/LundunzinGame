using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelSystem
{
  private const int MAX_EXPERIENCE = 100;
  private const int MIN_EXPERIENCE = 0;
  private const int INITIAL_LEVEL = 1;
  private int level;
  private int experience;
  public event EventHandler OnExperienceChanged;
  public event EventHandler OnLevelChanged;

  public LevelSystem()
  {
    level = INITIAL_LEVEL;
    experience = MIN_EXPERIENCE;
  }

  public void SetLevelSystem(int level, int experience)
  {
    SetLevel(level);
    SetExperience(experience);
  }

  public void SetLevel(int level) { this.level = level; }
  public void SetExperience(int experience) { this.experience = experience; }
  public int GetLevel() { return level; }
  public int GetExperience() { return experience; }


  public void AddExperience(int amount)
  {
    experience += amount;
    if (experience >= MAX_EXPERIENCE)
    {
      level++;
      experience -= MAX_EXPERIENCE;
      if (OnLevelChanged != null) OnLevelChanged(this, EventArgs.Empty);
    }
    if (OnExperienceChanged != null) OnExperienceChanged(this, EventArgs.Empty);
  }
}
