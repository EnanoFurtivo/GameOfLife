using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeInput
{
    public delegate void LoadInputEvent(List<List<bool>> matrix);

    public partial class FormInput : Form
    {
        public event LoadInputEvent LoadInput;

        private List<List<CheckBox>> CheckBoxes = new List<List<CheckBox>>();
        private List<List<bool>> matrix = null;

        private int ColumnCount;
        private int RowCount;
        private bool passedMatrix = false;

        private int vOffset = 43;
        private int hOffset = 20;
        private int buttonOffset = 30;

        public FormInput(List<List<bool>> matrix, int rows, int columns)
        {
            passedMatrix = true;
            ColumnCount = columns;
            RowCount = rows;
            this.matrix = matrix;
            InitializeForm();
        }
        public FormInput(int rows, int columns)
        {
            ColumnCount = columns;
            RowCount = rows;
            matrix = new List<List<bool>>();
            InitializeForm();
        }
        private void InitializeForm()
        {
            InitializeComponent();

            for (int row = 0; row < RowCount; row++)
            {
                if (!passedMatrix) matrix.Add(new List<bool>());
                CheckBoxes.Add(new List<CheckBox>());

                for (int column = 0; column < ColumnCount; column++)
                {
                    if (!passedMatrix) matrix[row].Add(false);

                    CheckBoxes[row].Add(new CheckBox());
                    if (passedMatrix) CheckBoxes[row][column].Checked = matrix[row][column];
                    CheckBoxes[row][column].Height = 13;
                    CheckBoxes[row][column].Width = 13;
                    CheckBoxes[row][column].Location = new Point(column * 13, (row * 13) + buttonOffset);
                    CheckBoxes[row][column].CheckedChanged += new EventHandler(ShowCheckedCheckboxes);

                    this.Controls.Add(CheckBoxes[row][column]);
                }
            }

            this.Size = new Size((ColumnCount * 13) + hOffset, (RowCount * 13) + vOffset + buttonOffset);
        }
        private void ShowCheckedCheckboxes(object sender, EventArgs e)
        {
            for (int row = 0; row < RowCount; row++)
                for (int column = 0; column < ColumnCount; column++)
                    matrix[row][column] = CheckBoxes[row][column].Checked;
        }
        private void button1_Click(object sender, EventArgs e) { LoadInput?.Invoke(matrix); }
    }
}
