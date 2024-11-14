using DocumentManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Paragraph : IDocumentComponent
    {
        private string _text;

        public Paragraph(string text)
        {
            _text = text;
        }

        public void Add(IDocumentComponent component)
        {
            throw new NotImplementedException("Параграф не может иметь дочерних элементов.");
        }

        public void Remove(IDocumentComponent component)
        {
            throw new NotImplementedException("Параграф не может иметь дочерних элементов.");
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 4)}{_text}");
        }
    }
}
