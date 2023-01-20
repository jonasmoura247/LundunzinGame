using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionUI : MonoBehaviour
{
  [SerializeField] private InstructionUI instructionUI;

  public bool IsActive() { return instructionUI.IsActive(); }

  public void Activate() { instructionUI.Activate(); }

  public void Disable() { instructionUI.Disable(); }
}
