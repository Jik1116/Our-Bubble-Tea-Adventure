using UnityEngine;
using TMPro;

public class DialogCanvasController : MonoBehaviour
{
    [SerializeField] private GameObject dialogObject;
    public TextMeshProUGUI speakerText;
    public TextMeshProUGUI sentenceText;

    private DialogScript dialogScript;
    private int idx;

    public void Start()
    {
        dialogObject.SetActive(false);
    }

    public void StartDialog(DialogScript dialogScript)
    {
        this.dialogScript = dialogScript;
        idx = 0;
        Time.timeScale = 0.0f;
        ShowLine();
        dialogObject.SetActive(true);
    }

    public void ShowLine()
    {
        if (idx >= dialogScript.sentences.Length)
        {
            Time.timeScale = 1.0f;
            dialogObject.SetActive(false);
            return;
        }
        DialogSentence sentence = dialogScript.sentences[idx];
        speakerText.text = sentence.speaker;
        sentenceText.text = sentence.sentence;
        idx++;
    }
}
