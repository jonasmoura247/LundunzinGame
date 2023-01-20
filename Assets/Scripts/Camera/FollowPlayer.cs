using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  public PlayerUI playerUi;
  public Vector3 distanceOfPlayer;

  void Update()
  {
    this.transform.position = playerUi.transform.position + distanceOfPlayer;
  }
}