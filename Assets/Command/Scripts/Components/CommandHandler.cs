using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandHandler : MonoBehaviour
{
    [SerializeField] InputManager _inputManager = null;
    [SerializeField] CommandRoster _commandRoster = null;

    Actor _actor;

    void Jump()
    {
        var jump = new CommandJump(_actor);
        jump.Execute(/*_actor*/);
        _commandRoster.AddCommand(jump);
    }
    void MoveTowards()
    {
        var moveTowards = new CommandMoveForward(_actor);
        moveTowards.Execute(/*_actor*/);
        _commandRoster.AddCommand(moveTowards);
    }

    private void Awake()
    {
        if (GetComponent<Actor>()) _actor = GetComponent<Actor>();
    }
    void Start()
    {
        _inputManager.Press1 += Jump;
        _inputManager.Press2 += MoveTowards;
    }
}
