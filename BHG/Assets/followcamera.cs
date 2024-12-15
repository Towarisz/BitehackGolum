using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class followcamera : MonoBehaviour
{
    private Camera mainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Object.FindFirstObjectByType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
       ; // Referencja do kamery g��wnej

        // Pobieramy aktualn� pozycj� kamery
        Vector3 cameraPosition = mainCamera.transform.position;

        // Ustawiamy pozycj� t�a tak, aby porusza�o si� w osi Y z kamer�
        transform.position = new Vector3(transform.position.x, cameraPosition.y, transform.position.z);
    }
}
