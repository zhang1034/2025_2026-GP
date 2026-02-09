using UnityEngine;

namespace AH3829
{
public class Cube : MonoBehaviour
{
    public GameObject cubePrefab;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(
                cubePrefab,
                new Vector3(i * 2, 1, 0),
                Quaternion.identity
            );
        }
    }
}
}