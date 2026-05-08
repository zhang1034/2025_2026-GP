// using UnityEngine;
// using Ink.Runtime;
// using TMPro;
// using UnityEngine.UI;
// using System.Collections.Generic;

// public class InkManager : MonoBehaviour
// {
//     public TextAsset inkJSON;
//     public GameObject dialogue;
//     public TextMeshProUGUI dialogueText;
//     public TextMeshProUGUI nameText;
//     public Image portraitImage;

//     private Story story;

//     [Header("list of character")]
//     public CharacterData ION;
//     public CharacterData MITTEN;

//     Dictionary<string, CharacterData> characterMap;

//     void Start()
//     {
//         characterMap = new Dictionary<string, CharacterData>
//         {
//             { "ION", ION },
//             { "MITTEN", MITTEN }
//         };
//     }

//     public void StartStory()
//     {
//         story = new Story(inkJSON.text);
//         ContinueStory();
//     }

//     void Update()
//     {
//         if (story == null) return;

//         if (UnityEngine.InputSystem.Mouse.current.rightButton.wasPressedThisFrame)
//         {
//             ContinueStory();
//         }
//     }

//     public void ContinueStory()
//     {
//         if (story.canContinue)
//         {
//             string text = story.Continue();

//             string speaker = GetSpeakerFromTags();

//             ShowDialogue(speaker, text);
//         }
//         else
//         {
//             EndStory();
//         }
//     }

//     string GetSpeakerFromTags()
//     {
//         foreach (string tag in story.currentTags)
//         {
//             if (tag.StartsWith("speaker:"))
//             {
//                 return tag.Replace("speaker:", " ").Trim();
//             }
//         }
//         return "ION";
//     }

//     void ShowDialogue(string speaker, string text)
//     {
//         dialogueText.text = text;

//         if (characterMap.ContainsKey(speaker))
//         {
//             nameText.text = characterMap[speaker].name;
//             portraitImage.sprite = characterMap[speaker].portrait;
//         }
//     }

//     void EndStory()
//     {
//         dialogue.SetActive(false);
//         story = null;
//     }

//     public void SkipStory()
//     {
//         if (story == null) return;

//         EndStory();
//     }
// }