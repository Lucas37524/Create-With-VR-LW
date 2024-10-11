using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Lucas Ward Room");
    }
}