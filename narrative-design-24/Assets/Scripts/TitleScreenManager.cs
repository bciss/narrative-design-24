using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using BasicTools;
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
}
