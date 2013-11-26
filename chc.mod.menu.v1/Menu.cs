namespace chc.mod.menu.v1
{
    using System.Collections.Generic;

    public class Menu : IMenu
    {
        public IEnumerable<string> MenuItems { get; private set; }

        public Menu()
        {
            MenuItems = new[] {"A", "B", "C", "D", "E", "F"};
        }
    }
}
