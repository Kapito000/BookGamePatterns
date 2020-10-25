using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CommandMoveForward : Command
{
    public CommandMoveForward(Action action) : base(action) { }

    public override void Undo()
    {
        
    }
}