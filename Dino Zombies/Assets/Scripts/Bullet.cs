using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;
    public float bulletSpeed = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rb.linearVelocity = transform.up * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("papa");
        if (collision.tag != "MC") 
            {
                Destroy(gameObject);
                if (collision.tag == "villan")
                {
                    Destroy(collision.gameObject);
                }
            }
    }
}
