using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Activity_K : MonoBehaviour
{
    public GameObject Textbox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public GameObject Choice04;
    public int ChoiceMade;

    public void ChoiceOption1()
    {
        SceneManager.LoadScene(90);
        ChoiceMade = 1;
    }
    public void ChoiceOption2()
    {
        SceneManager.LoadScene(88);
        ChoiceMade = 2;
    }

    public void ChoiceOption3()
    {
        SceneManager.LoadScene(90);
        ChoiceMade = 3;
    }

    public void ChoiceOption4()
    {
        SceneManager.LoadScene(90);
        ChoiceMade = 4;
    }


    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(false);
            Choice04.SetActive(false);
        }
    }
}
