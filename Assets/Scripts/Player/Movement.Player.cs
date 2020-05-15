using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public partial class Player
{
    [SerializeField]
    private MovementSettings Movement;

    Rigidbody2D rigidBody;
    Vector3 input;

    void AwakeMovement()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void UpdateMovement()
    {
        input = Vector3.zero;

        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdateMovement()
    {
        Vector3 move = input.normalized * Movement.Speed * Time.fixedDeltaTime;

        rigidBody.MovePosition(transform.position + move);
    }

    [System.Serializable]
    struct MovementSettings
    {
        public float Speed;
    }

}