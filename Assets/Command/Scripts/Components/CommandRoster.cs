using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandRoster : MonoBehaviour
{
    [SerializeField] List<Command> _commands;
    List<Command> commands => _commands;

    public CommandRoster()
    {
        _commands = new List<Command>();
    }

    public void AddCommand(Command command)
    {
        _commands.Add(command);
    }
}