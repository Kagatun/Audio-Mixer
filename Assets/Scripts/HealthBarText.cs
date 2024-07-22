using UnityEngine;
using TMPro;

public class HealthBarText : HealthBar
{
    [SerializeField] private TMP_Text _text;

    public override void DrawMaxHealth(int health)
    {
        if (_text != null)
        {
            _text.text = $"{health}/{health}";
        }
    }

    public override void DrawHealth(int health)
    {
        if (_text != null && _player != null)
        {
            _text.text = $"{health}/{_player.MaxHealth}";
        }
    }
}
