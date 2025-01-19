using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    private Image image;
    void Start()
    {
        image = GetComponent<Image>();
    }

    private IEnumerator Fadein()
    {
        while (image.color.a < 1)
        {
            yield return new WaitForSeconds(0.1f);
            Color color = image.color;
            color.a += 0.05f;
            image.color = color;
        }
    }

    private void startFade(int _)
    {
        StartCoroutine(nameof(Fadein));
    }

    private void OnEnable()
    {
        Player.OnGameOver += startFade;
    }

    private void OnDisable()
    {
        Player.OnGameOver -= startFade;

    }
}

