 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace AD1020
{

    public class TestingUnityEvents1 : MonoBehaviour
    {
        public delegate void ClickAction();

        public static event ClickAction OnClicked;

        bool Paused;

        public GameObject canvasToggle;

        private void OnGUI()
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
            {
                if (OnClicked != null)
                    OnClicked();
            }
        }
        void Awake()
        {
            PauseGame();
            canvasToggle = GameObject.Find("Toggle");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PauseGame();
                Debug.Log("Pressed 'Space'");
            }
        }

        public void PauseGame()
        {
            Paused = !Paused;
            if (Paused == true)
            {
                Time.timeScale = 0;
                canvasToggle.GetComponent<UnityEngine.UI.Toggle>().isOn = true;
                Debug.Log("'Pause' Called");
            }

            else
            {
                Time.timeScale = 1;
                canvasToggle.GetComponent<UnityEngine.UI.Toggle>().isOn = false;
                Debug.Log("'Unpause' Called");
            }
        }
    }
}

