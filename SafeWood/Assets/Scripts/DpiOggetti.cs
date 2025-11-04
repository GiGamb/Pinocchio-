using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class DPIItem : MonoBehaviour
{
    public enum DPIType { Gloves, Goggles, Mask }
    public DPIType type;

    private XRGrabInteractable grab;

    void Start()
    {
        grab = GetComponent<XRGrabInteractable>();
        grab.selectEntered.AddListener(OnGrabbed);
    }

    void OnGrabbed(SelectEnterEventArgs args)
    {
        switch (type)
        {
            case DPIType.Gloves:
                DPIManager.Instance.hasGloves = true;
                break;
            case DPIType.Goggles:
                DPIManager.Instance.hasGoggles = true;
                break;
            case DPIType.Mask:
                DPIManager.Instance.hasMask = true;
                break;
        }

        DPIManager.Instance.CheckDPI();
        Destroy(gameObject); // l’oggetto scompare dopo essere stato raccolto
    }
}