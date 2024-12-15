using UnityEngine;

public class ResetScript : MonoBehaviour
{
    private ResetHandler resetHandler;
    private Vector3 resetPosition;
    void Start()
    {
        resetHandler = GetComponent<ResetHandler>();
        resetHandler.AddtoResetList(this);
        resetPosition = transform.position;
    }

    public void ResetToDefault()
    {
        transform.position = resetPosition;
    }

    
}
