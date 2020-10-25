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
        _inputCommand.Jump();
        _inputCommand.MoveForward();
    }

    private void Awake()
    {
        _inputCommand = new InputCommand(_keyJump, _keyMoveForward, new CommandJump(_jump), new CommandMoveForward(_moveTowards));
    }

    private void Update()
    {
        InputCollect();
    }
}
