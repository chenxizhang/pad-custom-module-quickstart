using Microsoft.Flow.RPA.Desktop.Modules.SDK;
using Microsoft.Flow.RPA.Desktop.Modules.SDK.Attributes;
using Microsoft.Flow.RPA.Desktop.Modules.SDK.Extended.Attributes;
using System;

namespace Xizhang.Modules.Helloworld.Actions
{
    [Action(Id = "Hello")]
    [Icon(Code = "EEE7")]
    public class HelloAction : ActionBase
    {
        [InputArgument]
        public string Name { get; set; }

        [OutputArgument]
        public string Result { get; set; }
        public override void Execute(ActionContext context)
        {

            Result = String.Format(Properties.Resources.Messages_SayHello, Name);
        }
    }
}
