using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        char[] positions = { '1', '2', '3', '4', '5', '6', '7', '8' };
        char[] moves = new char[9];
        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }


        public void Run()
        {
            var Tic = new TicTacToe();

            while (!Tic) ;
            if(boardPositions(0)== 'X')
            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 19);

            Console.Write("Player O");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);


            Console.SetCursorPosition(2, 19);

            Console.Write("Player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
             column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
        }

        





    public class xman
        //This is showing the different positions of "x" and "o" in the game xo. 
        //   0,0 -> 0
        //  0,1 -> 1
        //  0,2 -> 2
        //  1,0 -> 3
        //  1,1 -> 4
        //  1,2 -> 5
        // 2,0 -> 6 
        // 2,1 -> 7
        // 2,2 -> 8
        //There is 8 ways to win and 1 stalemate making 9 possible game results
        {

            
            //example 1,1 
            int row = 1,
            int column = 1,

                //A formula
            int x = (row * 3) + column;
            int o = (row * 3) + column;  
                
                2 * 3 + 1 -> 7
                //That is position 2,1
                if 0,0 -> 0
               
       
            











                




           

        {

        }

    }
}
