using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AD1020
{

    //Example Script taken from Unity Documentation
    public class Test1 : MonoBehaviour
    {
        public float xAngle, yAngle, zAngle;


        void Awake()
        {
            gameObject.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

        void Update()
        {
            gameObject.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        }
    }
}
