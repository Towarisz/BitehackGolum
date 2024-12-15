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
       ; // Referencja do kamery g³ównej

        // Pobieramy aktualn¹ pozycjê kamery
        Vector3 cameraPosition = mainCamera.transform.position;

        // Ustawiamy pozycjê t³a tak, aby porusza³o siê w osi Y z kamer¹
        transform.position = new Vector3(transform.position.x, cameraPosition.y, transform.position.z);
    }
}
