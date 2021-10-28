using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class SwitchHandler : MonoBehaviour
{
#region Instance
    public static SwitchHandler instance;
    private void Awake()
    {
        instance = this;
    }
#endregion
    [NonSerialized] public int vibSwitchState = -1;
    [NonSerialized] public int sfxSwitchState = -1;
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
            PlayerPrefs.SetInt("vibSwitchState", 1);
        }
        else if (vibSwitchState == -1)
        {
            vibSwitchBg.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            PlayerPrefs.SetInt("vibSwitchState", -1);

        }

    }
    public void SFXSwitchButtonClicked()
    {
        sfxSwitchButton.transform.DOLocalMoveX(-sfxSwitchButton.transform.localPosition.x, 0.2f);
        sfxSwitchState = Math.Sign(-sfxSwitchButton.transform.localPosition.x);
        if (sfxSwitchState == 1)
        {
            sfxSwitchBg.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            PlayerPrefs.SetInt("sfxSwitchState", 1);

        }
        else if (sfxSwitchState == -1)
        {
            sfxSwitchBg.GetComponent<Image>().color = new Color32(0, 255, 0, 255);
            PlayerPrefs.SetInt("sfxSwitchState", -1);


        }
    }
    private void Update()
    {
        print(sfxSwitchState);
        print(vibSwitchState);
    }
}
