using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public GameObject player;
    public TMP_Text depthText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        depthText.text = Mathf.RoundToInt(player.transform.position.y).ToString();
    }
}
