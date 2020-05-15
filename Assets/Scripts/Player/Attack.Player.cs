using UnityEngine;

public partial class Player
{
    [SerializeField]
    private AttackSettings Attack;

    float lookAngle;

    void UpdateAttack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Attack.BulletPrefab, transform.position, Quaternion.Euler(0, 0, lookAngle), transform);
        }
    }

    void FixedUpdateAttack()
    {
        Vector3 lookDirection = (camera.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
    }

    [System.Serializable]
    struct AttackSettings
    {
        public float Damage;

        public float AttackSpeed;

        public GameObject BulletPrefab;
    }
}