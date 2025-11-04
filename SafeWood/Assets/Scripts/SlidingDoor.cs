using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public Vector3 openOffset = new Vector3(2f, 0f, 0f); // quanto si sposta verso destra
    public float speed = 2f;

    private Vector3 closedPosition;
    private Vector3 targetPosition;
    private bool shouldOpen = false;

    void Start()
    {
        closedPosition = transform.position;
        targetPosition = closedPosition;
    }

    void Update()
    {
        if (shouldOpen)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
        }
    }

    public void TriggerOpen()
    {
        targetPosition = closedPosition + openOffset;
        shouldOpen = true;
    }
}