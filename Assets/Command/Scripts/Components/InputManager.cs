using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] KeyCode _keyJump = KeyCode.Alpha1;
    [SerializeField] KeyCode _keyMoveForward = KeyCode.Alpha2;

    [SerializeField] Action _jump;
    [SerializeField] Action _moveTowards;

    InputCommand _inputCommand;

    void InputCollect()
    {
        var command = _inputCommand.CallCommand();

        if (command == null) return;

        command.Execute();
    }

    private void Awake()
    {
        _inputCommand = new InputCommand(_keyJump, _keyMoveForward, new CommandJump(), new CommandMoveForward());
    }

    private void Update()
    {
        InputCollect();
    }
}
