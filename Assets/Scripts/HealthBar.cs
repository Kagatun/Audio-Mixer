using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        if (_health != null)
        {
            _health.OnHealthChanged += DrawHealth;
        }
    }

    private void OnDisable()
    {
        if (_health != null)
        {
            _health.OnHealthChanged -= DrawHealth;
        }
    }

    public virtual void DrawHealth(int health, int maxHealth) { }
}
