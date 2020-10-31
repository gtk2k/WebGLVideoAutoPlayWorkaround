using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Video;

public class AutoPlayworkaround : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void workaround();

    public VideoPlayer player;

    void Start()
    {
        workaround();

        player.url = Path.Combine(Application.streamingAssetsPath, "BigBuckBunny.mp4");
        player.Play();
    }
}
