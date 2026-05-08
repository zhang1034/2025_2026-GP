using UnityEngine;
using TMPro;
using System.Collections;

public class KeypadSystem : MonoBehaviour
{
    public string correctCode = "0557";

    public TextMeshProUGUI displayText;
    private string currentInput = "";

    public GameObject door;
    public GameObject panel;

    public void PressNumber(string num)
    {
        currentInput += num;
        displayText.text = currentInput;
    }

    public void Clear()
    {
        currentInput = "";
        displayText.text = "";
    }

    public void Confirm()
    {
        if (currentInput == correctCode)
        {
            Debug.Log("Correct!");

            OpenDoor();
            panel.SetActive(false);
        }
        else
        {
            Debug.Log("Wrong!");

            displayText.text = "ERROR";
            currentInput = "";
        }
    }

    void OpenDoor()
    {
        StartCoroutine(OpenDoorRoutine());
    }
    IEnumerator OpenDoorRoutine()
    {
        Vector3 startPos = door.transform.position;
        Vector3 targetPos = startPos + Vector3.up * 15f;

        float time = 0f;
        float duration = 1f;

        while (time < duration)
        {
            door.transform.position = Vector3.Lerp(startPos, targetPos, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        door.transform.position = targetPos;
    }
}


