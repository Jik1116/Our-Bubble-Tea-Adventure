using UnityEngine;
using TMPro;

[ExecuteInEditMode]
public class ShowScore : MonoBehaviour
{
    public string prefix = "Score";
    public IntVariable intVar;

    private TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = $"{prefix}: {intVar.Value}";
    }
}
