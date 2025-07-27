using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonManager_CorrectPos : MonoBehaviour
{
    public GameObject scroll;
    public GameObject EuObject;
    public GameObject[] buttons;
    public Vuforia.ImageTargetBehaviour targetBehaviour;
    public Vuforia.TargetStatus TargetStatus;
   

    public void Show()
    {
        EuObject.SetActive(true);
        foreach (var button in buttons)
        {
            button.SetActive(true);
        }
    }

    public void OnClickInfoButton()
    {
        scroll.SetActive(true);
    }

    public void Clear()
    {
        EuObject.SetActive(false);
        foreach (var button in buttons)
        {
            button.SetActive(false);
            scroll.SetActive(false);
        }
    }

    private void Start()
    {
        targetBehaviour = GetComponent<Vuforia.ImageTargetBehaviour>();

        foreach (var button in buttons)
        {
            button.SetActive(false);
        }
    }
}
