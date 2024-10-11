using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTraining : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Scene3");
    }
}