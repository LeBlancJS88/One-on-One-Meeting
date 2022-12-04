using UnityEngine;
using TMPro;

public class DropTheBall : MonoBehaviour
{
    public GameObject barrier;
    public GameObject spawnPoint;
    public TextMeshProUGUI ballHitsCounterText;
    public BallCounter ballCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            barrier.SetActive(true);

        else if (Input.GetKeyUp(KeyCode.F))
            barrier.SetActive(false);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Ball"))
        {
            other.transform.position = spawnPoint.transform.position;
            ballCounter.BallCollisionCount();
            ballHitsCounterText.text = "Ball hits: " + ballCounter.ballCount;
        }
    }
}
