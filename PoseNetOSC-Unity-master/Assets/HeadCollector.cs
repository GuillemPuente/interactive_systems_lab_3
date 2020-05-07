using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HeadCollect"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
