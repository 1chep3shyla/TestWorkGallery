using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Show : MonoBehaviour
{
    public Image img;
    public Manager GM;
    void Start()
    {
        img.sprite = GM.showSprite;
    }
}
