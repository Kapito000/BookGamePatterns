using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] KeyCode _key1 = KeyCode.Alpha1;
    [SerializeField] KeyCode _key2 = KeyCode.Alpha2;

    public event Action Press1;
    public event Action Press2;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Press1?.Invoke();
        if (Input.GetKeyDown(KeyCode.Alpha2)) Press2?.Invoke();
    }
}
