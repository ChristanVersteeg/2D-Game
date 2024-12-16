using TMPro;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    private TextMeshProUGUI score;

    private void UpdateScore(int value)
    {
        score.text = value.ToString();
    }

    private void Awake()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Player.OnGameOver += UpdateScore;
    }

    private void OnDisable()
    {
        Player.OnGameOver -= UpdateScore;
    }
}
