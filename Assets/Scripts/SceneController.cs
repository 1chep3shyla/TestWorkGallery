using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Manager GM;
    public void TransferToScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
    public void TransferToScene(Sprite spriteNeed)
    {
        GM.showSprite = spriteNeed;
        SceneManager.LoadScene(1);
        ChangeId(3);
    }
    public void ChangeId(int id)
    {
        GM.NeedId = id;
    }
}
