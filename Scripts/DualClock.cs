using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace AD1020
{

    public class DualClock : MonoBehaviour
    {
        private float UpdateClock;
        [SerializeField] private TMP_Text UpdateClockText;
        private float FixedClock;
        [SerializeField] private TMP_Text FixedClockText;

        // Update is called once per frame
        private void Update()
        {
            UpdateClock += 1f;
            UpdateClockText.text = "Time: " + UpdateClock;

        }

        private void FixedUpdate()
        {
            FixedClock += 1f;
            FixedClockText.text = "Fixed time: " + FixedClock;
        }
    }
}
