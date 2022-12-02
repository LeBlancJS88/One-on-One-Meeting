using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace AD1020
{

    public class PauseButton : MonoBehaviour
    {
        //This button will be used to pause and unpause the FixedUpdate time.
        public Button ChronoTrigger;
        [SerializeField] public TMP_Text ChronoTriggerText;

        private void OnEnable()
        {
            TestingUnityEvents1.OnClicked += TogglePause;
        }

        private void OnDisable()
        {
            TestingUnityEvents1.OnClicked -= TogglePause;
        }

        void Start()
        {
            //Here I add a listener with a TogglePause function to the onClick of the button above.
            ChronoTrigger.onClick.AddListener(TogglePause);
        }
        public void TogglePause()
        {
            //This code contains the pause function, we are affecting the rate at which time passes.
            //Setting the scale to 0.0 means it is effectively an infinite amount of time before a "frame" of time passes, effectively
            //pausing the game. We use a mathematical formula containing the ternery operator (?:) which stands for "if x then y" in this case,
            //this usage causes the values to switch on click.
            ChronoUpdate();
            Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
        }

        private void ChronoUpdate()
        {
            if (ChronoTriggerText.text == "Unmake time")
            {
                ChronoTriggerText.text = "Make time";
            }
            else if (ChronoTriggerText.text != "Unmake time")
            {
                ChronoTriggerText.text = "Unmake time";
            }

        }
    }
}