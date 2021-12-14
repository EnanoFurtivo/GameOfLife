using LifeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private Board board = null;
        private List<List<bool>> matrix = null;
        private LifeInput.FormInput inputForm = null;

        private int CellSize = 5;
        private int CellRows = 50;
        private int CellColumns = 50;

        private int generations = 0;
        private int alive = 0;
        private int dead = 0;
        private int deaths = 0;
        private int births = 0;

        private int initialWidth = 0;

        private bool paused = true;
        private bool updating = false;

        public Form1()
        {
            InitializeComponent();
            initialWidth = pictureBox1.Width;
            pauseCheckBox1.Checked = paused;
            pauseCheckBox2.Checked = paused;
            pauseCheckBox3.Checked = paused;
            widthNud.Value = CellColumns;
            heightNud.Value = CellRows;
            Reset();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) 
        { 
            this.Text = "Juego de la vida - " + tabControl1.SelectedTab.Text + " | Gen: " + generations; 
        }

        //Input form methods//
        private void openInputForm()
        {
            this.Hide();

            if (matrix != null && matrix.Count == CellRows && matrix[0].Count == CellColumns)
                inputForm = new LifeInput.FormInput(matrix, CellRows, CellColumns);
            else
                inputForm = new LifeInput.FormInput(CellRows, CellColumns);

            inputForm.Show();
            inputForm.LoadInput += setMatrix;
        }
        private void setMatrix(List<List<bool>> matrix) 
        { 
            this.matrix = matrix; 
            inputForm.Close();
            this.Show();
            Reset();
        }
        private void button50x50_Click(object sender, EventArgs e)
        {
            CellRows = 50;
            CellColumns = 50;
            Reset();
        }
        private void button20x40_Click(object sender, EventArgs e)
        {
            CellRows = 20;
            CellColumns = 40;
            Reset();
        }

        //Interface that requires refresh//
        private void ChangeButton_Click(object sender, EventArgs e) { openInputForm(); }
        private void ResetButton_Click(object sender, EventArgs e) { Reset(); }
        private void heightNud_ValueChanged(object sender, EventArgs e) { CellRows = (int)heightNud.Value; Reset(); }
        private void widthNud_ValueChanged(object sender, EventArgs e) { CellColumns = (int)widthNud.Value; Reset(); }

        //Timer methods//
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!updating && !paused)
            {
                board.Advance(ref generations, ref deaths, ref births, ref alive, ref dead);
                Render();
            }
        }
        private void delayNud_ValueChanged(object sender, EventArgs e) { timer1.Interval = (int)delayNud.Value; }
        private void updateCheckboxes()
        {
            pauseCheckBox1.Checked = paused;
            pauseCheckBox2.Checked = paused;
            pauseCheckBox3.Checked = paused;
        }
        private void pauseCheckBox1_CheckedChanged(object sender, EventArgs e) { paused = pauseCheckBox1.Checked; updateCheckboxes(); }
        private void pauseCheckBox2_CheckedChanged(object sender, EventArgs e) { paused = pauseCheckBox2.Checked; updateCheckboxes(); }
        private void pauseCheckBox3_CheckedChanged(object sender, EventArgs e) { paused = pauseCheckBox3.Checked; updateCheckboxes(); }

        //Render methods//
        private void Reset()
        {
            updating = true;

            CellsLabel.Text = "Celdas: " + CellColumns * CellRows;
            CellSize = initialWidth / CellColumns;

            pictureBox1.SetBounds(pictureBox1.Location.X, pictureBox1.Location.Y, CellColumns * CellSize, CellRows * CellSize);
            board = new Board(pictureBox1.Width, pictureBox1.Height, CellSize, ref deaths, ref births, ref alive, ref dead);

            if (matrix == null || CellRows != matrix.Count() || CellColumns != matrix[0].Count())
                board.Randomize(0.25, ref births, ref alive, ref dead);
            else
                board.setPattern(matrix, ref births, ref alive, ref dead);

            Render();

            updating = false;
        }
        private void Render()
        {
            using (var bmp = new Bitmap(board.Width, board.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var brush = new SolidBrush(Color.LightGreen))
            {
                gfx.Clear(ColorTranslator.FromHtml("#2f3539"));

                var cellSize = (board.CellSize > 1) ?
                                new Size(board.CellSize - 1, board.CellSize - 1) :
                                new Size(board.CellSize, board.CellSize);

                for (int col = 0; col < board.Columns; col++)
                {
                    for (int row = 0; row < board.Rows; row++)
                    {
                        var cell = board.Cells[col, row];
                        if (cell.IsAlive)
                        {
                            var cellLocation = new Point(col * board.CellSize, row * board.CellSize);
                            var cellRect = new Rectangle(cellLocation, cellSize);
                            gfx.FillRectangle(brush, cellRect);
                        }
                    }
                }

                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Bitmap)bmp.Clone();
            }

            printStatus();
        }
        private void printStatus()
        {
            this.Text = "Juego de la vida - " + tabControl1.SelectedTab.Text + " | Gen: " + generations;
            GenerationsLabel.Text = "Generaciones: " + generations;
            BirthsLabel.Text = "Nacimientos: " + births;
            DeathsLabel.Text = "Muertes: " + deaths;
            AliveLabel.Text = "Vivas: " + alive;
            DeadLabel.Text = "Muertas: " + dead;
        }

    }
}
