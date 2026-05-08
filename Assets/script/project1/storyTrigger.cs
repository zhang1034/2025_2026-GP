// using UnityEngine;

// public class StoryTrigger : MonoBehaviour
// {
//     public GameObject dialogue;
//     public InkManager inkManager;

//     void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             dialogue.SetActive(true);

//             if (inkManager != null)
//             {
//                 inkManager.StartStory();
//             }
//         }
//     }
// }