using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menuObject;

    [SerializeField] private GameObject[] tabs;
    [SerializeField] private GameObject[] pages;

    void Start()
    {
        ActivateTab(0);
        menuObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            menuObject.SetActive(!menuObject.activeSelf);
        }
    }

    public void ActivateTab(int idx)
    {
        for (int i = 0; i < tabs.Length; i++)
        {
            if (i == idx)
            {
                tabs[i].GetComponent<Image>().color = Color.white;
                pages[idx].SetActive(true);
                continue;
            }
            tabs[i].GetComponent<Image>().color = Color.grey;
            pages[i].SetActive(false);
        }
    }
}
