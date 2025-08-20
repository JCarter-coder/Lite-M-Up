using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLMU;
using MusicMP3;

namespace Lite_M_Up
{
    public partial class FormMain : Form
    {
        public GameMatrix LightBoard; // = new GameMatrix(3); // Initialize a 3x3 game matrix

        public MP3Player MusicPlayer = new MP3Player(); // Create an instance of the MP3 player

        public List<string> _musicFiles;

        private int _songIndex = 5; // Default song index for the music player

        private int _matrixSize = 3; // Default matrix size

        private bool _firstLoad = true; // Flag to check if the form is loaded for the first time

        public Color onColor = Color.Yellow; // Color for the "on" state of the tiles

        public Color offColor = Color.DarkSeaGreen; // Color for the "off" state of the tiles

        public FormMain()
        {
            InitializeComponent();
        }

        // A dictionary to hold the buttons for each cell in the matrix
        private readonly Dictionary<(int r, int c), Button> _buttons = new Dictionary<(int r, int c), Button>();

        private void GenerateBoard()
        {
            // Generate the game board based on the matrix size
            // Future iterations of this should allow to adjust the board size
            // Initialize the game matrix with the specified size
            LightBoard = new GameMatrix(_matrixSize); 
            var m = LightBoard.Matrix;
            int rows = m.GetLength(0);
            int cols = m.GetLength(1);

            // Clear the existing controls in the table layout
            tableBoard.SuspendLayout();
            tableBoard.Controls.Clear();

            // Create tiles within the table for each cell in the given matrix
            tableBoard.RowCount = rows;
            tableBoard.ColumnCount = cols;

            // Clear existing row and column styles to reset the table layout
            tableBoard.RowStyles.Clear();
            tableBoard.ColumnStyles.Clear();

            // Calculate the percentage for each row and column
            float rowPercent = 100f / rows;
            float colPercent = 100f / cols;

            for (int r = 0; r < rows; r++)
            {
                // This sizes each row as a percentage of the total height of the table
                tableBoard.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercent));
            }
            for (int c = 0; c < cols; c++)
            {
                // This sizes each col as a percentage of the total width of the table
                tableBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colPercent));
            }

            // Clear the dictionary of buttons
            _buttons.Clear(); 

            // Create buttons for each cell in the matrix
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    // Set the button properties to each cell in this table board
                    Button btn = new Button
                    {
                        // Fill the button in the cell
                        Dock = DockStyle.Fill,

                        Margin = new Padding(3),

                        // Set the button's flat style to flat
                        FlatStyle = FlatStyle.Flat,

                        // Don't allow the button to receive focus by tabbing through them
                        TabStop = false,
                        
                        // Using text for visual development purposes only
                        // Display 1 for true, 0 for false
                        //Text = m[r, c] ? "1" : "0", 

                        // Store the position in the button's Tag
                        Tag = (r, c) 
                    };

                    // Set the button's background color
                    btn.BackColor = ColorChange(m[r, c]);
                    // Attach click event handler
                    btn.Click += Tile_Click;
                    // Add the button to the dictionary with its position as the key
                    _buttons[(r, c)] = btn;
                    // Add created button to the table layout
                    tableBoard.Controls.Add(btn, c, r); 
                }
                // Continue to the next row
                tableBoard.ResumeLayout();
            }
        }

        // A list of tuples representing the cell and corresponding neighbors in the matrix
        private static readonly (int dictR, int dictC)[] Neighbors = new[]
        {
            (0, 0), // Current cell
            (-1, 0), // Up
            (1, 0),  // Down
            (0, -1), // Left
            (0, 1)   // Right
        };

        // Toggle the cell and its neighbors when a button is clicked
        private void ToggleCells(int r, int c)
        {
            foreach (var (dictR, dictC) in Neighbors)
            {
                IsInBounds(r + dictR, c + dictC);
            }
        }

        // Check if the cell is within the bounds of the matrix
        private void IsInBounds(int r, int c)
        {
            var m = LightBoard.Matrix;
            // If the row or column is out of bounds, return out of this method
            if (r < 0 || r >= m.GetLength(0) || c < 0 || c >= m.GetLength(1)) return;
            // Otherwise, toggle the cell's value
            m[r, c] = !m[r, c]; 
        }

        // Handle the click event for each tile
        private void Tile_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                var n = LightBoard.Matrix.GetLength(0); // Get the size of the matrix
                // Get the button that was clicked
                var (r, c) = ((int r, int c))btn.Tag;
                // Toggle the value of the cell
                ToggleCells(r, c);
                SyncBoardUpdates(r, c);                           
            }

            // CHECK FOR WIN CONDITION

            // If all tiles are turned on, show a message box
            if (LightBoard.Matrix.Cast<bool>().All(x => x))
            {
                GameWin();
            }
        }

        // A method to handle the game win condition
        private void GameWin()
        {
            // Stop the music when the game is won
            MusicPlayer.Stop();
            // Play an ending song (game-8-bit-on-short)
            // Change the loop to false so ending doesn't repeat
            MusicPlayer.ChangeLoop(false);
            // Play the ending song (index 4 in the music files)
            _songIndex = 4;
            MusicPlayer.Play(_musicFiles[_songIndex]);
            // Show a message box to congratulate the player
            MessageBox.Show(
                "Congratulations! You completed the puzzle!",
                "Lite M Up (v1.0)",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            MusicPlayer.Stop();
        }

        // Sync the attributes in the button with the matrix
        private void SyncTile(int r, int c)
        {
            var m = LightBoard.Matrix;
            if (_buttons.TryGetValue((r, c), out Button btn))
            {
                // Update the button's text and color based on the matrix value
                //btn.Text = m[r, c] ? "1" : "0";
                btn.BackColor = ColorChange(m[r, c]);
            }
        }

        // Sync the board updates by toggling the cell and its neighbors
        private void SyncBoardUpdates(int r, int c)
        {
            foreach (var (dr, dc) in Neighbors)
            {
                SyncTile(r + dr, c + dc);
            }
        }

        // A method to change the color of the button based on its state
        // Make hard coded colors changable when themes are added
        private Color ColorChange(bool on) => on ? onColor : offColor;

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Set the form's background color
            this.BackColor = Color.FromArgb(0, 15, 15);

            GenerateBoard();
            // Build path to the music files
            string musicFilesPath = Path.Combine(Application.StartupPath, "Resources", "MP3_library");
            // Check if the music directory exists
            if (Directory.Exists(musicFilesPath))
            {
                // Get all mp3 files in the directory and form a list
                _musicFiles = Directory
                    .EnumerateFiles(musicFilesPath, "*.mp3", SearchOption.TopDirectoryOnly)
                    .ToList();
            }
            else
            {
                _musicFiles = new List<string>();
            }

            if (_firstLoad)
            {
                // Show a welcome message only on the first load
                ShowWelcomeMessage();
            }

            // Begin playing the main background music in loop mode
            MusicPlayer.ChangeLoop(true);
            MusicPlayer.Play(_musicFiles[_songIndex]);
        }

        private void ShowWelcomeMessage()
        {
            // Set the flag to false after the first load
            _firstLoad = false;

            // Introduction sound (8-bit-logo)
            _songIndex = 2; 
            // Change the loop to false so intro sound doesn't repeat
            MusicPlayer.ChangeLoop(false);
            MusicPlayer.Play(_musicFiles[_songIndex]);

            // Set the flag to false after the first load
            // Show a welcome message only on the first load
            MessageBox.Show(
                "Welcome to Lite M Up!\n" +
                "Click on the tiles to toggle them on and off.\n" +
                "The goal is to turn all tiles on.\n" +
                "Enjoy this puzzle!",
                "Lite M Up (v1.0)",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Stop the introductory music before starting the main music
            MusicPlayer.Stop();
            // Default music (SLOWER-TEMPO2019)
            _songIndex = 5;
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stop the music before exiting the application
            MusicPlayer.Stop();
            // Close the application
            Application.Exit();
        }

        // User can select the matrix size from the menu

        private void threeSq_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Default level with 3x3 matrix
            _matrixSize = 3;
            // Stop the music before reloading the board
            MusicPlayer.Stop();
            // Default music (SLOWER-TEMPO2019)
            _songIndex = 5;
            // Reload the form to generate the board with the new matrix size
            FormMain_Load(sender, e);
        }

        private void fourSq_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Medium level with 4x4 matrix
            _matrixSize = 4;
            MusicPlayer.Stop();
            // Medium music (Land_of_8_bits)
            _songIndex = 0;
            // Reload the form to generate the board with the new matrix size
            FormMain_Load(sender, e);
        }

        private void fiveSq_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hardest level with 5x5 matrix
            _matrixSize = 5;
            MusicPlayer.Stop();
            // Hard music (fight-for-the-future)
            _songIndex = 3;
            // Reload the form to generate the board with the new matrix size
            FormMain_Load(sender, e);
        }
    }
}
