using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class AutoPlayworkaround : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void workaround();

    public VideoPlayer player;
    public Button startButton;
    

    void Start()
    {
        workaround();

        player.url = Path.Combine(Application.streamingAssetsPath, "BigBuckBunny.mp4");
        player.Play();

        startButton.onClick.AddListener(() =>
        {
            StartCoroutine(delayedPlay());
        });
    }

    private IEnumerator delayedPlay()
    {
        yield return new WaitForSeconds(1);
        player.url = Path.Combine(Application.streamingAssetsPath, "BigBuckBunny.mp4");
        player.Play();
    }
}
