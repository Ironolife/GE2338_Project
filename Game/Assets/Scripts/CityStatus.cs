﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityStatus : MonoBehaviour
{
    public Sprite sprite_true;
    public Sprite sprite_false;

    bool alerted = false;

    public void SetStatus(bool status)
    {
        SpriteRenderer sprite_renderer = gameObject.GetComponent<SpriteRenderer>();
        if(!status && !alerted)
        {
            sprite_renderer.sprite = sprite_false;
            sprite_renderer.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else
        {
            sprite_renderer.sprite = sprite_true;
            sprite_renderer.color = new Color(0.0f, 1.0f, 0.0f, 1.0f);

            alerted = true;
        }
    }
}
