using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utils.PressedKey;

public class PlayerUI : MonoBehaviour
{
  private const float WALK_SPEED = 6.0f;
  private PlayerController playerController;
  private PlayerDto playerDto;
  public Animator playerAnimator;
  [SerializeField] private HudUI hudUi;
  [SerializeField] private AbilitiesUI abilitiesUi;
  [SerializeField] private RewardUI rewardUI;
  [SerializeField] private QuestLogUI questLogUI;
  [SerializeField] private InventoryUI inventoryUi;
  
  public Sprite spriteMock;

  public bool HasInventorySpace() { return playerController.HasInventorySpace(); }
  private void Walk(float input_x, float input_y)
  {
    var move = new Vector3(input_x, input_y, 0).normalized;
    transform.position += move * WALK_SPEED * Time.deltaTime;
    playerAnimator.SetFloat("input_x", input_x);
    playerAnimator.SetFloat("input_y", input_y);
  }

  private void HandleWalk()
  {
    float input_x = Input.GetAxisRaw("Horizontal");
    float input_y = Input.GetAxisRaw("Vertical");
    bool isWalk = (input_x != 0 || input_y != 0);

    if (isWalk) Walk(input_x, input_y);
    playerAnimator.SetBool("isWalk", isWalk);
  }

  void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.tag == "Item" && HasInventorySpace())
    {
      ItemDto itemCollision = (ItemDto)collision.gameObject.GetComponent<ItemUI>().GetItemDto();
      playerController.AddItem(itemCollision);
      Load();
    }
  }

  void Load()
  {
    playerDto = playerController.GetPlayer();
    hudUi.SetHud(playerDto.playerName, playerDto.levelSystem);
    abilitiesUi.SetAbilitiesUI(playerDto.mathLevelSystem, playerDto.historyLevelSystem);
    inventoryUi.SetInventoryUi(playerDto.inventory, playerDto.coins);
    questLogUI.SetQuestLogUI(playerDto.questLog);
  }

  void Awake()
  {
    // playerController = new PlayerController();
  }

  void Start()
  {
    playerController = new PlayerController();
    Load();
  }

  void Update()
  {
    HandleWalk();
    abilitiesUi.HandleWindow();
    inventoryUi.HandleWindow();

    MokAbilities();
    MockReward();
  }

  // -------------------- MOCKED EVENTS --------------------

  private void MokAbilities()
  {
    if (Pressed.M())
    {
      playerController.AddMathXP(15);
      Load();
    }

    if (Pressed.KeypadPlus())
    {
      playerController.AddHistoryXP(10);
      Load();
    }
  }

  private void MockReward()
  {
    if (Pressed.R() && !rewardUI.IsActive())
    {
      ItemDto itemDto = new ItemDto
      {
        itemId = "d0325f24-2fa7-45a5-bf72-c4e705e4cc81",
        itemName = "Espada",
        sprite = spriteMock
      };
      RewardDto rewardDto = new RewardDto
      {
        coin = 75,
        experience = 17,
        item = itemDto
      };
      if (!rewardUI.IsActive()) rewardUI.Activate();

      rewardUI.SetDeliveryReward(rewardDto);
      RewardDto receivedReward = rewardUI.DeliverReward();
      playerController.ReceiveReward(receivedReward);
      Load();
    }
    if (rewardUI.IsActive() && Pressed.Espcape()) rewardUI.Disable();
  }
}