using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnparentOnEnable : MonoBehaviour
{
    private void OnEnable()
    {
        transform.SetParent(null, true);
    }
}
