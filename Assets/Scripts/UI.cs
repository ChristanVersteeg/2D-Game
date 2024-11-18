using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    [SerializeField] private Text scoreText;

    private void Start()
    {

    }

    private void Update()
    {
        scoreText.text = Player.score.ToString();
    }
}
