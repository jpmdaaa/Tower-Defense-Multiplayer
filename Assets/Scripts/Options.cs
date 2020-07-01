using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Options : MonoBehaviour
{

    public GameObject menu;
    public GameObject options;
    public Toggle toggleFullScreen;
    public bool fullScreen;

    public GameObject Resolution;
    public GameObject Allbutons;
   

    void Start()
    {
        fullScreen = true;
    }

  
    void Update()
    {
        Screen.fullScreen = fullScreen;

        if (toggleFullScreen.isOn)
        {
            fullScreen = true;
          
        }

        else
        {
            fullScreen = false;
           
        }
    }

    public void ReturnMenu()
    {
        menu.SetActive(true);
        options.SetActive(false);
    }

    public void SetResolution(int Resolution)
    {
        if(Resolution == 640)
        {
            Screen.SetResolution(640, 480, fullScreen);
        }

        if (Resolution == 800)
        {
            Screen.SetResolution(800, 600, fullScreen);
        }

        if (Resolution == 1280)
        {
            Screen.SetResolution(1280, 720, fullScreen);
        }

        if (Resolution == 1920)
        {
            Screen.SetResolution(1920, 1080, fullScreen);
        }

    }


    public void OPTResolution()
    {
        Resolution.SetActive(true);
        Allbutons.SetActive(false);
    }

    public void Return()
    {
        Resolution.SetActive(false);
        Allbutons.SetActive(true);

    }


}
