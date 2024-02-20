using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AboutGameMenu : MonoBehaviour
{
    public GameObject back;

    public GameObject redButton;
    public GameObject greenButton;
    public GameObject blueButton;

    public GameObject redImage;
    public GameObject greenImage;
    public GameObject blueImage;

    public GameObject redText;
    public GameObject greenText;
    public GameObject blueText;

    public void Main()
    {
        back.SetActive(true);
    }

    public void AboutGame()
    {
        Blue();
    }

    public void Blue()
    {
        back.SetActive(false);
        redText.SetActive(false);
        greenText.SetActive(false);
        blueText.SetActive(true);
        blueImage.SetActive(true);
        redImage.SetActive(false);
        greenImage.SetActive(false);
        redButton.SetActive(true);
        blueButton.SetActive(false);
        greenButton.SetActive(true);
    }
    public void Red()
    {
        redText.SetActive(true);
        greenText.SetActive(false);
        blueText.SetActive(false);
        redImage.SetActive(true);
        blueImage.SetActive(false);
        greenImage.SetActive(false);
        redButton.SetActive(false);
        blueButton.SetActive(true);
        greenButton.SetActive(true);
        back.SetActive(false);
    }

    public void Green()
    {
        redText.SetActive(false);
        greenText.SetActive(true);
        blueText.SetActive(false);
        greenImage.SetActive(true);
        redImage.SetActive(false);
        blueImage.SetActive(false);
        redButton.SetActive(true);
        blueButton.SetActive(true);
        greenButton.SetActive(false);
        back.SetActive(false);
    }

}
