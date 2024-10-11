using UnityEngine;
using UnityEngine.SceneManagement;

public class GoArch : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Scene1");
    }
}