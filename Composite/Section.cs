using DocumentManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Section : IDocumentComponent
    {
        private string _header;
        private List<IDocumentComponent> _components = new List<IDocumentComponent>();

        public Section(string header)
        {
            _header = header;
        }

        public void Add(IDocumentComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IDocumentComponent component)
        {
            _components.Remove(component);
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 4)}{_header}");
            foreach (var component in _components)
            {
                component.Display(depth + 1);
            }
        }

    }

}
