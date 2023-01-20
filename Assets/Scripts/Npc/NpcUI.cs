using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utils.PressedKey;
using Utils.GameConstants;

public class NpcUI : MonoBehaviour
{
  public string npcName;
  [SerializeField] private InteractionUI interactionUI;
  public LayerMask playerLayer;
  private bool onRadious;

  void Update()
  {
    Interact();
  }

  private bool IsActiveInteraction() { return interactionUI.IsActive(); }
  private bool IsOnRadius() { return (Physics2D.OverlapCircle(transform.position, Const.NPC_RADIUS, playerLayer) != null); }
  private bool IsInteractionStarted() { return (!interactionUI.IsActive() && (IsOnRadius() && Pressed.Space())); }
  private bool IsInteractionFinished() { return (interactionUI.IsActive() && (!IsOnRadius() || Pressed.Espcape())); }

  public void Interact()
  {
    if (IsInteractionStarted()) interactionUI.Activate();
    if (IsInteractionFinished()) interactionUI.Disable();
  }

}
