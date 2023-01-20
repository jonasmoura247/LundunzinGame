using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsUI : MonoBehaviour
{
  private Button exitButton;

  void Awake() 
  {    
    exitButton = transform.Find("ExitButton").GetComponent<Button>();
  }

  void Start()
  {
    exitButton.onClick.AddListener(() => SceneManager.LoadScene("StartMenu"));
  }
}

