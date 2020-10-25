using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoMoveTowards : UndoAction
{
    [SerializeField] Vector3 _beforPosition;

    public UndoMoveTowards(Actor actor, Vector3 beforPosition) : base(actor)
    {
        _beforPosition = beforPosition;
    }

    public override void Undo()
    {
        Debug.Log($"Возврат к состоянию перед перемещением в координаты {_beforPosition}.");
    }
}