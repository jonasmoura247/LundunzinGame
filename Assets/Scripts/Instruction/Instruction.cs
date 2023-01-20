using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instruction
{
  private List<string> sentenceList;

  public Instruction(string name, string description)
  {
    this.sentenceList = new List<string>();
  }

  public void SetSentences(string[] sentences)
  {
    foreach (string sentence in sentences) { this.sentenceList.Add(sentence); }
  }

  public List<string> GetSentences() { return this.sentenceList; }
}
