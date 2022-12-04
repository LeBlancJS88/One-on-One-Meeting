using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AD1020
{

public class TestingArrays1 : MonoBehaviour
    {

        private string[] enemyNames = new string[] { "Greg", "Phil", "Steve", "Gargamel" };

        private List<float> numberList = new List<float>();

        void Start()
        {
            numberList.Add(4);
            numberList.Add(Random.value);

            foreach (var x in enemyNames)
            {
                Debug.Log(x.ToString());
            }
            Debug.Log("Number of enemies: " + enemyNames.Length);


            foreach (var x in numberList)
            {
                Debug.Log(x.ToString());
            }

            for (int i = 0; i < enemyNames.Length; i++)
            {
                enemyNames[i] = enemyNames[i].Replace("Greg", "Tom").Replace("Phil", "Tim").Replace("Steve", "Aron").Replace("Gargamel", "Bob");
            }

            foreach (var x in enemyNames)
            {
                Debug.Log(x.ToString());
            }


            numberList[0] = 10;
            numberList[1] = 100;

            foreach (var x in numberList)
            {
                Debug.Log(x.ToString());
            }

            

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
