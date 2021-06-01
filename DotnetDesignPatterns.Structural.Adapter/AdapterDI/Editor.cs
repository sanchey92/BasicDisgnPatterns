using System.Collections.Generic;

namespace DotnetDesignPatterns.Structural.Adapter.AdapterDI
{
    public class Editor
    {
        public Editor(IEnumerable<Button> buttons)
        {
            Buttons = buttons;
        }

        public IEnumerable<Button> Buttons { get; }

        public void ClickAll()
        {
            foreach (var button in Buttons)
                button.Click();
            
        }
        
    }
}