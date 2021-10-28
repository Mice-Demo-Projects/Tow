using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject inputPanel;

    private void Awake()
    {
        OptionsDown();
    }
    public void OptionsDown()
    {
        optionsMenu.SetActive(false);
        inputPanel.SetActive(true);
    }
    public void OptionsUp()
    {
        optionsMenu.SetActive(true);
        inputPanel.SetActive(false);

    }

}
