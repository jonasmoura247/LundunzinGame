using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils.PressedKey;

public class QuestLogUI : MonoBehaviour
{
  private ActiveMissionListUI activeMissionListUi;
  private ActiveChallengeUI activeChallengeUi;

  public void Activate() { gameObject.SetActive(true); }
  public void Disable() { gameObject.SetActive(false); }
  public bool IsActive() { return gameObject.activeSelf; }

  private void HandleActiveWindows()
  {
    if (Pressed.J() && !activeMissionListUi.IsActive()) { activeMissionListUi.Activate(); }
    else if (Pressed.J() && activeMissionListUi.IsActive())
    {
      activeMissionListUi.Disable();
      activeChallengeUi.Disable();
    }
  }

  public void SetQuestLogUI(QuestLogDto questLogDto)
  {
    activeMissionListUi.SetActiveMissionUI(questLogDto.activeMissionList);
  }


  void Update()
  {
    HandleActiveWindows();
  }

  void Awake()
  {
    activeMissionListUi = transform.Find("ActiveMissionListUI").GetComponent<ActiveMissionListUI>();
    activeChallengeUi = transform.Find("ActiveChallengeUI").GetComponent<ActiveChallengeUI>();
  }
}
