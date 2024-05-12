using UnityEngine;
using UnityEngine.Playables;
using TMPro;

public class SubtitleTrackMixer : PlayableBehaviour
{
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        TextMeshProUGUI text = playerData as TextMeshProUGUI;
        string currentText = "";
        float currentAlpha = 0f;
        Color currentColor = new Color();

        if (!text) { return; }

        int inputCount = playable.GetInputCount();
        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);

            if (inputWeight > 0f)
            {
                ScriptPlayable<SubtitleBehaviour> inputPlayable = (ScriptPlayable<SubtitleBehaviour>)playable.GetInput(i);

                SubtitleBehaviour input = inputPlayable.GetBehaviour();
                currentText = input.subtitleText;
                currentAlpha = inputWeight;

                switch (input.characterID)
                {
                    case 0:
                        currentColor = Color.white;
                        break;
                    case 1:
                        currentColor = Color.cyan;
                        break;
                    case 2:
                        currentColor = Color.yellow;
                        break;
                }
            }
        }
        text.text = currentText;
        
        text.color = new Color(currentColor.r, currentColor.g, currentColor.b, currentAlpha);
    }
}
