using UnityEngine;
using UnityEngine.SceneManagement;

namespace BasicTools
{
    public class BasicTools : MonoBehaviour
    {
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
