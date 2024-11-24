using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour

{
    [SerializeField] private Text scoreText;




    private void Start()
    {
        
    }

    private void Update()
    {
        scoreText.text = player.score.ToString();
    }
}
