using UnityEngine;

public class RangedEnemy : M3characterBase
{
    [SerializeField] private float optimalRange = 8f;
    [SerializeField] private float attackRange = 12f;
    [SerializeField] private int attackDamage = 10;
    [SerializeField] private float attackCooldown = 2f;
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform firePoint;

    private float cooldownTimer;

    protected override void Awake()
    {
        base.Awake();
        cooldownTimer = 0f;
    }

    protected override void Update()
    {
        base.Update();
        if (isDead || target == null) return;

        cooldownTimer -= Time.deltaTime;

        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if (distanceToTarget <= attackRange && cooldownTimer <= 0f)
        {
            Attack();
            cooldownTimer = attackCooldown;
        }
    }

    public override void Move()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        transform.LookAt(target);

        if (distanceToTarget < optimalRange - 1f)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        else if (distanceToTarget > optimalRange + 1f)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

    public override void Attack()
    {
        if (projectilePrefab != null && firePoint != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            Projectile proj = projectile.GetComponent<Projectile>();
            if (proj != null)
            {
                proj.Initialize(attackDamage, target);
            }
        }
    }
}