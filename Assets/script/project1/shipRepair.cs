// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.InputSystem;
// using UnityEngine.SceneManagement;
// using TMPro;

// public class ShipRepair : MonoBehaviour
// {
//     public GameObject repairUI;
//     private plyaercontroller player;
//     public TMPro.TextMeshProUGUI partText;
//     public SpriteRenderer targetRenderer;
//     public Sprite repairedSprite;

//     void Update()
//     {
//         if (player != null)
//         {
//             partText.text = player.currentParts + " / " + player.requiredParts;
//         }
//     }

//     void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             player = other.GetComponent<plyaercontroller>();

//             repairUI.SetActive(true);
//         }
//     }

//     void OnTriggerExit2D(Collider2D other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             repairUI.SetActive(false);
//             player = null;
//         }
//     }

//     public void Repair()
//     {
//         if (player.currentParts >= player.requiredParts)
//         {
//             Debug.Log("Ship repaired!");
//             targetRenderer.sprite = repairedSprite;
//             repairUI.SetActive(false);
//             plyaercontroller.Active(true);
//         }
//         else
//         {
//             Debug.Log("Not enough parts!");
//         }
//     }
// }