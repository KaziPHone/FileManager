using System;

namespace FileManager
{
    public class ConsoleUi
    {

        private int _consoleHeight = 40;
        private int _consoleWidth = 90;
        
        /*private const int ConsoleHeightMAX = 100;
        private const int ConsoleHeightMIN = 100;
        private const int ConsoleWidthMIN = 100;
        private const int ConsoleWidthMAXN = 100;
        private const int ConsoleHeightDefault = 100;
        
        public int ConsoleHeight { get; set; }
        public int ConsoleWidth { get; set; }
        
        */

        public void CreateWindow()
        {
            SetWindowSize();
            DrawWalls();
        }

        /// <summary>
        /// Задаем размер окна
        /// </summary>
        private void SetWindowSize()
        {
            Console.SetWindowSize(_consoleWidth + 1, _consoleHeight + 1);
        }

        /// <summary>
        /// Рисуем диалоговые окна
        /// </summary>
        private void DrawWalls()
        {
            string rightUpCornerLine = "╔";
            string rightBottomCornerLine = "╚";
            string leftUpCornerLine = "╗";
            string leftBottomCornerLine = "╝";
            string verticalLine = "║";
            string horizontalLine = "═";
            //Рисуем углы
            Console.SetCursorPosition(0, 0);
            Console.Write(rightUpCornerLine);
            Console.SetCursorPosition(_consoleWidth, 0);
            Console.Write(leftUpCornerLine);
            Console.SetCursorPosition(0, _consoleHeight);
            Console.Write(rightBottomCornerLine);
            Console.SetCursorPosition(_consoleWidth, _consoleHeight);
            Console.Write(leftBottomCornerLine);           
            
            //Рисуем левую и правую стенку
            for (int i = 1; i < _consoleHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(verticalLine);
                
                Console.SetCursorPosition(_consoleWidth, i);
                Console.Write(verticalLine);
            }

            //Рисуем верхнюю и нижнюю стенки стенки
            for (int i = 1; i < _consoleWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(horizontalLine);
                
                Console.SetCursorPosition(i, _consoleHeight);
                Console.Write(horizontalLine);
                
                Console.SetCursorPosition(i, _consoleHeight - 2);
                Console.Write(horizontalLine);
                
                Console.SetCursorPosition(i, _consoleHeight - 16);
                Console.Write(horizontalLine);
            }
            
        }
        
    }
}