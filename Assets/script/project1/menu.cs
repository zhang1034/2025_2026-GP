// using UnityEngine;
// using UnityEngine.InputSystem;
// using UnityEngine.SceneManagement;

// public class MainMenuController : MonoBehaviour
// {

//     public GameObject startMenu;
//     public GameObject pauseMenu;
//     public GameObject gameOverMenu;
//     public GameObject audioPanel;
//     public GameObject creditsPanel;
//     public GameObject savePanel;
//     public GameObject status;
//     public plyaercontroller player;
//     public TMPro.TextMeshProUGUI slot1Text;
//     public TMPro.TextMeshProUGUI slot2Text;
//     public TMPro.TextMeshProUGUI slot3Text;
//     public GameObject repairUI;
//     public TMPro.TextMeshProUGUI partText;
//     public SpriteRenderer targetRenderer;
//     public Sprite repairedSprite;

//     bool isPaused = false;

//     void Start()
//     {
//         ClearAllSaves();
//     }

//     void Update()
//     {
//         if (Keyboard.current.escapeKey.wasPressedThisFrame)
//         {
//             TogglePause();
//         }

//         if (player != null)
//         {
//             partText.text = player.currentParts + " / " + player.requiredParts;
//         }
//     }

//     public void StartGame()
//     {
//         startMenu.SetActive(false);
//         Time.timeScale = 1f;
        
//         status.SetActive(true);
//     }

//     public void OpenSave()
//     {
//         ShowMenu(savePanel);
//         gameOverMenu.SetActive(false);
//         RefreshSaveUI();
//     }

//     public void SaveGame(int slot)
//     {
//         SaveData data = player.GetSaveData();

//         data.saveTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm");

//         string json = JsonUtility.ToJson(data, true);

//         string path = Application.persistentDataPath + "/save_" + slot + ".json";

//         System.IO.File.WriteAllText(path, json);
//         RefreshSaveUI();

//         Debug.Log("Saved to slot " + slot);
//         Debug.Log("JSON: " + json);
//     }

//     public void LoadGame(int slot)
//     {
//         string path = Application.persistentDataPath + "/save_" + slot + ".json";

//         if (System.IO.File.Exists(path))
//         {
//             string json = System.IO.File.ReadAllText(path);

//             SaveData data = JsonUtility.FromJson<SaveData>(json);

//             player.LoadFromData(data);
//             savePanel.SetActive(false);
//             TogglePause();
//         }
//         else
//         {
//             Debug.Log("No save in slot " + slot);
//         }
//         RefreshSaveUI();
//     }

//     public void OpenAudio()
//     {
//         ShowMenu(audioPanel);
//     }

//     public void Back()
//     {
//         if (!isPaused)
//             ShowMenu(startMenu);
//         else
//             ShowMenu(pauseMenu);
//     }

//     public void SetVolume(float volume)
//     {
//         AudioListener.volume = volume;
//     }

//     public void OpenCredits()
//     {
//         ShowMenu(creditsPanel);
//     }

//     public void TogglePause()
//     {
//         isPaused = !isPaused;

//         pauseMenu.SetActive(isPaused);

//         if (isPaused)
//             Time.timeScale = 0f;
//         else
//             Time.timeScale = 1f;
//     }

//     public void GameOver()
//     {
//         gameOverMenu.SetActive(true);
//         Time.timeScale = 0f;
//     }

//     async public void RestartGame()
//     {
        
//         Scene currentScene = SceneManager.GetActiveScene();
//         SceneManager.LoadScene(currentScene.name);
//     }

//     public void QuitGame()
//     {
//         #if UNITY_EDITOR
//         UnityEditor.EditorApplication.isPlaying = false; 
//         #else
//         Application.Quit(); 
//         #endif
//     }

//     void ShowMenu(GameObject menu)
//     {
//         startMenu.SetActive(false);
//         audioPanel.SetActive(false);
//         creditsPanel.SetActive(false);
//         pauseMenu.SetActive(false);
//         savePanel.SetActive(false);

//         menu.SetActive(true);
//     }

//     public bool HasSave(int slot)
//     {
//         string path = Application.persistentDataPath + "/save_" + slot + ".json";
//         return System.IO.File.Exists(path);
//     }

//     public void DeleteSave(int slot)
//     {
//         string path = Application.persistentDataPath + "/save_" + slot + ".json";

//         if (System.IO.File.Exists(path))
//         {
//             System.IO.File.Delete(path);
//         }
//     }

//     public void RefreshSaveUI()
//     {
//         UpdateSlotUI(1, slot1Text);
//         UpdateSlotUI(2, slot2Text);
//         UpdateSlotUI(3, slot3Text);
//     }

//     void UpdateSlotUI(int slot, TMPro.TextMeshProUGUI text)
//     {
//         string path = Application.persistentDataPath + "/save_" + slot + ".json";

//         if (!System.IO.File.Exists(path))
//         {
//             text.text = "Slot " + slot + "\n[NEW SAVE]";
//             return;
//         }

//         string json = System.IO.File.ReadAllText(path);
//         SaveData data = JsonUtility.FromJson<SaveData>(json);

//         text.text =
//             "Slot " + slot + "\n" +
//             data.saveTime;
//     }

//     void ClearAllSaves()
//     {
//         string folder = Application.persistentDataPath;

//         string[] files = System.IO.Directory.GetFiles(folder, "save_*.json");

//         foreach (string file in files)
//         {
//             System.IO.File.Delete(file);
//         }
//     }

//     void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.CompareTag("player"))
//         {
//             player = other.GetComponent<plyaercontroller>();

//             repairUI.SetActive(true);
//         }
//     }
//     void OnTriggerExit2D(Collider2D other)
//     {
//         if (other.CompareTag("player"))
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
//         }
//         else
//         {
//             Debug.Log("Not enough parts!");
//         }
//     }
// }
