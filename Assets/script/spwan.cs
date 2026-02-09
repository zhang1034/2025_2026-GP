using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AH3829
{
public class Spawn : MonoBehaviour
{
    void Start()
    {
        Data tempName = new Data(99, "Cinderella");
        tempName.SetScore(50);

        Debug.Log("Spawned temp: " + tempName.name);
    }
}
}