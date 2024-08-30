using UnityEngine;
using UnityEngine.UI;

public class ButtonLoadScene : MonoBehaviour
{
    public SceneManagementScript sceneManager; // Reference to your SceneManagementScript
    public string sceneToLoad; // Name of the scene to load

    private Button button;

    void Start()
    {
        button = GetComponent<Button>(); // Get the Button component attached to this GameObject
        button.onClick.AddListener(LoadTargetScene); // Add a listener to the button's onClick event
    }

    void LoadTargetScene()
    {
        if (sceneManager != null) // Check if the reference is assigned
        {
            sceneManager.LoadScene(sceneToLoad); // Call the LoadScene method from your SceneManagementScript
        }
        else
        {
            Debug.LogError("SceneManagerScript reference not assigned in ButtonLoadScene!");
        }
    }
}