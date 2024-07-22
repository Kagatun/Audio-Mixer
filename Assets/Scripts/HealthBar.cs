using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Player _player;

    private void OnEnable()
    {
        if (_player != null)
        {
            _player.OnMaxHealthChanged += DrawMaxHealth;
            _player.OnHealthChanged += DrawHealth;
        }
    }

    private void OnDisable()
    {
        if (_player != null)
        {
            _player.OnMaxHealthChanged -= DrawMaxHealth;
            _player.OnHealthChanged -= DrawHealth;
        }
    }

    public virtual void DrawMaxHealth(int health) { }

    public virtual void DrawHealth(int health) { }
}
