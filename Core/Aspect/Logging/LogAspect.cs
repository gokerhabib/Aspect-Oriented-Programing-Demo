using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace Core.Aspect.Logging
{
    //IL Weaving Postsharp Aspect
    //Method Interception
    [Serializable]
    public class LogAspect:OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("On Entry Logged");
        }

    }
}
