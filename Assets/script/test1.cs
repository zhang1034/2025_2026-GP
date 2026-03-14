using UnityEngine;

public class test1 : MonoBehaviour
{
    private int health = 100;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        rend.material.color = Color.red;
    }

    public void Heal()
    {
        health = 100;
        rend.material.color = Color.green;
    }
}