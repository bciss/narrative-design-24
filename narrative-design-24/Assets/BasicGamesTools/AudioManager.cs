using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer masterMixer;

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
