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
            this.newGame_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeSq_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourSq_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveSq_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theme_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTheme_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redBlackTheme_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jediSithTheme_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBorderContainer = new System.Windows.Forms.Panel();
            this.panelScoreGlobal = new System.Windows.Forms.Panel();
            this.textBoxScoreGlobal = new System.Windows.Forms.TextBox();
            this.labelScoreGlobal = new System.Windows.Forms.Label();
            this.textBoxScoreCurrent = new System.Windows.Forms.TextBox();
            this.labelScoreCurrent = new System.Windows.Forms.Label();
            this.panelScoreCurrent = new System.Windows.Forms.Panel();
            this.panelContainer_Board.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelScoreGlobal.SuspendLayout();
            this.panelScoreCurrent.SuspendLayout();
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
            this.panelContainer_Board.Location = new System.Drawing.Point(157, 69);
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
            // newGame_ToolStripMenuItem
            // 
            this.newGame_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threeSq_ToolStripMenuItem,
            this.fourSq_ToolStripMenuItem,
            this.fiveSq_ToolStripMenuItem});
            this.newGame_ToolStripMenuItem.Name = "newGame_ToolStripMenuItem";
            this.newGame_ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGame_ToolStripMenuItem.Text = "New Game";
            // 
            // threeSq_ToolStripMenuItem
            // 
            this.threeSq_ToolStripMenuItem.Name = "threeSq_ToolStripMenuItem";
            this.threeSq_ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.threeSq_ToolStripMenuItem.Text = "3 x 3";
            this.threeSq_ToolStripMenuItem.Click += new System.EventHandler(this.threeSq_ToolStripMenuItem_Click);
            // 
            // fourSq_ToolStripMenuItem
            // 
            this.fourSq_ToolStripMenuItem.Name = "fourSq_ToolStripMenuItem";
            this.fourSq_ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.fourSq_ToolStripMenuItem.Text = "4 x 4";
            this.fourSq_ToolStripMenuItem.Click += new System.EventHandler(this.fourSq_ToolStripMenuItem_Click);
            // 
            // fiveSq_ToolStripMenuItem
            // 
            this.fiveSq_ToolStripMenuItem.Name = "fiveSq_ToolStripMenuItem";
            this.fiveSq_ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.fiveSq_ToolStripMenuItem.Text = "5 x 5";
            this.fiveSq_ToolStripMenuItem.Click += new System.EventHandler(this.fiveSq_ToolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exit_ToolStripMenuItem.Text = "Exit";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // theme_ToolStripMenuItem
            // 
            this.theme_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultTheme_ToolStripMenuItem,
            this.redBlackTheme_ToolStripMenuItem,
            this.jediSithTheme_ToolStripMenuItem});
            this.theme_ToolStripMenuItem.Name = "theme_ToolStripMenuItem";
            this.theme_ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.theme_ToolStripMenuItem.Text = "Theme";
            // 
            // defaultTheme_ToolStripMenuItem
            // 
            this.defaultTheme_ToolStripMenuItem.Name = "defaultTheme_ToolStripMenuItem";
            this.defaultTheme_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.defaultTheme_ToolStripMenuItem.Text = "Default";
            this.defaultTheme_ToolStripMenuItem.Click += new System.EventHandler(this.defaultTheme_ToolStripMenuItem_Click);
            // 
            // redBlackTheme_ToolStripMenuItem
            // 
            this.redBlackTheme_ToolStripMenuItem.Name = "redBlackTheme_ToolStripMenuItem";
            this.redBlackTheme_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.redBlackTheme_ToolStripMenuItem.Text = "Red / Black";
            this.redBlackTheme_ToolStripMenuItem.Click += new System.EventHandler(this.redBlackTheme_ToolStripMenuItem_Click);
            // 
            // jediSithTheme_ToolStripMenuItem
            // 
            this.jediSithTheme_ToolStripMenuItem.Name = "jediSithTheme_ToolStripMenuItem";
            this.jediSithTheme_ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.jediSithTheme_ToolStripMenuItem.Text = "Jedi / Sith";
            this.jediSithTheme_ToolStripMenuItem.Click += new System.EventHandler(this.jediSithTheme_ToolStripMenuItem_Click);
            // 
            // panelBorderContainer
            // 
            this.panelBorderContainer.Location = new System.Drawing.Point(154, 66);
            this.panelBorderContainer.Name = "panelBorderContainer";
            this.panelBorderContainer.Size = new System.Drawing.Size(406, 406);
            this.panelBorderContainer.TabIndex = 3;
            // 
            // panelScoreGlobal
            // 
            this.panelScoreGlobal.Controls.Add(this.textBoxScoreGlobal);
            this.panelScoreGlobal.Controls.Add(this.labelScoreGlobal);
            this.panelScoreGlobal.Location = new System.Drawing.Point(26, 219);
            this.panelScoreGlobal.Name = "panelScoreGlobal";
            this.panelScoreGlobal.Size = new System.Drawing.Size(108, 102);
            this.panelScoreGlobal.TabIndex = 4;
            // 
            // textBoxScoreGlobal
            // 
            this.textBoxScoreGlobal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxScoreGlobal.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxScoreGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScoreGlobal.Location = new System.Drawing.Point(0, 67);
            this.textBoxScoreGlobal.Name = "textBoxScoreGlobal";
            this.textBoxScoreGlobal.ReadOnly = true;
            this.textBoxScoreGlobal.Size = new System.Drawing.Size(108, 23);
            this.textBoxScoreGlobal.TabIndex = 1;
            this.textBoxScoreGlobal.TabStop = false;
            this.textBoxScoreGlobal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelScoreGlobal
            // 
            this.labelScoreGlobal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScoreGlobal.AutoSize = true;
            this.labelScoreGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreGlobal.Location = new System.Drawing.Point(22, 20);
            this.labelScoreGlobal.Name = "labelScoreGlobal";
            this.labelScoreGlobal.Size = new System.Drawing.Size(57, 44);
            this.labelScoreGlobal.TabIndex = 0;
            this.labelScoreGlobal.Text = "Best\r\nScore";
            this.labelScoreGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxScoreCurrent
            // 
            this.textBoxScoreCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxScoreCurrent.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxScoreCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScoreCurrent.Location = new System.Drawing.Point(0, 67);
            this.textBoxScoreCurrent.Name = "textBoxScoreCurrent";
            this.textBoxScoreCurrent.ReadOnly = true;
            this.textBoxScoreCurrent.Size = new System.Drawing.Size(108, 23);
            this.textBoxScoreCurrent.TabIndex = 1;
            this.textBoxScoreCurrent.TabStop = false;
            this.textBoxScoreCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelScoreCurrent
            // 
            this.labelScoreCurrent.AutoSize = true;
            this.labelScoreCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreCurrent.Location = new System.Drawing.Point(22, 20);
            this.labelScoreCurrent.Name = "labelScoreCurrent";
            this.labelScoreCurrent.Size = new System.Drawing.Size(70, 44);
            this.labelScoreCurrent.TabIndex = 0;
            this.labelScoreCurrent.Text = "Current\r\nScore";
            this.labelScoreCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelScoreCurrent
            // 
            this.panelScoreCurrent.Controls.Add(this.textBoxScoreCurrent);
            this.panelScoreCurrent.Controls.Add(this.labelScoreCurrent);
            this.panelScoreCurrent.Location = new System.Drawing.Point(581, 219);
            this.panelScoreCurrent.Name = "panelScoreCurrent";
            this.panelScoreCurrent.Size = new System.Drawing.Size(108, 102);
            this.panelScoreCurrent.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 515);
            this.Controls.Add(this.panelScoreCurrent);
            this.Controls.Add(this.panelScoreGlobal);
            this.Controls.Add(this.panelContainer_Board);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelBorderContainer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Lite M Up";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelContainer_Board.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelScoreGlobal.ResumeLayout(false);
            this.panelScoreGlobal.PerformLayout();
            this.panelScoreCurrent.ResumeLayout(false);
            this.panelScoreCurrent.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem defaultTheme_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redBlackTheme_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jediSithTheme_ToolStripMenuItem;
        private System.Windows.Forms.Panel panelBorderContainer;
        private System.Windows.Forms.Panel panelScoreGlobal;
        private System.Windows.Forms.Label labelScoreGlobal;
        private System.Windows.Forms.TextBox textBoxScoreGlobal;
        private System.Windows.Forms.TextBox textBoxScoreCurrent;
        private System.Windows.Forms.Label labelScoreCurrent;
        private System.Windows.Forms.Panel panelScoreCurrent;
    }
}

