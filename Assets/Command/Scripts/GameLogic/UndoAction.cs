using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UndoAction
{
    Actor _actor;
    protected Actor actor => _actor;

    public UndoAction(Actor actor)
    {
        _actor = actor;
    }

    public abstract void Undo(); // Логика отмены действия.
}