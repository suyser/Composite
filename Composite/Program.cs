using Composite;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using static System.Collections.Specialized.BitVector32;

namespace DocumentManagementSystem
{
    public interface IDocumentComponent
    {
        void Add(IDocumentComponent component);
        void Remove(IDocumentComponent component);
        void Display(int depth = 0);
    }
}
    public class Program
    {
        

        public static void Main(string[] args)
        {
            // Создаем документ
            var document = new Composite.Document();

            // Создаем разделы
            var section1 = new Composite.Section("Введение");
            var section2 = new Composite.Section("Глава 1");
            var section3 = new Composite.Section("Глава 2");

            // Создаем параграфы
            var paragraph1 = new Paragraph("Первый параграф введения.");
            var paragraph2 = new Paragraph("Второй параграф введения.");
            var paragraph3 = new Paragraph("Первый параграф Главы 1.");
            var paragraph4 = new Paragraph("Второй параграф Главы 1.");
            var paragraph5 = new Paragraph("Первый параграф Главы 2.");

            // Добавляем компоненты в разделы
            section1.Add(paragraph1);
            section1.Add(paragraph2);
            section2.Add(paragraph3);
            section2.Add(paragraph4);
            section3.Add(paragraph5);

            // Добавляем разделы в документ
            document.Add(section1);
            document.Add(section2);
            document.Add(section3);

            // Выводим структуру документа
            Console.WriteLine("Структура документа:");
            document.Display();
        }
    }
