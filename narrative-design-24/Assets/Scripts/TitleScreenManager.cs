using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class TitleScreenManager : MonoBehaviour
{
    // private CustomInput input = null;
    public GameObject optionPanel;
    public GameObject creditPanel;
    public AudioMixer masterMixer;

    void Awake()
    {
        // input = new CustomInput();
    }

    private void OnEnable()
    {
        // input.Enable();
        // input.Base.Space.performed += ctx => OnStartPerformed();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnStartPerformed()
    {
            Debug.Log("Changing scene to : GameScene1");
            SceneManager.LoadScene("GameScene1");
    }

    public void Settings()
    {
            optionPanel.SetActive(!optionPanel.activeSelf);
    }

    public void Credits()
    {
            creditPanel.SetActive(!creditPanel.activeSelf);
    }

    private void OnDisable()
    {
        // input.Disable();
    }
    #region Settings

    public void SetMasterLvl(float masterLvl)
    {
        masterMixer.SetFloat("Master", masterLvl);
    }
    public void SetMusicLvl(float musicLvl)
    {
        masterMixer.SetFloat("Music", musicLvl);
    }
    public void SetSFXLvl(float sfxLvl)
    {
        masterMixer.SetFloat("SFX", sfxLvl);
    }

    #endregion
}
