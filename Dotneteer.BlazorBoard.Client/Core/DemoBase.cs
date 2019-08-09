namespace Dotneteer.BlazorBoard.Client.Core
{
    /// <summary>
    /// This class is intended to be the base class of all demos.
    /// </summary>
    public abstract class DemoBase
    {
        /// <summary>
        /// Metadata of the derived demo class
        /// </summary>
        public DemoMetadata Metadata { get; }

        protected DemoBase()
        {
            var attrs = GetType().GetCustomAttributes(typeof(DemoAttribute), false);
            if (attrs.Length > 0)
            {
                var demoAttr = attrs[0] as DemoAttribute;
                Metadata = new DemoMetadata(
                    demoAttr.Id,
                    demoAttr.Order,
                    demoAttr.Title);
            }
        }
    }
}
