using UnityEngine;
using UnityEngine.Rendering;

public class SettingsManager : MonoBehaviour
{
    
    public GameObject pausePanel;
    public GameObject settingsPanel;



    #region Settings
    public void TriggerSettingsPanel()
    {
        if (pausePanel.activeSelf)
        {
             Time.timeScale = 1;
             pausePanel.SetActive(false);
        }
        else if (settingsPanel.activeSelf)
        {
            settingsPanel.SetActive(false);
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 0;
            settingsPanel.SetActive(false);
            pausePanel.SetActive(true);
        }
    }
    #endregion

    public void BackButton(GameObject previousPanel = null)
    {
        if (previousPanel != null) 
        {
            previousPanel.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
