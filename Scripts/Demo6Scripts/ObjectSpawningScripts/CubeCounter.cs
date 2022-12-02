using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace AD1020
{

    public class CubeCounter : MonoBehaviour
    {
        private int counter = 0;

        private TMP_Text SpawnCounter;
        private void Awake()
        {
           SpawnCounter = this.gameObject.GetComponent<TMP_Text>();
        }
        // Start is called before the first frame update
        void Start()
        {
            CounterUpdater();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CounterIncrementer()
        {
            counter++;
        }

        public void CounterUpdater()
        {
            SpawnCounter.text = "Cubes spawned: " + counter;
        }
    }
}
