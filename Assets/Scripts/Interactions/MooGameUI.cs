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
    public int cows = 30;

    public int cowsNeeded = 20;

    public UnityEvent<int> spawnCows;

    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject positiveOutcome;
    [SerializeField] private GameObject negativeOutcome;

    [SerializeField] private TextMeshProUGUI positiveText;
    [SerializeField] private TextMeshProUGUI negativeText;

    void Start()
    {
        cowText.text = $"Cows: {cows}";
        timeText.text = $"Time: {formatTime(gameTime)}";
        spawnCows.Invoke(cows);
    }

    string formatTime(float time)
    {
        int min = Mathf.FloorToInt(time / 60f);
        int sec = Mathf.FloorToInt(time - min * 60f);
        return string.Format("{0:00}:{1:00}", min, sec);
    }

    public void CowDown() => --cows;

    void Update()
    {
        gameTime -= Time.deltaTime;
        cowText.text = $"Cows: {cows}";
        timeText.text = $"Time: {formatTime(gameTime)}";

        if (gameTime <= 0.0f || cows < cowsNeeded)
        {
            Time.timeScale = 0.0f;
            bool success = cows >= cowsNeeded;
            positiveOutcome.SetActive(success);
            negativeOutcome.SetActive(!success);
            positiveText.text = $"Saved {cows} cows";
            negativeText.text = $"Too many cows escaped";
            gameOverScreen.SetActive(true);
        }
    }
}
