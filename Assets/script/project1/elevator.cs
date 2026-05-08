using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    private Vector3 target;
    private bool isMoving = false;

    void Start()
    {
        target = pointA.position;
    }

    void Update()
    {
        if (!isMoving) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, target) < 0.05f)
        {
            isMoving = false;
        }
    }

    public void MoveToB()
    {
        target = pointB.position;
        isMoving = true;
    }

    public void MoveToA()
    {
        target = pointA.position;
        isMoving = true;
    }
}