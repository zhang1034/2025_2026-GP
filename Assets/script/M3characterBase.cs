using UnityEngine;

public abstract class M3characterBase : MonoBehaviour, IDamageable
{
    [SerializeField] protected int maxHealth = 100;
    [SerializeField] protected float moveSpeed = 3f;
    [SerializeField] protected Transform target;

    protected int currentHealth;
    protected bool isDead;

    public bool IsDead => isDead;

    protected virtual void Awake()
    {
        currentHealth = maxHealth;
        isDead = false;
    }

    protected virtual void Update()
    {
        if (isDead || target == null) return;
        
        Move();
    }

    public abstract void Move();
    public abstract void Attack();

    public virtual void TakeDamage(int damage)
    {
        if (isDead) return;
        
        currentHealth -= damage;
        print(gameObject.name+currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        isDead = true;
        print(gameObject.name+"dead");
        Destroy(gameObject);
    }
}