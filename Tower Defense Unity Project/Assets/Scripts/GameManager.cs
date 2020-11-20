using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static bool GameIsOver;

	public GameObject gameOverUI;
	public GameObject completeLevelUI;
    public int k = 0;
	void Start ()
	{
		GameIsOver = false;
	}

	// Update is called once per frame
	void Update () {
		if (GameIsOver)
			return;

		if (PlayerStats.Lives <= 1)
		{
			EndGame();
		}
	}

	void EndGame ()
	{
		GameIsOver = true;
		gameOverUI.SetActive(true);
        k = 1;
	}

	public void WinLevel ()
	{
		    if (k != 1)
        {
            GameIsOver = true;
            completeLevelUI.SetActive(true);
        }
    }

}
