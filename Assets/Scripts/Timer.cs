using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Bomber3D
{
    public class Timer : MonoBehaviour
    {
        public Text text;

        public int timeLeft = 30;
        private float gameTime;

        private void Update()
        {
            text.text = timeLeft + " sec left! Go to the star!";

            gameTime += Time.deltaTime * 1;

            if(gameTime >= 1)
            {
                timeLeft -= 1;
                gameTime = 0;
            }
            if (timeLeft <= 10)
            {
                text.color = Color.red;
                text.text = timeLeft + " sec left! Hurry up!";
            }


            if (timeLeft <= 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}


