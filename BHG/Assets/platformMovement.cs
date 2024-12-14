using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Movement Range")]
    public Vector2 startPosition = new Vector2(0f, 0f);   // Pozycja startowa (x, y)
    public Vector2 endPosition = new Vector2(10f, 0f);     // Pozycja ko�cowa (x, y)
    
    [Header("Settings")]
    public GameObject platformObject;                       // Obiekt platformy (mo�na przypisa� w inspektorze)
    public float speed = 5f;                               // Pr�dko�� ruchu
    public bool isLooping = true;                          // Czy ruch ma by� zap�tlony
    
    
    private bool movingToEnd = true;                        // Flaga kierunku ruchu

    void Start()
    {
        if (platformObject != null)// Ustawienie pocz�tkowej pozycji platformy
        {
            platformObject.transform.position = new Vector3(startPosition.x, startPosition.y, platformObject.transform.position.z);
        }
    }

    void FixedUpdate()
    {
        if (platformObject)
        {
            MovePlatform();// Ruch platformy
        }
    }

    void MovePlatform()
    {
        Vector2 targetPosition = movingToEnd ? endPosition : startPosition;// Okre�lenie docelowej pozycji na podstawie kierunku
        
        // Przemieszczanie platformy
        platformObject.transform.position = Vector3.MoveTowards(
            platformObject.transform.position,
            new Vector3(targetPosition.x, targetPosition.y, platformObject.transform.position.z),
            speed * Time.deltaTime
        );
        
        // Sprawdzanie, czy platforma osi�gn�a docelow� pozycj�
        if (Vector3.Distance(platformObject.transform.position, new Vector3(targetPosition.x, targetPosition.y, platformObject.transform.position.z)) < 0.1f)
        {
            if (isLooping)
            {
                // Zmiana kierunku, je�li zap�tlono
                movingToEnd = !movingToEnd;
          
            }
            else
            {
                // Platforma zatrzymuje si� na ko�cowej pozycji
                enabled = false;
              
            }
        }
    }
}
