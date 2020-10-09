using System;
using System.Collections.Generic;
using System.Text;

namespace ExxtensionMethods.Library
{
   public static class TargetExtensions
   {
        internal static void ExtendInternal(this InternalTarget target)
        {

        }
        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }
   }
}
