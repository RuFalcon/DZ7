using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChargeIcon : MonoBehaviour
{
    [SerializeField] private Image _background;
    [SerializeField] private Image _foreground;
    [SerializeField] private TextMeshProUGUI _text;

    public void StartCharge()
    {
        _background.color = new Color(1f, 1f, 1f, 0.2f);
        _foreground.enabled = true;
        _text.enabled = true;
    }

    public void StopCharge()
    {
        _background.color = new Color(1f, 1f, 1f, 1f);
        _foreground.enabled = false;
        _text.enabled = false;
    }

    public void SetChargeValue(float currentCharge, float maxCharge)
    {
        _foreground.fillAmount = currentCharge / maxCharge;
        _text.text = Mathf.Ceil(maxCharge - currentCharge).ToString();
    }
}
