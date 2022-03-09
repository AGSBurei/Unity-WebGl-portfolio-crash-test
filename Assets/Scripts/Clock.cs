using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] public TMP_Text clock;

    void Update()
    {
        clock.text = System.DateTime.Now.ToString("HH:mm");
    }
}
