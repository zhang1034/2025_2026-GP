using UnityEngine;

public class MeleeEnemy : M3characterBase
{
    [SerializeField] private float attackRange = 1.5f;
    [SerializeField] private int attackDamage = 15;
    [SerializeField] private float attackCooldown = 1.2f;

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
        transform.LookAt(target);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public override void Attack()
    {
        IDamageable damageable = target.GetComponent<IDamageable>();
        if (damageable != null && !damageable.IsDead)
        {
            damageable.TakeDamage(attackDamage);
        }
    }
}