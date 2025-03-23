using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_toggle2 : MonoBehaviour
{
    public GameObject currentPanel; // The panel to hide initially
    public GameObject newPanel;     // The panel to show initially

    public void SwitchPanel()
    {
        if (currentPanel != null)
            currentPanel.SetActive(false);

        if (newPanel != null)
            newPanel.SetActive(true);
    }

    public void CloseNewPanel()
    {
        if (newPanel != null)
            newPanel.SetActive(false);

        if (currentPanel != null)
            currentPanel.SetActive(true);
    }
}
