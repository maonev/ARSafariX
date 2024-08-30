using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeMenuController : MonoBehaviour
{
    // Nama scene untuk menu kedua
    public string intro;

    // Fungsi untuk memulai permainan dan pindah ke menu kedua
    public void startGame()
    {
        SceneManager.LoadScene(2);
    }
    public void nextScene()
    {
        SceneManager.LoadScene(3);
    }
    public void backScene()
    {
        SceneManager.LoadScene(2);
    }
    public void home()
    {
        SceneManager.LoadScene(0);
    }
    public void aboutusScene()
    {
        SceneManager.LoadScene(1);
    }
    public void arview()
    {
        SceneManager.LoadScene(5);
    }
    public void anjingexplore()
    {
        SceneManager.LoadScene(7);
    }






}