using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI staminaText = default;

    private void OnEnable()
    {
        FirstPersonCharacter.OnStaminaChange += UpdateStamina;
    }

    private void OnDisable()
    {
        FirstPersonCharacter.OnStaminaChange -= UpdateStamina;

    }
    private void Start()
    {
        UpdateStamina(100);
    }

    private void UpdateStamina(float currentStamina)
    {
        staminaText.text = currentStamina.ToString("00");
    }
}
