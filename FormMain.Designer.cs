namespace Lite_M_Up
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableBoard = new System.Windows.Forms.TableLayoutPanel();
            this.panelContainer_Board = new System.Windows.Forms.Panel();
            this.panelContainer_Board.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableBoard
            // 
            this.tableBoard.ColumnCount = 2;
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBoard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableBoard.Location = new System.Drawing.Point(0, 0);
            this.tableBoard.Margin = new System.Windows.Forms.Padding(5);
            this.tableBoard.Name = "tableBoard";
            this.tableBoard.RowCount = 2;
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBoard.Size = new System.Drawing.Size(400, 400);
            this.tableBoard.TabIndex = 0;
            // 
            // panelContainer_Board
            // 
            this.panelContainer_Board.Controls.Add(this.tableBoard);
            this.panelContainer_Board.Location = new System.Drawing.Point(12, 103);
            this.panelContainer_Board.Name = "panelContainer_Board";
            this.panelContainer_Board.Size = new System.Drawing.Size(400, 400);
            this.panelContainer_Board.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 515);
            this.Controls.Add(this.panelContainer_Board);
            this.Name = "FormMain";
            this.Text = "Lite M Up";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelContainer_Board.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableBoard;
        private System.Windows.Forms.Panel panelContainer_Board;
    }
}

