using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AD1020
{

public class ObjectHandlerScript : MonoBehaviour
    {
        public float xAngle, yAngle, zAngle;
        private Color newColor;

        void Awake()
        {
            gameObject.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
            RandomCubeColor();
        }

        void FixedUpdate()
        {
            gameObject.transform.Rotate(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10) * Time.deltaTime, Space.Self);
        }

        public void RandomCubeColor()
        {
            newColor = new Color(Random.value, Random.value, Random.value);
            gameObject.GetComponent<MeshRenderer>().material.color = newColor;
        }
    }
}
