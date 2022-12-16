using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Horse
{
    public partial class horse : Form
    {
        private int row = 0;
        private int column = 0;      
        private int index = 0;
        private Graphics g;
        private int[,] chessGround = new int[8, 8];
        private string[,] chess = new string[8, 8];

        public horse()
        {
            InitializeComponent();
        }

        private char checkAction(int i, int j, int goldFilds, char actions, char noActions)
        {
            int goldFild = goldFilds;
            char action = actions;

            if ((row - 2 > -1 && row - 2 < 8) && ( column - 1 > -1 && column - 1 < 8))
            {
                if (chessGround[row - 2, column - 1] < goldFild)
                {
                    if (noActions != 'A' && noActions < 'A')
                    {
                        action = 'A';
                        goldFild = chessGround[row - 2, column - 1];
                    }
                }
                index++;
            }
            if ((row -2>-1 && row - 2 < 8) && column +1 <8)
            {
                if (chessGround[row -2, column +1] < goldFild)
                {
                    if (noActions != 'B' && noActions < 'B')
                    {
                        action = 'B';
                        goldFild = chessGround[row - 2, column + 1];
                    }
                }
                index++;
            }

            if ((row - 1 > -1 && row - 1 < 8) && column + 2 < 8)
            {

                if (chessGround[row -1, column +2] < goldFild)
                {
                    if (noActions != 'C' && noActions < 'C')
                    {
                        action = 'C';
                        goldFild = chessGround[row - 1, column + 2];
                    }
                }
                index++;
            }
            if (row +1 < 8 && column + 2 < 8)
            {
                if (chessGround[row + 1, column + 2] < goldFild)
                {
                    if (noActions != 'D' && noActions < 'D')
                    {
                        action = 'D';
                        goldFild = chessGround[row + 1, column + 2];
                    }
                }
                index++;
            }
           
            if (row +2 <8 && column + 1 < 8)
            {
                if (chessGround[row + 2, column + 1] < goldFild)
                {
                    if (noActions != 'E' && noActions < 'E')
                    {
                        action = 'E';
                        goldFild = chessGround[row + 2, column + 1];
                    }
                }
                index++;
            }

            if (row + 2 < 8 && (column - 1 > -1 && column - 1 < 8))
            {
                if (chessGround[row + 2, column - 1] < goldFild)
                {
                    if (noActions != 'F' && noActions < 'F')
                    {
                        action = 'F';
                        goldFild = chessGround[row + 2, column - 1];
                    }
                }
                index++;
            }
            if (row + 1 < 8 && (column - 2 > -1 && column -2 < 8))
            {
                if (chessGround[row + 1, column - 2] < goldFild)
                {
                    if (noActions != 'G' && noActions < 'G')
                    {
                        action = 'G';
                        goldFild = chessGround[row + 1, column - 2];
                    }
                }
                index++;
            }       
            if ((row - 1 > -1 && row - 1 < 8) && (column - 2 > -1 && column -2 < 8))
            {
                if (chessGround[row - 1, column- 2] < goldFild)
                {
                    if (noActions != 'H' && noActions < 'H')
                    {
                        action = 'H';
                        goldFild = chessGround[row - 1, column - 2];
                    }
                }
                index++;
            }            
            return action;
        }

        private void selectAction(char act)
        {
            switch (act)
            {
                case 'A':
                    if ((row - 2 > -1 && row - 2 < 8) && (column - 1 > -1 && column - 1 < 8))
                    {
                        row = row - 2;
                        column = column - 1;
                    }
                    break;
                case 'B':
                    if ((row - 2 > -1 && row - 2 < 8) && column + 1 < 8)
                    {
                        row = row - 2;
                        column = column + 1;
                    }
                    break;
                case 'C':
                    if ((row - 1 > -1 && row - 1 < 8) && column + 2 < 8)
                    {
                        row = row - 1;
                        column = column + 2;
                    }
                    break;
                case 'D':
                    if (row + 1 < 8 && column + 2 < 8)
                    {
                        row = row + 1;
                        column = column + 2;
                    }
                    break;                               
                case 'E':
                    if (row + 2 < 8 && column + 1 < 8)
                    {
                        row = row + 2;
                        column = column + 1;
                    }
                    break;
                case 'F':
                    if (row + 2 < 8 && (column - 1 > -1 && column - 1 < 8))
                    {
                        row = row + 2;
                        column = column - 1;
                    }
                    break;
                case 'G':
                    if (row + 1 < 8 && (column - 2 > -1 && column - 2 < 8))
                    {
                        row = row + 1;
                        column = column - 2;
                    }
                    break;
                case 'H':
                    if ((row - 1 > -1 && row - 1 < 8) && (column - 2 > -1 && column - 2 < 8))
                    {
                        row = row - 1;
                        column = column - 2;
                    }
                    break;                
            }                        
        }

        private void BackAction(char act)
        {
            switch (act)
            {
                case 'A':
                    if ((row + 2 < 8) && (column + 1 < 8))
                    {
                        row = row + 2;
                        column = column + 1;
                    }
                    break;
                case 'B':
                    if ((row +2  < 8) && (column-1>-1 && column - 1 < 8))
                    {
                        row = row + 2;
                        column = column - 1;
                    }
                    break;
                case 'C':
                    if ((row + 1 < 8) && (column-2>-1 && column - 2 < 8))
                    {
                        row = row + 1;
                        column = column - 2;
                    }
                    break;
                case 'D':
                    if ((row -1 > -1 && row - 1 < 8) && (column -2 > -1 && column - 2 < 8))
                    {
                        row = row - 1;
                        column = column - 2;
                    }
                    break;
                case 'E':
                    if ((row - 2 > -1 && row - 2 < 8) && (column - 1 > -1 && column - 1 < 8))
                    {
                        row = row - 2;
                        column = column - 1;
                    }
                    break;
                case 'F':
                    if ((row - 2 > -1 && row - 2 < 8) && (column + 1 < 8))
                    {
                        row = row - 2;
                        column = column + 1;
                    }
                    break;
                case 'G':
                    if ((row - 1 > -1 && row - 1 < 8) && (column + 2 < 8))
                    {
                        row = row - 1;
                        column = column + 2;
                    }
                    break;
                case 'H':
                    if ((row + 1 < 8) && (column +  2 < 8))
                    {
                        row = row + 1;
                        column = column + 2;
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            

            #region define Variable

            char[] status = new char[64];
            string str = string.Empty;
            char action = ' ';
            int counter = 0;

            #endregion

            drawChessGround();

            #region set Default Array

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    row = i;
                    column = j;
                    index = 0;
                    checkAction(i, j, 0, ' ',' ');
                    chessGround[i, j] = index;
                }

            #endregion

            #region read Status Horse

            row = Convert.ToInt32(textBox1.Text);
            column = Convert.ToInt32(textBox2.Text);
            chessGround[row, column] = 9;

            #endregion

            #region actions Horse

            while (counter < 63)
            {
                index = 0;
                moveHorse(row, column);
                action = checkAction(row, column, 9, ' ', action);
                if (action != ' ')
                {
                    selectAction(action);
                    chessGround[row, column] = 9;
                    status[counter] = action;
                    action = ' ';
                    counter++;                    
                }
                else
                {                   
                    chessGround[row, column] = index;
                    backHorse(row, column);
                    counter--;
                    action = status[counter];
                    BackAction(action);                    
                }

            }

            #endregion 

            moveHorse(row, column);
        }

        private void moveHorse(int x, int y)
        {
            Form1 frm = new Form1();
            string str = string.Empty;

            frm.ShowDialog();    
            str = chess[x, y];
            x = Convert.ToInt32(str.Substring(0, str.IndexOf("-")));
            str = str.Remove(0, str.IndexOf("-")+1);
            y = Convert.ToInt32(str.Substring(0,str.IndexOf("-")));
            pictureBox1.Image = pictureBox1.Image;
            g = Graphics.FromImage(pictureBox1.Image);
            g.DrawImage(Horse.Properties.Resources.asb,x, y, 65, 65);            
            
        }
        
        private void backHorse(int x, int y)
        {
            string str = string.Empty;

            str = chess[x, y];
            x = Convert.ToInt32(str.Substring(0, str.IndexOf("-")));
            str = str.Remove(0, str.IndexOf("-") + 1);
            y = Convert.ToInt32(str.Substring(0,str.IndexOf("-") ));
            str = str.Remove(0, str.IndexOf("-") + 1);
            pictureBox1.Image = pictureBox1.Image;
            g = Graphics.FromImage(pictureBox1.Image);
            if (str == "b")
            {
                g.FillRectangle(Brushes.Black, x, y, 70, 70);
            }
            else
            {
                g.FillRectangle(Brushes.White, x, y, 70, 70);
            }
            //g.FillRectangle(Brushes.Tan, x, y, 65, 65);
           // g.ScaleTransform(x, y);
            //g.DrawImage(Horse.Properties.Resources.blanck, x, y, 65, 65);   
        }

        private void drawChessGround()
        {
            int x = 20;
            int y = 20;
            int color = 1;

            this.BackColor = Color.LightGray;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.DrawImage(Horse.Properties.Resources.chess_board, 0, 0, 600, 600);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (color % 2 == 0)
                    {
                        g.FillRectangle(Brushes.Black, x, y, 70, 70);
                        chess[i, j] = x + "-" + y+"-b";
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, x, y, 70, 70);
                        chess[i, j] = x + "-" + y+"-w";
                    }
                    //g.DrawRectangle(Pens.Transparent, x, y, 70, 70);                    
                    x += 70;
                    color++;
                }
                y += 70;
                x = 20;
                color++;
            }
        }

        private void horse_Load(object sender, EventArgs e)
        {
            drawChessGround();             
        }                 
    }
}
