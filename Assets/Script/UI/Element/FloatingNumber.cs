using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FloatingNumber : MonoBehaviour
{
    public Text Label;
    public float Height;
    public float Duration;

    public void SetValue(float height, float duration)
    {
        Height = height;
        Duration = duration;
    }

    public void Play(string text, FloatingNumberData.TypeEnum type, Vector2 position)
    {
        if (int.TryParse(text, out int n))
        {
            Label.fontSize = 50;
        }
        else
        {
            Label.fontSize = 30;
        }

        this.transform.position = position;
        Label.text = text;

        if (type == FloatingNumberData.TypeEnum.Damage)
        {
            Label.color = Color.red;
        }
        else if (type == FloatingNumberData.TypeEnum.Poison)
        {
            Label.color = new Color32(180, 0, 180, 255);
        }
        else if (type == FloatingNumberData.TypeEnum.Recover)
        {
            Label.color = Color.green;
        }
        else if (type == FloatingNumberData.TypeEnum.Miss)
        {
            Label.color = Color.blue;
        }
        else if (type == FloatingNumberData.TypeEnum.Critical)
        {
            Label.color = Color.yellow;
        }
        else if (type == FloatingNumberData.TypeEnum.Paralysis)
        {
            Label.color = new Color32(180, 140, 0, 255);
        }
        else if (type == FloatingNumberData.TypeEnum.Sleeping)
        {
            Label.color = new Color32(0, 150, 200, 255);
        }
        else if (type == FloatingNumberData.TypeEnum.Confusion)
        {
            Label.color = new Color32(100, 0, 200, 255);
        }
        else if (type == FloatingNumberData.TypeEnum.Other)
        {
            Label.color = Color.black;
        }

        this.transform.DOMoveY(position.y + Height, Duration).SetEase(Ease.OutCubic).OnComplete(() =>
        {
        });

        Label.DOFade(0, Duration).SetEase(Ease.InCubic).OnComplete(() =>
        {
        });
    }

    void Awake()
    {
        Label.color = Color.clear;
    }
}
