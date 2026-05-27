using TMPro;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int bullets = 5;
    public GameObject bullet;
    public TextMeshProUGUI textMeshPro;
    int papa = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePosition.z = 0f;

        Vector2 direction =
            mousePosition - transform.position;

        float angle =
            Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation =
            Quaternion.Euler(0f, 0f, angle - 90f);
        if (Input.GetMouseButtonDown(0))
        {

            
            Debug.Log("pap" + papa);

            if (bullets > 0)
            {
                GameObject a = Instantiate(bullet, transform);
                a.transform.parent = null;
                bullets--;
                textMeshPro.text = bullets.ToString();

            }
            
        }

    }
}
