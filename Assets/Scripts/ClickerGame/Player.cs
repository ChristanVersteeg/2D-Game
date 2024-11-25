using System.Collections.Generic;
using UnityEngine;

namespace ClickerGame
{
    public class Player : MonoBehaviour
    {
        public static int score;
        public static List<Square> squares = new();
        public static void Defeat()
        {
            score = 0;
        }


        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {

        }
    }
}
