using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public enum Colors
    {
        yellow,
        red,
        green,
        blue,
        pink
    }
    public class Game
    {
        public Colors[,] Pole { get; private set; }
        bool play;
        void Init(int n)
        {
            Pole = new Colors[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Pole[j, i] = (Colors)(i % n);
                }
            }
        }
        void Quadr(int Row, int Column)
        {
            if(Row>0&&Row<4&&Column>0&&Column<4)
            {
                Colors T = Pole[Row - 1, Column];
                Pole[Row - 1, Column] = Pole[Row, Column - 1];
                Pole[Row, Column - 1] = Pole[Row + 1, Column];
                Pole[Row + 1, Column] = Pole[Row, Column + 1];
                Pole[Row, Column + 1] = T;

                T = Pole[Row - 1, Column + 1];
                Pole[Row - 1, Column + 1] = Pole[Row - 1, Column - 1];
                Pole[Row - 1, Column - 1] = Pole[Row + 1, Column - 1];
                Pole[Row + 1, Column - 1] = Pole[Row + 1, Column + 1];
                Pole[Row + 1, Column + 1] = T;
            }
        }
        void QuadrBack(int Row, int Column)
        {
            for (int i = 0; i < 3; i++)
                Quadr(Row, Column);
        }
        public bool Click(bool left, int Row, int Column)
        {
            if(play)
            {
                if (left)
                    Quadr(Row, Column);
                else
                    QuadrBack(Row, Column);
                if (CheckWin())
                    play = false;
            }
            return !play;
        }
        bool CheckWin()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Pole[j, i] != Pole[j + 1, i])
                        return false;
                }
            }
            return true;
        }
        void Randomize(int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                Quadr(rnd.Next(1, 4), rnd.Next(1, 4));
            }
        }
        public Game()
        {
            Init(2);
            play = true;
            Randomize(2);
        }
        public void NewGame(int Level)
        {
            Init(Level + 1);
            Randomize(500);
            play = true;
        }
    }
}
