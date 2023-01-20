using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc
{
  private List<Interaction> interactionList;

  public Npc(string name, string description)
  {
    this.interactionList = new List<Interaction>();
  }

  public void SetInteractionList(List<Interaction> interactionList)
  {
    foreach (Interaction interaction in interactionList) { this.interactionList.Add(interaction); }
  }

  public List<Interaction> GetInteractionList() { return this.interactionList; }
}
