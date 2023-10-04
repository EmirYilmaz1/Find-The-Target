using UnityEngine;

public class WinUI : MonoBehaviour
{
    [SerializeField] GameObject winImage;
    void Start()
    {
        FindObjectOfType<TouchHandler>().OnTargetFound += () => {winImage.SetActive(true);};
    }

}
