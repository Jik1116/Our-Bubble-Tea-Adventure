using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ChickenScore : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI scoreText;
    public UnityEvent chickenFound;
    public UnityEvent completeChickenQuest;

    public GameObject chickenParent;

    private int score = 0;

    public void CountChickens()
    {
        ChickenPower[] chickenPowers = player.GetComponents<ChickenPower>();
        foreach (ChickenPower chickenPower in chickenPowers)
        {
            score++;
            chickenPower.chicken.transform.position = transform.position + (score * 0.2f * Vector3.up);
            chickenPower.chicken.transform.SetParent(chickenParent.transform);
            Destroy(chickenPower);
        }

        if (score > 0) chickenFound.Invoke();
        if (score == 3)
        {
            scoreText.text = "\n\n\n\nAll chickens collected";
            completeChickenQuest.Invoke();
            return;
        }
        if (score == 1) scoreText.text = "\n\n\n\nMy first friend!";
        else if (score > 1) scoreText.text = $"\n\n\n\n{score} chickens collected";
    }
}
