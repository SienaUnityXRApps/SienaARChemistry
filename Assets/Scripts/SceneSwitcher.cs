using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    /*
     * This methods switches the scene to the selected scene the user specifies in the inspector via string.
     */
    public void SwitchSceneByName(string name)
    {
        SceneManager.LoadScene(name);
    }
}
