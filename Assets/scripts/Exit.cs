using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
       myButton = GetComponent<Button>();
       myButton.onClick.AddListener(OnExit);
    }

    void OnExit() {
        Application.Quit();
    }
}
