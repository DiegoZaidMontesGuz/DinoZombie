using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int bullets = 3;
    public GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet);
        }
    }
}
