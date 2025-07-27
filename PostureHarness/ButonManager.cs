using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonManager : MonoBehaviour
{
    public GameObject primaryButton;
    public GameObject[] secondaryButtons;

    private bool primarySelected = false;

    public void OnPrimaryButtonClick()
    {
        // Toggle primary button selection
        primarySelected = !primarySelected;

        // Highlight the primary button when selected
        HighlightButton(primaryButton, primarySelected);

        // Show/hide secondary buttons based on primary selection
        foreach (GameObject button in secondaryButtons)
        {
            button.SetActive(primarySelected);
        }
    }

    public void OnSecondaryButtonClick(GameObject button)
    {
        // Highlight the selected secondary button
        HighlightButton(button, true);
    }

    private void HighlightButton(GameObject button, bool highlight)
    {
        // Example: Change button color to indicate selection
        ColorBlock colors = button.GetComponent<Button>().colors;
        colors.normalColor = highlight ? Color.yellow : Color.white;
        button.GetComponent<Button>().colors = colors;
    }
}
