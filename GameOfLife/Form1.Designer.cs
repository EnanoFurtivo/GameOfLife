namespace GameOfLife
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.heightNud = new System.Windows.Forms.NumericUpDown();
            this.delayNud = new System.Windows.Forms.NumericUpDown();
            this.widthNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerationsLabel = new System.Windows.Forms.Label();
            this.pauseCheckBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button50x50 = new System.Windows.Forms.Button();
            this.button20x40 = new System.Windows.Forms.Button();
            this.pauseCheckBox2 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CellsLabel = new System.Windows.Forms.Label();
            this.pauseCheckBox3 = new System.Windows.Forms.CheckBox();
            this.DeadLabel = new System.Windows.Forms.Label();
            this.AliveLabel = new System.Windows.Forms.Label();
            this.BirthsLabel = new System.Windows.Forms.Label();
            this.DeathsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 453);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(88, 6);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(170, 25);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(264, 6);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(163, 25);
            this.ChangeButton.TabIndex = 3;
            this.ChangeButton.Text = "Cambiar input";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // heightNud
            // 
            this.heightNud.Enabled = false;
            this.heightNud.Location = new System.Drawing.Point(123, 9);
            this.heightNud.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heightNud.Name = "heightNud";
            this.heightNud.Size = new System.Drawing.Size(49, 20);
            this.heightNud.TabIndex = 2;
            this.heightNud.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.heightNud.Visible = false;
            this.heightNud.ValueChanged += new System.EventHandler(this.heightNud_ValueChanged);
            // 
            // delayNud
            // 
            this.delayNud.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayNud.Location = new System.Drawing.Point(370, 9);
            this.delayNud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delayNud.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delayNud.Name = "delayNud";
            this.delayNud.Size = new System.Drawing.Size(49, 20);
            this.delayNud.TabIndex = 4;
            this.delayNud.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.delayNud.ValueChanged += new System.EventHandler(this.delayNud_ValueChanged);
            // 
            // widthNud
            // 
            this.widthNud.Enabled = false;
            this.widthNud.Location = new System.Drawing.Point(237, 9);
            this.widthNud.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.widthNud.Name = "widthNud";
            this.widthNud.Size = new System.Drawing.Size(49, 20);
            this.widthNud.TabIndex = 3;
            this.widthNud.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.widthNud.Visible = false;
            this.widthNud.ValueChanged += new System.EventHandler(this.widthNud_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delay (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(89, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filas";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(178, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Columnas";
            this.label3.Visible = false;
            // 
            // GenerationsLabel
            // 
            this.GenerationsLabel.AutoSize = true;
            this.GenerationsLabel.Location = new System.Drawing.Point(92, 5);
            this.GenerationsLabel.Name = "GenerationsLabel";
            this.GenerationsLabel.Size = new System.Drawing.Size(85, 13);
            this.GenerationsLabel.TabIndex = 9;
            this.GenerationsLabel.Text = "Generaciones: 0";
            // 
            // pauseCheckBox1
            // 
            this.pauseCheckBox1.AutoSize = true;
            this.pauseCheckBox1.Location = new System.Drawing.Point(8, 10);
            this.pauseCheckBox1.Name = "pauseCheckBox1";
            this.pauseCheckBox1.Size = new System.Drawing.Size(59, 17);
            this.pauseCheckBox1.TabIndex = 1;
            this.pauseCheckBox1.Text = "Pausar";
            this.pauseCheckBox1.UseVisualStyleBackColor = true;
            this.pauseCheckBox1.CheckedChanged += new System.EventHandler(this.pauseCheckBox1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 529);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 64);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pauseCheckBox1);
            this.tabPage1.Controls.Add(this.ChangeButton);
            this.tabPage1.Controls.Add(this.ResetButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 38);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button50x50);
            this.tabPage2.Controls.Add(this.button20x40);
            this.tabPage2.Controls.Add(this.pauseCheckBox2);
            this.tabPage2.Controls.Add(this.heightNud);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.widthNud);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.delayNud);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(445, 38);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuraciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button50x50
            // 
            this.button50x50.Location = new System.Drawing.Point(187, 7);
            this.button50x50.Name = "button50x50";
            this.button50x50.Size = new System.Drawing.Size(105, 23);
            this.button50x50.TabIndex = 10;
            this.button50x50.Text = "50 x 50";
            this.button50x50.UseVisualStyleBackColor = true;
            this.button50x50.Click += new System.EventHandler(this.button50x50_Click);
            // 
            // button20x40
            // 
            this.button20x40.Location = new System.Drawing.Point(73, 7);
            this.button20x40.Name = "button20x40";
            this.button20x40.Size = new System.Drawing.Size(99, 23);
            this.button20x40.TabIndex = 9;
            this.button20x40.Text = "20 x 40";
            this.button20x40.UseVisualStyleBackColor = true;
            this.button20x40.Click += new System.EventHandler(this.button20x40_Click);
            // 
            // pauseCheckBox2
            // 
            this.pauseCheckBox2.AutoSize = true;
            this.pauseCheckBox2.Location = new System.Drawing.Point(8, 10);
            this.pauseCheckBox2.Name = "pauseCheckBox2";
            this.pauseCheckBox2.Size = new System.Drawing.Size(59, 17);
            this.pauseCheckBox2.TabIndex = 1;
            this.pauseCheckBox2.Text = "Pausar";
            this.pauseCheckBox2.UseVisualStyleBackColor = true;
            this.pauseCheckBox2.CheckedChanged += new System.EventHandler(this.pauseCheckBox2_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CellsLabel);
            this.tabPage3.Controls.Add(this.pauseCheckBox3);
            this.tabPage3.Controls.Add(this.DeadLabel);
            this.tabPage3.Controls.Add(this.AliveLabel);
            this.tabPage3.Controls.Add(this.BirthsLabel);
            this.tabPage3.Controls.Add(this.DeathsLabel);
            this.tabPage3.Controls.Add(this.GenerationsLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(445, 38);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CellsLabel
            // 
            this.CellsLabel.AutoSize = true;
            this.CellsLabel.Location = new System.Drawing.Point(126, 18);
            this.CellsLabel.Name = "CellsLabel";
            this.CellsLabel.Size = new System.Drawing.Size(51, 13);
            this.CellsLabel.TabIndex = 15;
            this.CellsLabel.Text = "Celdas: 0";
            // 
            // pauseCheckBox3
            // 
            this.pauseCheckBox3.AutoSize = true;
            this.pauseCheckBox3.Location = new System.Drawing.Point(8, 10);
            this.pauseCheckBox3.Name = "pauseCheckBox3";
            this.pauseCheckBox3.Size = new System.Drawing.Size(59, 17);
            this.pauseCheckBox3.TabIndex = 1;
            this.pauseCheckBox3.Text = "Pausar";
            this.pauseCheckBox3.UseVisualStyleBackColor = true;
            this.pauseCheckBox3.CheckedChanged += new System.EventHandler(this.pauseCheckBox3_CheckedChanged);
            // 
            // DeadLabel
            // 
            this.DeadLabel.AutoSize = true;
            this.DeadLabel.Location = new System.Drawing.Point(219, 18);
            this.DeadLabel.Name = "DeadLabel";
            this.DeadLabel.Size = new System.Drawing.Size(57, 13);
            this.DeadLabel.TabIndex = 13;
            this.DeadLabel.Text = "Muertas: 0";
            // 
            // AliveLabel
            // 
            this.AliveLabel.AutoSize = true;
            this.AliveLabel.Location = new System.Drawing.Point(231, 5);
            this.AliveLabel.Name = "AliveLabel";
            this.AliveLabel.Size = new System.Drawing.Size(45, 13);
            this.AliveLabel.TabIndex = 12;
            this.AliveLabel.Text = "Vivas: 0";
            // 
            // BirthsLabel
            // 
            this.BirthsLabel.AutoSize = true;
            this.BirthsLabel.Location = new System.Drawing.Point(311, 18);
            this.BirthsLabel.Name = "BirthsLabel";
            this.BirthsLabel.Size = new System.Drawing.Size(77, 13);
            this.BirthsLabel.TabIndex = 11;
            this.BirthsLabel.Text = "Nacimientos: 0";
            // 
            // DeathsLabel
            // 
            this.DeathsLabel.AutoSize = true;
            this.DeathsLabel.Location = new System.Drawing.Point(331, 5);
            this.DeathsLabel.Name = "DeathsLabel";
            this.DeathsLabel.Size = new System.Drawing.Size(57, 13);
            this.DeathsLabel.TabIndex = 10;
            this.DeathsLabel.Text = "Muertes: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(468, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de la vida - Controles | Gen: 0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.NumericUpDown heightNud;
        private System.Windows.Forms.NumericUpDown delayNud;
        private System.Windows.Forms.NumericUpDown widthNud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GenerationsLabel;
        private System.Windows.Forms.CheckBox pauseCheckBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label DeathsLabel;
        private System.Windows.Forms.Label AliveLabel;
        private System.Windows.Forms.Label BirthsLabel;
        private System.Windows.Forms.Label DeadLabel;
        private System.Windows.Forms.CheckBox pauseCheckBox2;
        private System.Windows.Forms.CheckBox pauseCheckBox3;
        private System.Windows.Forms.Label CellsLabel;
        private System.Windows.Forms.Button button50x50;
        private System.Windows.Forms.Button button20x40;
    }
}

