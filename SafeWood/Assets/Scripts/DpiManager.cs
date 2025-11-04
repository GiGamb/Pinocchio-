using UnityEngine;

public class DPIManager : MonoBehaviour
{
    public static DPIManager Instance;

    public bool hasGloves = false;
    public bool hasGoggles = false;
    public bool hasMask = false;

    public SlidingDoor door;

    private void Awake()
    {
        Instance = this;
    }

    public void CheckDPI()
    {
        if (hasGloves && hasGoggles && hasMask)
        {
            door.TriggerOpen();
            Debug.Log("Tutti i DPI raccolti. Porta aperta!");
        }
    }
}
