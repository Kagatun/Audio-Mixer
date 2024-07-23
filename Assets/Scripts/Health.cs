using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int _health;
    private int _maxHealth = 100;

    public event Action<int, int> OnHealthChanged;

    private void Start()
    {
        _health = _maxHealth;
        OnHealthChanged.Invoke(_health, _maxHealth);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        _health = Mathf.Clamp(_health, 0, _maxHealth);
        OnHealthChanged.Invoke(_health, _maxHealth);
    }

    public void ReplenishHealth(int healing)
    {
        _health += healing;
        _health = Mathf.Clamp(_health, 0, _maxHealth);
        OnHealthChanged.Invoke(_health, _maxHealth);
    }
}
