using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public string Function;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Func(Function);
            Application.Quit();
        }
    }
    public void Func(string Function)
    {
        if (Function == "BackToGallery")
        {
            gameObject.GetComponent<SceneController>().TransferToScene(1);
            gameObject.GetComponent<SceneController>().ChangeId(2);
        }
        if (Function == "BackToMenu")
        {
            gameObject.GetComponent<SceneController>().TransferToScene(1);
            gameObject.GetComponent<SceneController>().ChangeId(0);
        }
    }
}
