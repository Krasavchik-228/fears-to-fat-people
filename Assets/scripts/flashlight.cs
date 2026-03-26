using UnityEngine;

public class flashlight : MonoBehaviour
{
    public Light flashlight;
    private bool isOn = false;

    void Start()
    {
        flashlight.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlashlight();
        }
    }

    void ToggleFlashlight()
    {
        isOn = !isOn;
        flashlight.enabled = isOn;
    }
}
