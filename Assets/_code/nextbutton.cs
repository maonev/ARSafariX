using UnityEngine;
using UnityEngine.SceneManagement;

public class nextbutton : MonoBehaviour
{
    public string next;

    public void jumpintosharkScene()
    {
        SceneManager.LoadScene(4);
    }
    public void backintodogScene()
    {
        SceneManager.LoadScene(2);
    }
    public void explorelangScene()
    {
        SceneManager.LoadScene(8);
    }
    public void jumpintoeagleScene()
    {
        SceneManager.LoadScene(3);
    }
    public void exploresharkScene()
    {
        SceneManager.LoadScene(6);
    }
   
}