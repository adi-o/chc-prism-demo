using System.Collections.Generic;

namespace chc.mod.menu
{
    public interface IMenu
    {
        IEnumerable<string> MenuItems { get; }
    }
}
