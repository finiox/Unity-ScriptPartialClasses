using UnityEngine;

public partial class Player : MonoBehaviour
{
    [SerializeField]
    private Camera camera;


    void Awake()
    {
        AwakeMovement();
    }

    void Start()
    {
        
    }

    void Update()
    {
        UpdateMovement();
        UpdateAttack();
    }

    void FixedUpdate()
    {
        FixedUpdateMovement();
        FixedUpdateAttack();
    }
}
