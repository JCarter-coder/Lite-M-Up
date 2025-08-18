using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLMU;

namespace Lite_M_Up
{
    public partial class FormMain : Form
    {
        public GameMatrix LightBoard = new GameMatrix(3); // Initialize a 3x3 game matrix
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            var row = LightBoard.Matrix.GetLength(0);
            var col = LightBoard.Matrix.GetLength(1);
            
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    sb.Append(LightBoard.Matrix[r, c] ? "1 " : "0 ");
                }
                sb.AppendLine();
            }

            string message = sb.ToString();
            MessageBox.Show(message);
        }
    }
}
