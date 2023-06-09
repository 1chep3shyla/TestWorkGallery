using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Downloader[] all;
    public Manager GM;
    void Start()
    {
        LoadImg();
    }
    public void LoadImg()
    {
        for (int i = 1; i < all.Length + 1; i++)
        {
            all[i-1].DownloadImage(i);
        }
    }

}
