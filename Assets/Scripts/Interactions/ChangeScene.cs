using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    public void Trigger()
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
}
