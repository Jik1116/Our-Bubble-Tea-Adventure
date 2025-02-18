using UnityEngine;
using TMPro;

public class DialogCanvasController : MonoBehaviour
{
    public TextMeshProUGUI speakerText;
    public TextMeshProUGUI sentenceText;

    private DialogScript dialogScript;
    private int idx;

    public void StartDialog(DialogScript dialogScript)
    {
        this.dialogScript = dialogScript;
        idx = 0;
        Time.timeScale = 0.0f;
        GetComponent<Canvas>().enabled = true;
        ShowLine();
    }

    public void ShowLine()
    {
        if (idx >= dialogScript.sentences.Length)
        {
            Time.timeScale = 1.0f;
            GetComponent<Canvas>().enabled = false;
            return;
        }
        DialogSentence sentence = dialogScript.sentences[idx];
        speakerText.text = sentence.speaker;
        sentenceText.text = sentence.sentence;
        idx++;
    }
}
