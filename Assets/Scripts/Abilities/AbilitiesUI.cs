using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utils.PressedKey;


public class AbilitiesUI : MonoBehaviour
{
  private MathLevelSystemUI mathLevelSystemUi;
  private HistoryLevelSystemUI historyLevelSystemUi;
  private LevelSystemDto mathLevelSystemDto;
  private LevelSystemDto historyLevelSystemDto;

  public void Activate() { gameObject.SetActive(true); }
  public void Disable() { gameObject.SetActive(false); }
  public bool IsActive() { return gameObject.activeSelf; }

  public void HandleWindow()
  {
    if (!IsActive() && Pressed.H()) { Activate(); }
    else if (IsActive() && Pressed.H()) { Disable(); }
  }

  public void SetAbilitiesUI(LevelSystemDto mathLevelSystem, LevelSystemDto historyLevelSystem)
  {
    SetMathLevelSystem(mathLevelSystem);
    SetHistoryLevelSystem(historyLevelSystem);
  }

  public void SetMathLevelSystem(LevelSystemDto levelSystem)
  {
    mathLevelSystemDto = levelSystem;
  }
  public void SetHistoryLevelSystem(LevelSystemDto levelSystem)
  {
    historyLevelSystemDto = levelSystem;
  }

  void Update()
  {
    mathLevelSystemUi.SetLevelSystem(mathLevelSystemDto);
    historyLevelSystemUi.SetLevelSystem(historyLevelSystemDto);
  }

  void Start()
  {
    mathLevelSystemUi = transform.Find("MathLevelSystemUI").GetComponent<MathLevelSystemUI>();
    historyLevelSystemUi = transform.Find("HistoryLevelSystemUI").GetComponent<HistoryLevelSystemUI>();
  }

  void Awake()
  {
    Disable();
  }
}
