using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    //Action _action;

    //public Command(Action action)
    //{
    //    _action = action;
    //}
    //public void Execute()
    //{
    //    _action.Do();
    //}
    public void Execute(Action action)
    {
        action.Do();
    }

    public abstract void Undo();
}