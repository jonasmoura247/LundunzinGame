using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class ItemUI : MonoBehaviour
{
  private ItemDto itemDto;
  public string itemId;
  public string itemName;
  public Sprite sprite;

  public ItemDto GetItemDto() { return itemDto; }

  void OnCollisionEnter2D(Collision2D collision)
  {
    bool hasInventorySpace = (bool)collision.gameObject.GetComponent<PlayerUI>().HasInventorySpace();
    if (collision.gameObject.tag == "Player" && hasInventorySpace) { Destroy(gameObject); }
  }

  public void SetItemDto()
  {
    itemDto.itemId = itemId;
    itemDto.itemName = itemName;
    itemDto.sprite = sprite;
  }

  void Awake()
  {
    itemDto = new ItemDto();
  }

  private void Start()
  {
    SetItemDto();
  }
}
