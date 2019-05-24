using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour {

    public GameObject instructions;
    private bool show = false;

    public VideoPlayer videoPlayer;

    // Use this for initialization 
    void Awake () {
        videoPlayer.Pause();
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        videoPlayer.Play();
    }


    public void showInstructions()
    {
        if (!show)
        {
            instructions.SetActive(true);
            show = true;
        }
        else
        {
            instructions.SetActive(false);
            show = false;
        }
    }


    //checkOver function will use current frame and total frames of video player video
    //to determine if the video is over.

    private void checkOver()
    {
        long playerCurrentFrame = videoPlayer.frame;
        long playerFrameCount = System.Convert.ToInt64(videoPlayer.frameCount);

        if (playerCurrentFrame < playerFrameCount)
        {
            print("VIDEO IS PLAYING");
        }
        else
        {
            print("VIDEO IS OVER");
            //Do w.e you want to do for when the video is done playing.
            showInstructions();
            //Cancel Invoke since video is no longer playing
            CancelInvoke("checkOver");
        }
    }

}
