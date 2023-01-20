using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestionDto
{
  public string questionId;
  public string statement;
  public List<OptionDto> optionList; 
}
