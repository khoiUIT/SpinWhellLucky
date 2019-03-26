using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour {

    public void MainStart()
    {
      //  SceneManager.LoadScene("SpinWhellLuckyScene");
    }

    public void MainSwichAdmin(GameObject RequirementPasswordGO)
    {
        RequirementPasswordGO.SetActive(true);
    }

    public void MainHistory()
    {
        //SceneManager.LoadScene("HistoryScene");
    }

   
    public void DialogLogin(GameObject dialogWarningGo)
    {
        GameObject field = GameObject.FindGameObjectWithTag("InputFieldPassword");

 
        string fieldText = field.GetComponentInChildren<InputField>().text;
 
        if(fieldText == "012345")
        {
            if(!dialogWarningGo.activeSelf)
            { 
                dialogWarningGo.SetActive(true);

                dialogWarningGo.GetComponentInChildren<Text>().text = "Đăng nhập thành công!";
                StartCoroutine(WaitForFiveSecond(dialogWarningGo));
            }

            SceneManager.LoadScene("AdminScene");
        }
        else
        {
            if (!dialogWarningGo.activeSelf)
            {
                dialogWarningGo.SetActive(true);

                dialogWarningGo.GetComponentInChildren<Text>().text = "Sai password!";
                StartCoroutine(WaitForFiveSecond(dialogWarningGo));
            }
      
        }
    }

    public void DialogClose(GameObject DialogGo )
    {
        if(DialogGo.activeSelf)
        {
            DialogGo.SetActive(false);
        }
      
    }

   
    IEnumerator WaitForFiveSecond(GameObject go)
    {
        yield return new WaitForSeconds(5);
        if (go.activeSelf)
        {
            go.SetActive(false);
        }
    }

    public void MainQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }
}
