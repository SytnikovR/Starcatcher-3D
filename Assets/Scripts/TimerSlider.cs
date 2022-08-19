using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Bomber3D
{
    public class TimerSlider : MonoBehaviour
    {
        public Slider slider;

        public int timeLeft = 30;
        private float gameTime;

        private void Update()
        {
            slider.value = timeLeft;
            gameTime += Time.deltaTime * 1;

            if(gameTime >= 1)
            {
                timeLeft -= 1;
                gameTime = 0;
            }
        }
    }
}


