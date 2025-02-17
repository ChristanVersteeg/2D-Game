using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] spawner spawner;
    
    
    

    // Update is called once per frame
    private void PlayOnClick()
    {
        transform.parent.gameObject.SetActive(false);
        spawner.StartSpawning();
    }
     private void OnEnable()
    {
        button.onClick.AddListener(PlayOnClick);
    }

    private void OnDisable()
    {
        button.onClick.AddListener(PlayOnClick);
    }
}
