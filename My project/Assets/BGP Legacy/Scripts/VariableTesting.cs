using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AD1020
{    
public class VariableTesting : MonoBehaviour
{
        public GameObject objectToFind;

        public float xAngle, yAngle, zAngle;

        private int numbers;
        private int sums = 3;
        public float decimals = 1.10f;
        public char pubChar = 'z';
        private string text = "hamsandwich";
        public string letter = "h";
        private string ipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
        private bool exampleBoolean = true;
        public string characterName = "Greg";
        public int health = 10;
        public int stamina = 10;
        public int mana = 10;
        public int strength = 10;
        public int dexterity = 14;
        public int constitution = 16;
        public int intelligence = 18;
        public int wisdom = 12;
        public int charisma = 10;
        public int speed = 5;
        public int spellsKnown = 4;
        public int spellsPerDay = 2;

        
        private GameObject sphere2;

        // Start is called before the first frame update
        #region regionname  
        void Start()
        {
            sphere2 = GameObject.Find("Sphere2");
            sphere2.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
            sphere2.GetComponent<Renderer>().material.color = Color.green;

            sums = 19;
            letter += "am";
            HamSandwich();

        }

        void Awake()
        {
        }
        private void HamSandwich()
        {
            if (exampleBoolean)
            {
                exampleBoolean = false;
            }

            if (exampleBoolean == false)
            {
                text = "I want a hamsandwich";
                Debug.Log(text + " " + exampleBoolean);
            }
        }
        #endregion
        // Update is called once per frame
        void Update()
    {
            sphere2.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
        }
}
}
