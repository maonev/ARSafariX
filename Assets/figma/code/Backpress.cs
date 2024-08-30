using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Backpress : MonoBehaviour {

	// berfungsi untuk keluar aplikasi menggunakan tombol back

	public string SceneName;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
        {
			SceneManager.LoadScene(SceneName);
        }
	}

	public void BackToMenu()
    {
		SceneManager.LoadScene(SceneName);
	}

}