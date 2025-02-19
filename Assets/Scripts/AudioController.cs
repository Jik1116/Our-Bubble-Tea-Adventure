using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{

    public AudioMixer mixer;
    public string param;

    private Image image;
    public Sprite offSprite;
    public Sprite onSprite;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public bool IsMute()
    {
        float volume;
        mixer.GetFloat(param, out volume);
        return volume == -80f;
    }

    public void ToggleMute()
    {
        float level = IsMute() ? 0f : -80f;
        mixer.SetFloat(param, level);
        if (IsMute()) image.sprite = offSprite;
        else image.sprite = onSprite;
    }
}
