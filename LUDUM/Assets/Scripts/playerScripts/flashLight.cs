using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public GameObject flashlight;
    public GameObject pointLight;

    private bool isFlashlightActive = false;
    private bool isPointLightActive = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlashlight();
        }

        if (isFlashlightActive && Input.GetMouseButtonDown(0))
        {
            TogglePointLight();
        }
    }

    void ToggleFlashlight()
    {
        isFlashlightActive = !isFlashlightActive;
        flashlight.SetActive(isFlashlightActive);

        if (!isFlashlightActive)
        {
            isPointLightActive = false;
            pointLight.SetActive(false);
        }
    }

    void TogglePointLight()
    {
        isPointLightActive = !isPointLightActive;
        pointLight.SetActive(isPointLightActive);
    }
}