using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveMissionListUI : MonoBehaviour
{
  public Button mathButton;
  public Button historyButton;
  private List<ActiveMissionDto> activeMissionList;
  [SerializeField] private ActiveChallengeUI activeChallengeUi;

  public void Activate() { gameObject.SetActive(true); }
  public void Disable() { gameObject.SetActive(false); }
  public bool IsActive() { return gameObject.activeSelf; }

  public void SetActiveMissionUI(List<ActiveMissionDto> activeMissionList)
  {
    this.activeMissionList = activeMissionList;
  }

  void OpenActiveChallengeUI(ActiveChallengeDto activeChallengeDto)
  {
    activeChallengeUi.Activate();
    activeChallengeUi.SetActiveChallengeUI(activeChallengeDto);
  }

  void Start()
  {
    ActiveMissionDto mathMission = activeMissionList[0];
    ActiveMissionDto historyMission = activeMissionList[1];

    mathButton.transform.Find("Text").GetComponent<Text>().text = mathMission.missionName;
    historyButton.transform.Find("Text").GetComponent<Text>().text = historyMission.missionName;

    mathButton.onClick.AddListener(() => OpenActiveChallengeUI(mathMission.activeChallenge));
    historyButton.onClick.AddListener(() => OpenActiveChallengeUI(historyMission.activeChallenge));
  }

  void Awake()
  {
    Disable();
  }
}
