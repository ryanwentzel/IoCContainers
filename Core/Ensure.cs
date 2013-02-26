using System;

namespace IoCContainers.Core
{
    public static class Ensure
    {
        public static void ArgumentNotNull(object value, string paramName = "")
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}
