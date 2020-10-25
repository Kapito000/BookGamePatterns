using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandRoster
{
    List<Command> _commands;
    List<Command> Commands => _commands;

    public CommandRoster()
    {
        _commands = new List<Command>();
    }

    public void AddCommand(Command command)
    {
        _commands.Add(command);
    }
}