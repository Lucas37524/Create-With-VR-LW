using UnityEngine;
using UnityEngine.SceneManagement;

public class GoPaint : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Scene2");
    }
}