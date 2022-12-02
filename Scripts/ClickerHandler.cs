using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace AD1020
{

    public class ClickerHandler : MonoBehaviour
    {
        private int counter = 0;
        private int counterTrigger = 10;

        private TMP_Text ClickCount;


        private void Awake()
        {
            ClickCount = this.gameObject.GetComponent<TMP_Text>();
        }
        void Start()
        {
            CounterUpdater();
        }

        public void CounterTriggerEvent()
        {
            if (counter < counterTrigger)
            {
                CounterIncrementer();
                CounterUpdater();
            }
            else
            {
                CounterMultiplier();
                CounterUpdater();
            }
        }

        private void CounterIncrementer()
        {
            counter++;
        }
        
        private void CounterMultiplier()
        {
            counter+= 10;
        }

        private void CounterUpdater()
        {
            ClickCount.text = "Number of clicks: " + counter;
        }
    }
}
