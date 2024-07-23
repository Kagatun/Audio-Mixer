using UnityEngine;
using TMPro;

public class HealthView : HealthBar
{
    [SerializeField] private TMP_Text _text;

    public override void DrawHealth(int health, int maxHealth)
    {
        int percent = 100;
        float currentHealth = (float)health / maxHealth * percent;

        if (_text != null && _health != null)
        {
            _text.text = $"{currentHealth}/{maxHealth}";
        }
    }
}
