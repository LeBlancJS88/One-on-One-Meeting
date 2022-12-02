using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AD1020
{

    public class ObjectSpawner01 : MonoBehaviour
    {
        public GameObject HiddenSpawner;
        public GameObject Prefab_Popcube;
        public GameObject Prefab_Popsphere;
        public float spawnTime = 0;
        public float spawnDelay = 1;
        public bool disableSpawn = false;
        public CubeCounter counter;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            {
                if (disableSpawn == false)
                {
                    if (spawnTime > spawnDelay)
                    {
                        Instantiate(HiddenSpawner, transform);
                        spawnTime -= spawnDelay;
                        counter.CounterIncrementer();
                        counter.CounterUpdater();
                    }
                }

                spawnTime += Time.deltaTime;
            }

        }

    }
}
