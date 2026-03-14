using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

namespace AH3829
{
public class M2test : MonoBehaviour
{
    private GameObject foundByTag;
    private Light foundByType;

    private GameObject[] allTaggedObjects;

    private List<Light> lightList = new List<Light>();

    void Start()
    {
        foundByTag = GameObject.FindWithTag("Player");
        if (foundByTag != null)
        {
            Debug.Log("found Tag:Player");
            foundByTag.name = "RenamedPlayer";
        }

        allTaggedObjects = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log("Amount of enemy: " + allTaggedObjects.Length);


        foundByType = FindFirstObjectByType<Light>();
        if (foundByType != null)
        {
            lightList.Add(foundByType);
            foundByType.intensity = 100f;
        }

    }

}
}