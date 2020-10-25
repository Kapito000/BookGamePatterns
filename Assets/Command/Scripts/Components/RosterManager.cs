using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RosterManager : MonoBehaviour
{
    CommandRoster _roster;

    private void Awake()
    {
        _roster = new CommandRoster();
    }
}