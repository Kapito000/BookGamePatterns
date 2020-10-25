using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandJump : Command
{
    UndoJump _undo;

    public CommandJump(Actor actor) : base(actor) 
    {
        _undo = new UndoJump(this.actor);
    }

    public override void Execute(/*Actor actor*/)
    {
        if (actor.jump == null) return;

        actor.jump.Do();
    }

    public override void Undo()
    {
        _undo.Undo();
    }
}
