// using UnityEngine;
// using UnityEngine.EventSystems;

// public class SaveSlotButton : MonoBehaviour, IPointerClickHandler
// {
//     public int slot;
//     public MainMenuController menu;

//     public void OnPointerClick(PointerEventData eventData)
//     {
//         if (eventData.button == PointerEventData.InputButton.Left)
//         {
//             menu.SaveGame(slot);
//         }

//         if (eventData.button == PointerEventData.InputButton.Right)
//         {
//             menu.LoadGame(slot);
//         }

//         menu.RefreshSaveUI();
//     }
// }