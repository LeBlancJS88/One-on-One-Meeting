using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AD1020
{

    public class ObjectCleaner01 : MonoBehaviour
    {
        public float lifetime;

        void Start()
        {
            Destroy(gameObject, lifetime);
        }

       
        void Update()
        {

        }

    }
}
