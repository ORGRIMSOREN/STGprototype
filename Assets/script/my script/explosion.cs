using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class explosion : MonoBehaviour
{
    public AudioClip deadsound;
    private AudioSource audioSource;

    void Start()
    {
        // ��ʼ�� audioSource
        audioSource = gameObject.AddComponent<AudioSource>();

        // ��������
        PlaySound(deadsound);

        // 0.5���������Ϸ����
        Destroy(gameObject, 0.5f);
    }

    void PlaySound(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}

