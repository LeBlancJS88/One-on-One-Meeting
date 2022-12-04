using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ButtonTextScript : MonoBehaviour
{
    public TMP_Text text;
    public Button button;
    private bool switchText = false;
    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeText()
    {
        switchText = !switchText;

        if (switchText)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }
    }
}
