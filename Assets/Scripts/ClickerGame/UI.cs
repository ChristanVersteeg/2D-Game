using UnityEngine;
using UnityEngine.UI;

namespace ClickerGame
{

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
}
