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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theme_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeSq_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourSq_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveSq_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer_Board.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.theme_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // theme_ToolStripMenuItem
            // 
            this.theme_ToolStripMenuItem.Name = "theme_ToolStripMenuItem";
            this.theme_ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.theme_ToolStripMenuItem.Text = "Theme";
            // 
            // newGame_ToolStripMenuItem
            // 
            this.newGame_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threeSq_ToolStripMenuItem,
            this.fourSq_ToolStripMenuItem,
            this.fiveSq_ToolStripMenuItem});
            this.newGame_ToolStripMenuItem.Name = "newGame_ToolStripMenuItem";
            this.newGame_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGame_ToolStripMenuItem.Text = "New Game";
            // 
            // threeSq_ToolStripMenuItem
            // 
            this.threeSq_ToolStripMenuItem.Name = "threeSq_ToolStripMenuItem";
            this.threeSq_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.threeSq_ToolStripMenuItem.Text = "3 x 3";
            // 
            // fourSq_ToolStripMenuItem
            // 
            this.fourSq_ToolStripMenuItem.Name = "fourSq_ToolStripMenuItem";
            this.fourSq_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fourSq_ToolStripMenuItem.Text = "4 x 4";
            // 
            // fiveSq_ToolStripMenuItem
            // 
            this.fiveSq_ToolStripMenuItem.Name = "fiveSq_ToolStripMenuItem";
            this.fiveSq_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fiveSq_ToolStripMenuItem.Text = "5 x 5";
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exit_ToolStripMenuItem.Text = "Exit";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 515);
            this.Controls.Add(this.panelContainer_Board);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Lite M Up";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelContainer_Board.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableBoard;
        private System.Windows.Forms.Panel panelContainer_Board;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGame_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeSq_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourSq_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiveSq_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theme_ToolStripMenuItem;
    }
}

