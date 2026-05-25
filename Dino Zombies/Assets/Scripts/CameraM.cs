using UnityEngine;

public class CameraM : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    public float smoothTime = 0.2f;

    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(
            player.position.x,
            player.position.y,
            player.position.z
            );

        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPosition,
            ref velocity,
            smoothTime);

        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
