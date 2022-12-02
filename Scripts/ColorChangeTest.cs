using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AD1020
{

    public class ColorChangeTest : MonoBehaviour
    {
        private void OnEnable()
        {
            TestingUnityEvents1.OnClicked += ColorBoxChange;
        }

        private void OnDisable()
        {
            TestingUnityEvents1.OnClicked -= ColorBoxChange;
        }


        [SerializeField]
        public Image ColorBox;
        [SerializeField]
        public Button Clicker;

        //Intent is to use this variable for color randomization rather than preset color switching.
        public Color newColor;

        void Start()
        {
            //Here I have added a listener to the onClick property which calls the color randomization method. 
            Clicker.onClick.AddListener(ColorBoxChange);
        }


        public void ColorBoxChange()
        {
            //Here I define the ColorBox color value to point to the newColor variable, and set the code to randomize the RGB values.
            newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            ColorBox.color = newColor;
        }
    }
}
