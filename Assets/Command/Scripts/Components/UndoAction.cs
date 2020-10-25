using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UndoAction
{
    public abstract void Undo(); // Логика выполнения действия.
}