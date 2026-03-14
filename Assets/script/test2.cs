using UnityEngine;

public class test2 : MonoBehaviour
{
    public test1 player;

    void Start()
    {
        player.Heal();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.TakeDamage(20);
        }
    }
}