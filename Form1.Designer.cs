
namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.radioButtonRec = new System.Windows.Forms.RadioButton();
            this.radioButtonCirc = new System.Windows.Forms.RadioButton();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.comboBoxModes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 619);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackColor = System.Drawing.Color.Red;
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonClearAll.Location = new System.Drawing.Point(831, 527);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(163, 68);
            this.buttonClearAll.TabIndex = 2;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // radioButtonRec
            // 
            this.radioButtonRec.AutoSize = true;
            this.radioButtonRec.Checked = true;
            this.radioButtonRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRec.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonRec.Location = new System.Drawing.Point(871, 132);
            this.radioButtonRec.Name = "radioButtonRec";
            this.radioButtonRec.Size = new System.Drawing.Size(100, 24);
            this.radioButtonRec.TabIndex = 1;
            this.radioButtonRec.TabStop = true;
            this.radioButtonRec.Text = "Rectangle";
            this.radioButtonRec.UseVisualStyleBackColor = true;
            this.radioButtonRec.CheckedChanged += new System.EventHandler(this.radioButtonRec_CheckedChanged);
            // 
            // radioButtonCirc
            // 
            this.radioButtonCirc.AutoSize = true;
            this.radioButtonCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCirc.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonCirc.Location = new System.Drawing.Point(882, 162);
            this.radioButtonCirc.Name = "radioButtonCirc";
            this.radioButtonCirc.Size = new System.Drawing.Size(66, 24);
            this.radioButtonCirc.TabIndex = 2;
            this.radioButtonCirc.Text = "Circle";
            this.radioButtonCirc.UseVisualStyleBackColor = true;
            this.radioButtonCirc.CheckedChanged += new System.EventHandler(this.radioButtonCirc_CheckedChanged);
            // 
            // listBoxColors
            // 
            this.listBoxColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBoxColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxColors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 25;
            this.listBoxColors.Items.AddRange(new object[] {
            "(Non)",
            "Red",
            "Blue",
            "Yellow"});
            this.listBoxColors.Location = new System.Drawing.Point(850, 243);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(125, 104);
            this.listBoxColors.TabIndex = 3;
            this.listBoxColors.SelectedIndexChanged += new System.EventHandler(this.listBoxColors_SelectedIndexChanged);
            // 
            // comboBoxModes
            // 
            this.comboBoxModes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModes.FormattingEnabled = true;
            this.comboBoxModes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxModes.Items.AddRange(new object[] {
            "Draw",
            "Drag",
            "Color Change",
            "Scale",
            "Delete"});
            this.comboBoxModes.Location = new System.Drawing.Point(863, 74);
            this.comboBoxModes.Name = "comboBoxModes";
            this.comboBoxModes.Size = new System.Drawing.Size(100, 24);
            this.comboBoxModes.TabIndex = 4;
            this.comboBoxModes.Tag = "";
            this.comboBoxModes.SelectedIndexChanged += new System.EventHandler(this.comboBoxModes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(860, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Modes:";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(863, 395);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 42);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Aqua;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(863, 452);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 42);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(861, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Colors:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1006, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxModes);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.radioButtonCirc);
            this.Controls.Add(this.radioButtonRec);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.RadioButton radioButtonRec;
        private System.Windows.Forms.RadioButton radioButtonCirc;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.ComboBox comboBoxModes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label2;
    }
}

