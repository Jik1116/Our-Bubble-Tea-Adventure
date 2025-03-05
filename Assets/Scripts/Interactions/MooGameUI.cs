using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class MooGameUI : MonoBehaviour
{

    private static MooGameUI _instance;
    public static MooGameUI instance
    {
        get
        {
            return _instance;
        }
    }

    public virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as MooGameUI;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] TextMeshProUGUI cowText;
    [SerializeField] TextMeshProUGUI timeText;

    public float gameTime = 30.0f;
    public int startCows = 30;
    public IntVariable cows;

    public int cowsNeeded = 20;

    public UnityEvent<int> spawnCows;
    public string score_prefix = "Cows";

    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject positiveOutcome;
    [SerializeField] private GameObject negativeOutcome;

    [SerializeField] private TextMeshProUGUI positiveText;
    [SerializeField] private TextMeshProUGUI negativeText;

    void Start()
    {
        cows.SetValue(startCows);
        cowText.text = $"{score_prefix}: {cows.Value}";
        timeText.text = $"Time: {formatTime(gameTime)}";
        spawnCows.Invoke(cows.Value);
    }

    string formatTime(float time)
    {
        int min = Mathf.FloorToInt(time / 60f);
        int sec = Mathf.FloorToInt(time - min * 60f);
        return string.Format("{0:00}:{1:00}", min, sec);
    }

    public void CowDown() => cows.SetValue(cows.Value - 1);
    public void CowUp() => cows.SetValue(cows.Value + 1);

    void Update()
    {
        gameTime -= Time.deltaTime;
        cowText.text = $"{score_prefix}: {cows.Value}";
        timeText.text = $"Time: {formatTime(gameTime)}";

        if (gameTime <= 0.0f || cows.Value < cowsNeeded)
        {
            Time.timeScale = 0.0f;
            bool success = cows.Value >= cowsNeeded;
            positiveOutcome.SetActive(success);
            negativeOutcome.SetActive(!success);
            positiveText.text = $"{score_prefix}: {cows.Value}";
            gameOverScreen.SetActive(true);
        }
    }
}
