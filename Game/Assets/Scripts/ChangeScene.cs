using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{

    string[] SceneArray = {"Scene1", "Scene2", "Scene3"};



    public void LoadScene(int SceneNumber)
    {
        SceneManager.LoadScene(SceneArray[SceneNumber - 1]);
    }
}
