using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] Slider healthSlider;
    [SerializeField] HealthScript playerHealth; //its SerializeField bc we want to know which health, in this case its the players

    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;
    

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
       
    }
    void Start()
    {
        healthSlider.maxValue = playerHealth.GetHealth();
    }
    void Update()
    {
        scoreText.text = scoreKeeper.GetScore().ToString("000000000");
        healthSlider.value = playerHealth.GetHealth();
    }
}
