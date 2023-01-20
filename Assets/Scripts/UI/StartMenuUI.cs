using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuUI : MonoBehaviour
{
  private Button playButton;
  [SerializeField] private LoadingUI loadingUi;

  void Awake()
  {
    playButton = transform.Find("PlayButton").GetComponent<Button>();
  }
  void Start()
  {
    playButton.onClick.AddListener(() => loadingUi.LoadScene("Central"));
  }
}
