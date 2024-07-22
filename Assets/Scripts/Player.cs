using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private float _maxHealth = 100f;
    private float _health;

    void Start()
    {
        _health = _maxHealth;
        _healthBar.DrawMaxHealth(_maxHealth);
    }

    public void TakeDamage()
    {
        int damage = 20;

        _health -= damage;
        _health = Mathf.Clamp(_health, 0, _maxHealth);
        _healthBar.DrawHealth(_health);
    }

    public void ReplenishHealth()
    {
        int healing = 15;

        _health += healing;
        _health = Mathf.Clamp(_health, 0, _maxHealth);
        _healthBar.DrawHealth(_health);
    }
}
