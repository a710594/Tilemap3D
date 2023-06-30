using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerUpdater : MonoBehaviour
{
    public static Action UpdateHandler;

    private static bool _exists;

    void Start()
    {
        if (!_exists)
        {
            _exists = true;
            DontDestroyOnLoad(transform.gameObject);//�Ϫ�����������ɤ�����
        }
        else
        {
            Destroy(gameObject); //�}�a���������᭫�Ʋ��ͪ�����
            return;
        }
    }

    void Update()
    {
        if (UpdateHandler != null)
        {
            UpdateHandler();
        }
    }
}
