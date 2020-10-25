using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandJump : Command
{
    public CommandJump(Actor actor) : base(actor) { }

    public override void Execute(Actor actor)
    {
        if (actor.jump == null) return;

        actor.jump.Do();
    }

    public override void Undo()
    {

    }
}
