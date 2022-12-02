using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AD1020
{

    public class CubeColor : MonoBehaviour
    {
        public Color newColor;
        // Start is called before the first frame update
        void Start()
        {
            RandomCubeColor();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void RandomCubeColor()
        {

            newColor = new Color(Random.value, Random.value, Random.value);
            gameObject.GetComponent<MeshRenderer>().material.color = newColor;
        }
    }
}
