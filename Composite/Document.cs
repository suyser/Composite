using DocumentManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Document : IDocumentComponent
    {
        private List<Section> _sections = new List<Section>();

        public void Add(IDocumentComponent component)
        {
            if (component is Section section)
            {
                _sections.Add(section);
            }
            else
            {
                throw new ArgumentException("Document can only contain sections.");
            }
        }

        public void Remove(IDocumentComponent component)
        {
            if (component is Section section)
            {
                _sections.Remove(section);
            }
            else
            {
                throw new ArgumentException("Document can only contain sections.");
            }
        }

        public void Display(int depth = 0)
        {
            foreach (var section in _sections)
            {
                section.Display(depth);
            }
        }

    }
}
