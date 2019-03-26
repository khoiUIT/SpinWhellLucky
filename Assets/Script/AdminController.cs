using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdminController : MonoBehaviour {

    public GameObject goContent;
    public Transform t;

    //Button AddContent
    public void CreateBoxContent()
    {
        Instantiate(goContent, goContent.transform.position, goContent.transform.rotation, t);
    }

    //Button ResetContent
    public void ResetAdmisScene()
    {
        GameObject[] respawns = GameObject.FindGameObjectsWithTag("ContentAdmin");
        foreach (GameObject go in respawns)
        {
            if(go!=null)
            {   
                Destroy(go);
            }
        }
        Instantiate(goContent, goContent.transform.position, goContent.transform.rotation, t);
        Instantiate(goContent, goContent.transform.position, goContent.transform.rotation, t);
        Instantiate(goContent, goContent.transform.position, goContent.transform.rotation, t);
    }

    //Button ImportIMG in item
    public void PickIMGFromGallery()
    {

    }

    //Button Back
    public void BackToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    //Button Save
    public void SaveData()
    {

    }

}
