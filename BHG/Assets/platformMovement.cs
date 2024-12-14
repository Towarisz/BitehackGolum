using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Movement Range")]
    public Vector2 startPosition = new Vector2(0f, 0f);   // Pozycja startowa (x, y)
    public Vector2 endPosition = new Vector2(10f, 0f);     // Pozycja koñcowa (x, y)
    
    [Header("Settings")]
    public GameObject platformObject;                       // Obiekt platformy (mo¿na przypisaæ w inspektorze)
    public float speed = 5f;                               // Prêdkoœæ ruchu
    public bool isLooping = true;                          // Czy ruch ma byæ zapêtlony

    private bool movingToEnd = true;                        // Flaga kierunku ruchu

    void Start()
    {
        if (platformObject != null)// Ustawienie pocz¹tkowej pozycji platformy
        {
            platformObject.transform.position = new Vector3(startPosition.x, startPosition.y, platformObject.transform.position.z);
        }
    }

    void Update()
    {
        if (platformObject != null)
        {
            MovePlatform();// Ruch platformy
        }
    }

    void MovePlatform()
    {
        Vector2 targetPosition = movingToEnd ? endPosition : startPosition;// Okreœlenie docelowej pozycji na podstawie kierunku
        
        // Przemieszczanie platformy
        platformObject.transform.position = Vector3.MoveTowards(
            platformObject.transform.position,
            new Vector3(targetPosition.x, targetPosition.y, platformObject.transform.position.z),
            speed * Time.deltaTime
        );

        // Sprawdzanie, czy platforma osi¹gnê³a docelow¹ pozycjê
        if (Vector3.Distance(platformObject.transform.position, new Vector3(targetPosition.x, targetPosition.y, platformObject.transform.position.z)) < 0.1f)
        {
            if (isLooping)
            {
                // Zmiana kierunku, jeœli zapêtlono
                movingToEnd = !movingToEnd;
            }
            else
            {
                // Platforma zatrzymuje siê na koñcowej pozycji
                enabled = false;
            }
        }
    }
}
