using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    void Awake()
    {
        Destroy(gameObject, 5);
    }

    void FixedUpdate()
    {
        transform.position += transform.up * speed * Time.fixedDeltaTime;
    }
}