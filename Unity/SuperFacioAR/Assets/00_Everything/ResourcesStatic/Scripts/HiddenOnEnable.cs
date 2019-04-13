using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenOnEnable : MonoBehaviour
{
    private void OnEnable()
    {
        gameObject.SetActive(false);
    }
}
