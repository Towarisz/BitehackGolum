using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Object Settings")]
    public GameObject targetObject; // Obiekt, który ma zniknąć (platforma)

    [Header("Timing Settings")]
    public float delay = 3f; // Czas, po którym obiekt zniknie

    private bool isCounting = false; // Flaga sprawdzająca, czy licznik został uruchomiony

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawdzenie, czy gracz lub jakikolwiek obiekt dotknął platformy
        if (!isCounting && targetObject != null)
        {
            isCounting = true; // Rozpoczęcie odliczania czasu
            Debug.Log($"Platforma dotknięta przez: {collision.gameObject.name}. Zniknie za {delay} sekund.");
            StartCoroutine(DestroyObjectAfterDelay());
        }
    }

    private System.Collections.IEnumerator DestroyObjectAfterDelay()
    {
        // Czekanie określony czas
        yield return new WaitForSeconds(delay);

        // Sprawdzenie, czy obiekt nadal istnieje
        if (targetObject != null)
        {
            Destroy(targetObject); // Zniszczenie obiektu
            Debug.Log($"Obiekt {targetObject.name} został zniszczony.");
        }
    }
}
