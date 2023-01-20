using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utils.GameConstants;
using Utils.PressedKey;

public class InstructionUI : MonoBehaviour
{
  public GameObject instructionUI;
  private Text characterName;
  private Text sentence;
  private IEnumerator printSentenceSlowly;
  private bool isPrintSentenseSlowly = false;


  public string npcName;
  public List<string> sentenceList;
  private int sentenceIndex = 0;


  public void SetCharacterName(string name) { this.characterName.text = name; }
  public void ClearSentence() { this.sentence.text = ""; }
  public void SetSentence(string sentence) { this.sentence.text = sentence; }

  IEnumerator PrintSentenceSlowly(string sentence)
  {
    isPrintSentenseSlowly = true;
    ClearSentence();
    foreach (char letter in sentence.ToCharArray())
    {
      this.sentence.text += letter;
      yield return new WaitForSeconds(Const.SENTENCE_SPEED);
    }
    isPrintSentenseSlowly = false;
  }

  public void PrintSentence()
  {
    printSentenceSlowly = PrintSentenceSlowly(sentenceList[sentenceIndex]);
    StartCoroutine(printSentenceSlowly);
  }

  public void PrintNextSentence()
  {
    StopAllCoroutines();
    sentenceIndex++;
    PrintSentence();
  }

  public bool IsActive() { return this.instructionUI.activeSelf; }
  public void Activate() { this.instructionUI.SetActive(true); }
  public void Disable() { this.instructionUI.SetActive(false); }
  public void AcceleratePrintSentence()
  {
    StopAllCoroutines();
    SetSentence(sentenceList[sentenceIndex]);
    isPrintSentenseSlowly = false;
  }

  private void Awake()
  {
    characterName = transform.Find("CharacterName").GetComponent<Text>();
    sentence = transform.Find("InstructionText").GetComponent<Text>();
  }

  private void Start()
  {
    SetCharacterName(npcName);
  }

  void OnEnable()
  {
    sentenceIndex = 0;
    PrintSentence();
  }

  void OnDisable()
  {
    StopAllCoroutines();
    sentenceIndex = 0;
  }

  void Update()
  {
    bool isPrintedSentenceList = (sentenceIndex == (sentenceList.Count - 1));
    if (Pressed.Space() && isPrintSentenseSlowly) AcceleratePrintSentence();
    else if (Pressed.Space() && !isPrintSentenseSlowly && !isPrintedSentenceList) PrintNextSentence();
  }
}
