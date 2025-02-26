using UnityEngine;

public class ToggleSucess : MonoBehaviour
{
    [SerializeField] private GameObject positiveOutcome;
    [SerializeField] private GameObject negativeOutcome;

    public void TriggerOutcome(bool isPositive)
    {
        positiveOutcome.SetActive(isPositive);
        negativeOutcome.SetActive(!isPositive);
    }
}
