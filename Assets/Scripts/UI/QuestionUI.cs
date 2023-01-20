using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utils.PressedKey;

public class QuestionUI : MonoBehaviour
{
  private const int AMOUNT_OPTIONS = 4;
  private Text statement;
  private List<Button> optionList;

  private bool optionResult;

  public void Activate() { gameObject.SetActive(true); }
  public void Disable() { gameObject.SetActive(false); }
  public bool IsActive() { return gameObject.activeSelf; }

  private void ReferenceButtonList()
  {
    optionList = new List<Button>(AMOUNT_OPTIONS);
    for (int indice = 0; indice < AMOUNT_OPTIONS; indice++)
    {
      optionList.Add(transform.Find($"Option_{indice}").GetComponent<Button>());
      optionList[indice].gameObject.SetActive(false);
    }
  }

  private void SetStatement(string statement) { this.statement.text = statement; }
  private void SetOptionList(List<OptionDto> optionListDto)
  {
    for (int indice = 0; indice < optionListDto.Count; indice++)
    {
      optionList[indice].gameObject.SetActive(true);
      optionList[indice].transform.Find("Text").GetComponent<Text>().text = optionListDto[indice].value;

      if (optionListDto[indice].isCorrect)
      {
        optionList[indice].onClick.AddListener(() => CorrectOption());
      }
      else
      {
        optionList[indice].onClick.AddListener(() => IncorrectOption());
      }
    }
  }

  public void SetQuestionUI(QuestionDto questionDto)
  {
    SetStatement(questionDto.statement);
    SetOptionList(questionDto.optionList);
  }

  public void HandleWindow()
  {
    if (Pressed.Q() && !IsActive()) { Activate(); }
    else if (Pressed.Q() && IsActive()) { Disable(); }
  }

  void Awake()
  {
    statement = transform.Find("Statement").GetComponent<Text>();
    // ReferenceButtonList();
    Disable();
  }

  private void Start()
  {
    ReferenceButtonList();
  }

  public void CorrectOption()
  {
    Debug.Log("CORRETO!!!");
  }

  public void IncorrectOption()
  {
    Debug.Log("ERROUUUUU!!!");
  }
}
