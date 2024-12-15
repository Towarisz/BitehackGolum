using UnityEngine;

public class ActivateMovement : MonoBehaviour
{
    [Header("Target Object")]
    public GameObject objectToMove; // Obiekt, który zacznie siê poruszaæ

    [Header("Movement Settings")]
    public Vector3 targetPosition = new Vector3(5f, 0f, 0f); // Pozycja docelowa
    public float speed = 2f; // Prêdkoœæ ruchu

    private bool isActivated = false; // Flaga, czy obiekt zosta³ aktywowany

    private void Awake()
    {
        targetPosition += transform.position;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        isActivated = true; // Aktywacja ruchu
    }

    void Update()
    {
        if (isActivated && objectToMove != null)
        {
            // Poruszanie obiektu w kierunku celu
            objectToMove.transform.position = Vector3.MoveTowards(
                objectToMove.transform.position,
                targetPosition,
                speed * Time.deltaTime
            );

            // Zatrzymanie po dotarciu do celu
            if (Vector3.Distance(objectToMove.transform.position, targetPosition) < 0.1f)
            {
                isActivated = false; // Dezaktywacja ruchu po dotarciu
            }
        }
    }
}
