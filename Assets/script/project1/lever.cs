using UnityEngine;

public class Lever : MonoBehaviour
{
    public MovingPlatform platform;
    private bool isOn = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ToggleLever();
        }
    }

    void ToggleLever()
    {
        isOn = !isOn;

        if (isOn)
        {
            platform.MoveToB();
        }
        else
        {
            platform.MoveToA();
        }

        Debug.Log("Lever toggled: " + isOn);
    }
}