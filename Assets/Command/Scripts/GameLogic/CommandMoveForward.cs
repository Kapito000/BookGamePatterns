using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CommandMoveForward : Command
{
    [SerializeField] Vector3 _beforPosition;

    public CommandMoveForward(Actor actor) : base(actor)
    {
        _beforPosition = this.actor.transform.position;
    }

    public override void Execute(Actor actor)
    {
        if (actor.moveTowards == null) return;

        actor.moveTowards.Do();
    }

    public override void Undo()
    {

    }
}