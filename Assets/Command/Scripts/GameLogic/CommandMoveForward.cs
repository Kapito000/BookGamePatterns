using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CommandMoveForward : Command
{
    [SerializeField] Vector3 _beforPosition;

    UndoMoveTowards _undo;

    public CommandMoveForward(Actor actor) : base(actor)
    {
        _beforPosition = this.actor.transform.position;
        _undo = new UndoMoveTowards(this.actor, _beforPosition);
    }

    public override void Execute(/*Actor actor*/)
    {
        if (actor.moveTowards == null) return;

        actor.moveTowards.Do();
    }

    public override void Undo()
    {
        _undo.Undo();
    }
}