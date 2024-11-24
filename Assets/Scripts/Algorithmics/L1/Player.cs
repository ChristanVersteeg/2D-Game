using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Algo
{
    public class Player : MonoBehaviour
    {
        public static List<Square> squares;

        public static int score = 0;

        private void Awake()
        {
            squares = new List<Square>();
        }

        private void Update()
        {
            if (squares.Count == 0)
            {
                Victory();
            }
        }

        public static void Defeat()
        {
            score = 0;
            UI.ShowDefeatPanel();
        }

        public static void Victory()
        {
            UI.ShowVictoryPanel();
        }

        public static void Restart()
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }

    }
}