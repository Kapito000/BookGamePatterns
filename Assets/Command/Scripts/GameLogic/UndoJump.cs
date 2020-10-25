using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoJump : UndoAction
{
    public UndoJump(Actor actor) : base(actor) { }

    public override void Undo()
    {
        Debug.Log("Возврат к состоянию перед прыжком.");
    }
}