using UnityEngine;

[CreateAssetMenu(menuName = "Dialog Script")]

[System.Serializable]
public class DialogScript : ScriptableObject
{
    public DialogSentence[] sentences;
}
