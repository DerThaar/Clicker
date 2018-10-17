using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	[SerializeField] GameObject pauseMenuUI;
	[SerializeField] GameObject pictures;
	[SerializeField] GameObject texts;
	[SerializeField] GameObject buttons;

	bool GameIsPaused;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameIsPaused) Resume();
			else Pause();
		}
	}

	public void Resume()
	{
		Time.timeScale = 1f;
		pauseMenuUI.SetActive(false);
		pictures.SetActive(true);
		texts.SetActive(true);
		buttons.SetActive(true);
		GameIsPaused = false;
	}

	void Pause()
	{
		Time.timeScale = 0f;
		pauseMenuUI.SetActive(true);
		pictures.SetActive(false);
		texts.SetActive(false);
		buttons.SetActive(false);
		GameIsPaused = true;
	}

	public void LoadMenu()
	{
		Time.timeScale = 1f;
		GameIsPaused = false;
		SceneManager.LoadScene(0);
	}
}