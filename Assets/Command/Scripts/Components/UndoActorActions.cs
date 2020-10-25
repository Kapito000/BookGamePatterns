using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoActorActions : MonoBehaviour
{
    [SerializeField] CommandRoster _roster = null;

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)) return;

        var commands = _roster.commands;

        for (int i = commands.Count - 1; i >= 0; i--)
        {
            commands[i].Undo();
        }
    }
}