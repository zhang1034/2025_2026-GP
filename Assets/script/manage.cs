using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AH3829
{
public class Manage : MonoBehaviour
{
    public List<Data> players = new List<Data>();

    void Start()
    {
        Data p1 = new Data(1, "Anna");
        p1.SetScore(Random.Range(0, 100));

        players.Add(p1);

        foreach (Data p in players)
        {
            Debug.Log($"Player {p.name} (ID {p.id}) Score: {p.score}");
        }
    }
}
}