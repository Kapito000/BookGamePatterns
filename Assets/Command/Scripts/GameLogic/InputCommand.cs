using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCommand
{
    KeyCode _keyJump;
    KeyCode _keyMoveForward;

    Command _jumpCommand;
    Command _moveForwardCommand;

    public InputCommand(KeyCode keyJump, KeyCode keyMoveForward, Command jumpCommand, Command moveForwardCommand)
    {
        _keyJump = keyJump;
        _keyMoveForward = keyMoveForward;

        _jumpCommand = jumpCommand;
        _moveForwardCommand = moveForwardCommand;
    }

    public Command CallCommand()
    {
        Command command;

        command = Jump();
        if(command == null) return null;

        command = MoveForward();
        if (command == null) return null;

        return command;
    }

    Command Jump()
    {
        if (!Input.GetKey(_keyJump)) return null;
        return _jumpCommand;
    }
    Command MoveForward()
    {
        if (!Input.GetKey(_keyMoveForward)) return null;
        return _moveForwardCommand;
    }
}
