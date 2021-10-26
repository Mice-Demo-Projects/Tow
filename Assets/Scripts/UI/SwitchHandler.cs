using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class SwitchHandler : MonoBehaviour
{
    private int vibSwitchState = 1;
    private int sfxSwitchState = 1;
    public GameObject vibSwitchButton;
    public GameObject vibSwitchBg;
    public GameObject sfxSwitchButton;
    public GameObject sfxSwitchBg;

    public void VibrationSwitchButtonClicked()
    {
        vibSwitchButton.transform.DOLocalMoveX(-vibSwitchButton.transform.localPosition.x, 0.2f);
        vibSwitchState = Math.Sign(-vibSwitchButton.transform.localPosition.x);
        if (vibSwitchState == 1)
        {
            vibSwitchBg.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if (vibSwitchState == -1)
        {
            vibSwitchBg.GetComponent<Image>().color = new Color32(0, 255, 0, 255);

        }
    }    public void SFXSwitchButtonClicked()
    {
        sfxSwitchButton.transform.DOLocalMoveX(-sfxSwitchButton.transform.localPosition.x, 0.2f);
        sfxSwitchState = Math.Sign(-sfxSwitchButton.transform.localPosition.x);
        if (sfxSwitchState == 1)
        {
            sfxSwitchBg.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if (sfxSwitchState == -1)
        {
            sfxSwitchBg.GetComponent<Image>().color = new Color32(0, 255, 0, 255);

        }
    }

}
