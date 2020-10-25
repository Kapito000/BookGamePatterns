using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    Jump _jump = null;
    MoveTowards _moveTowards = null;

    public Jump jump => _jump;
    public MoveTowards moveTowards => _moveTowards;


    private void Awake()
    {
        if (GetComponent<Jump>()) _jump = GetComponent<Jump>();
        if (GetComponent<MoveTowards>()) _moveTowards = GetComponent<MoveTowards>();
    }
}