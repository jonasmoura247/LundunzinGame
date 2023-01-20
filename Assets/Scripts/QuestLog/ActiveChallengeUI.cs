using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveChallengeUI : MonoBehaviour
{
  private Text challengeName;
  private Text challengeDescription;

  public void Activate() { gameObject.SetActive(true); }
  public void Disable() { gameObject.SetActive(false); }

  public void SetActiveChallengeUI(ActiveChallengeDto activeChallenge)
  {
    challengeName.text = activeChallenge.challengeName;
    challengeDescription.text = $"Descrição:\n{activeChallenge.description}";
  }

  void Awake()
  {
    Disable();
    challengeName = transform.Find("ChallengeName").GetComponent<Text>();
    challengeDescription = transform.Find("ChallengeDescription").GetComponent<Text>();
  }
}
