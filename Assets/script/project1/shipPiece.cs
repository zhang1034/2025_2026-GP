// using UnityEngine;

// public class ShipPart : MonoBehaviour
// {
//     void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             plyaercontroller player = other.GetComponent<plyaercontroller>();

//             if (player != null)
//             {
//                 player.currentParts++;
//                 Debug.Log("Collected part: " + player.currentParts);

//                 Destroy(gameObject);
//             }
//         }
//     }
// }