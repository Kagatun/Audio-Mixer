using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action<int> OnHealthChanged;
    public event Action<int> OnMaxHealthChanged;

    private int _health;

    public int MaxHealth { get; private set; } = 100;

    private void Start()
    {
        _health = MaxHealth;
        OnMaxHealthChanged.Invoke(MaxHealth);
        OnHealthChanged.Invoke(MaxHealth);
    }

    public void TakeDamage()
    {
        int damage = 20;

        _health -= damage;
        _health = Mathf.Clamp(_health, 0, MaxHealth);
        OnHealthChanged.Invoke(_health);
    }

    public void ReplenishHealth()
    {
        int healing = 15;

        _health += healing;
        _health = Mathf.Clamp(_health, 0, MaxHealth);
        OnHealthChanged.Invoke(_health);
    }
}
