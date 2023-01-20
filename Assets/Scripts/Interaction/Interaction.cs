using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Interaction
{
  private List<Instruction> instructionList;

  public Interaction(string name, string description)
  {
    this.instructionList = new List<Instruction>();
  }

  public void SetInstructionList(Instruction[] instructionList)
  {
    foreach(Instruction instruction in instructionList) { this.instructionList.Add(instruction); }
  }

  public List<Instruction> GetInstructionList() { return this.instructionList; }
}
