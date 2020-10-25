using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    Actor _actor;
    protected Actor actor => _actor;

    public Command(Actor actor)
    {
        _actor = actor;
    }

    public abstract void Execute(/*Actor actor*/);

    public abstract void Undo();
}