using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private IEnumerator FadeIn()
    {
        while (image.color.a < 1)
        {
            yield return new WaitForSeconds(0.1f);
            Color color = image.color;
            color.a += 0.05f;
            image.color = color;
        }
    }

    private void StartFade(int _)
    {
        StartCoroutine(nameof(FadeIn));
    }

    private void OnEnable()
    {
        Player.OnGameOver += StartFade;
    }

    private void OnDisable()
    {
        Player.OnGameOver -= StartFade;
    }
}
