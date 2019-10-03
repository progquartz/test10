using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    private Text ScriptText1;
    private Text ScriptText2;
    private GameObject ScriptButton;
    private GameObject YesNoImage;
    private GameObject OkImage;

    void Start()
    {
        InitGame();
    }

    void InitGame()
    {
        YesNoImage = GameObject.Find("YesNoImage");
        OkImage = GameObject.Find("OkImage");
        ScriptText1 = GameObject.Find("ScriptText1").GetComponent<Text>();
        ScriptText2 = GameObject.Find("ScriptText2").GetComponent<Text>();
        GameObject.Find("YesButton").GetComponentInChildren<Text>().text = "Yes";
        GameObject.Find("NoButton").GetComponentInChildren<Text>().text = "No";
        GameObject.Find("ScriptButton").GetComponentInChildren<Text>().text = "Ok";
        ScriptText1.text = "겜 끌거?";
        ScriptText2.text = "ㅎㅇ";
        OkImageDisable();
        YesNoImageDisable();
        OkImageenable();
    }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //play모드를 false로.
#elif UNITY_WEBPLAYER
            Application.OpenURL("http://google.com"); //구글웹으로 전환
#else
            Application.Quit(); //어플리케이션 종료
#endif
    }
    //OkImage.SetActive(true);

    public void OkImageenable()
    {
        OkImage.SetActive(true);
    }

    public void YesNoImageenable()
    {
        YesNoImage.SetActive(true);
    }

    public void OkImageDisable()
    {
        OkImage.SetActive(false);
    }

    public void YesNoImageDisable()
    {
        YesNoImage.SetActive(false);
    }

}
