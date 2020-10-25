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

    public void Jump()
    {
        if (Input.GetKey(_keyJump))
        {
            _jumpCommand.Execute();
        }
    }
    public void MoveForward()
    {
        if (Input.GetKey(_keyMoveForward))
        {
            _moveForwardCommand.Execute();
        }
    }
}
