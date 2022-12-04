using UnityEngine;

public class DangerButtonScript : MonoBehaviour
{
    //This button will be used to pause and unpause the game. Time.timeScale is used as it affects even objects called in Update
    bool isPaused = false;
    public void PauseGame()
    {
		{
			if (isPaused)
			{
				Time.timeScale = 1;
				isPaused = false;
			}
			else
			{
				Time.timeScale = 0;
				isPaused = true;
			}
		}
	}
}