using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CameraController : MonoBehaviour
{
    private Vector3 targetPoint;

    [SerializeField] private PlayerMovement player;
    [SerializeField] private float lookOffset = 5f;
    [SerializeField] private float lookAheadSpeed = 3f;
    [SerializeField] private float lookAheadDistance = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     targetPoint = new Vector3(player.transform.position.x, player.transform.position.y,transform.position.z);   
    }

    // Update is called once per frame
    void Update()
    {
        targetPoint.y = player.transform.position.y;
        
        if (player.rb.linearVelocity.x > 0.1)
        {
            lookOffset = Mathf.Lerp(lookOffset, lookAheadDistance, Time.fixedDeltaTime * lookAheadSpeed);
        }else if (player.rb.linearVelocity.x < -0.1)
        {
            lookOffset = Mathf.Lerp(lookOffset, -lookAheadDistance, Time.fixedDeltaTime * lookAheadSpeed);
        }
        
        targetPoint.x= player.transform.position.x + lookOffset;
        
        transform.position = Vector3.Lerp(transform.position, targetPoint, Time.fixedDeltaTime * lookAheadSpeed);
        
    }
}
