using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene loading

public class Sandbox : MonoBehaviour
{
    void Update()
    {
        // Check if Enter/Return key is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Scene0");
        }
    }
}
