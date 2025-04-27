using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class explosion : MonoBehaviour
{
    public AudioClip deadsound;
    private AudioSource audioSource;

    void Start()
    {
        // 初始化 audioSource
        audioSource = gameObject.AddComponent<AudioSource>();

        // 播放声音
        PlaySound(deadsound);

        // 0.5秒后销毁游戏对象
        Destroy(gameObject, 0.5f);
    }

    void PlaySound(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}

