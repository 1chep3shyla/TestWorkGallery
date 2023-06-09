using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Downloader : MonoBehaviour
{
    public string imageURL;
    public Image imageComponent;
    public SceneController controller;

    public void DownloadImage(int id)
    {
        StartCoroutine(DownloadImageCoroutine(id));
    }
    private IEnumerator DownloadImageCoroutine(int number)
    {
        DontDestroyOnLoad(gameObject);
        imageComponent = gameObject.GetComponent<Image>();
        string url = imageURL + number + ".jpg";
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        DownloadHandlerTexture downloadHandler = new DownloadHandlerTexture();
        www.downloadHandler = downloadHandler;

        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Error downloading image: " + www.error);
        }
        else
        {
            // Access the downloaded texture
            Texture2D texture = downloadHandler.texture;

            // Create a new sprite from the texture
            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);

            // Assign the sprite to the corresponding Image component
            imageComponent.sprite = sprite;
            Color newColor = new Color(1f, 1f, 1f, 1f);
            imageComponent.color = newColor;


            gameObject.GetComponent<Button>().onClick.AddListener(() => controller.TransferToScene(sprite));

            Debug.Log("Image " + number + " downloaded and assigned to the Image component.");

        }

    }
}