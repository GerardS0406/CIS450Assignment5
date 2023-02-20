/*
 * Gerard Lamoureux
 * InstructionsDisappear
 * Assignment 5
 * Takes the instructions away after 10 seconds
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InstructionsDisappear : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }

    IEnumerator DestroyAfterTime()
    {
        int time = 10;
        while(time>0)
        {
            text.text = $"This message will delete in {time} Seconds";
            yield return new WaitForSeconds(1);
            time--;
        }
        Destroy(gameObject);
    }
}
