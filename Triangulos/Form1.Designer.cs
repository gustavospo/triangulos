namespace Triangulos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtRst = new System.Windows.Forms.TextBox();
            this.Command2 = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.Check_a = new System.Windows.Forms.CheckBox();
            this.CheckC = new System.Windows.Forms.CheckBox();
            this.CheckB = new System.Windows.Forms.CheckBox();
            this.CheckA = new System.Windows.Forms.CheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.Option_a = new System.Windows.Forms.RadioButton();
            this.OptionC = new System.Windows.Forms.RadioButton();
            this.OptionB = new System.Windows.Forms.RadioButton();
            this.OptionA = new System.Windows.Forms.RadioButton();
            this.Option_b = new System.Windows.Forms.RadioButton();
            this.Label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Frame2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRst
            // 
            this.TxtRst.AcceptsReturn = true;
            this.TxtRst.BackColor = System.Drawing.SystemColors.Window;
            this.TxtRst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRst.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtRst.Location = new System.Drawing.Point(518, 38);
            this.TxtRst.MaxLength = 0;
            this.TxtRst.Multiline = true;
            this.TxtRst.Name = "TxtRst";
            this.TxtRst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtRst.Size = new System.Drawing.Size(328, 306);
            this.TxtRst.TabIndex = 31;
            // 
            // Command2
            // 
            this.Command2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Command2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command2.Image = ((System.Drawing.Image)(resources.GetObject("Command2.Image")));
            this.Command2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Command2.Location = new System.Drawing.Point(378, 342);
            this.Command2.Name = "Command2";
            this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command2.Size = new System.Drawing.Size(95, 63);
            this.Command2.TabIndex = 30;
            this.Command2.Text = "Salir";
            this.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Command2.UseVisualStyleBackColor = false;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCalcular.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.Image")));
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCalcular.Location = new System.Drawing.Point(378, 18);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCalcular.Size = new System.Drawing.Size(95, 67);
            this.BtnCalcular.TabIndex = 29;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.White;
            this.Frame1.Controls.Add(this.Check_a);
            this.Frame1.Controls.Add(this.CheckC);
            this.Frame1.Controls.Add(this.CheckB);
            this.Frame1.Controls.Add(this.CheckA);
            this.Frame1.Controls.Add(this.Label6);
            this.Frame1.Controls.Add(this.pictureBox1);
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(25, 18);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(324, 207);
            this.Frame1.TabIndex = 26;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Datos";
            // 
            // Check_a
            // 
            this.Check_a.BackColor = System.Drawing.Color.White;
            this.Check_a.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Check_a.Cursor = System.Windows.Forms.Cursors.Default;
            this.Check_a.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Check_a.Location = new System.Drawing.Point(192, 129);
            this.Check_a.Name = "Check_a";
            this.Check_a.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Check_a.Size = new System.Drawing.Size(59, 17);
            this.Check_a.TabIndex = 8;
            this.Check_a.Text = "angulo";
            this.Check_a.UseVisualStyleBackColor = false;
            // 
            // CheckC
            // 
            this.CheckC.BackColor = System.Drawing.Color.White;
            this.CheckC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckC.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckC.Location = new System.Drawing.Point(120, 152);
            this.CheckC.Name = "CheckC";
            this.CheckC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckC.Size = new System.Drawing.Size(78, 17);
            this.CheckC.TabIndex = 7;
            this.CheckC.Text = "C";
            this.CheckC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckC.UseVisualStyleBackColor = false;
            // 
            // CheckB
            // 
            this.CheckB.BackColor = System.Drawing.Color.White;
            this.CheckB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckB.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckB.Location = new System.Drawing.Point(3, 77);
            this.CheckB.Name = "CheckB";
            this.CheckB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckB.Size = new System.Drawing.Size(38, 29);
            this.CheckB.TabIndex = 6;
            this.CheckB.Text = "B";
            this.CheckB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckB.UseVisualStyleBackColor = false;
            // 
            // CheckA
            // 
            this.CheckA.BackColor = System.Drawing.Color.White;
            this.CheckA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckA.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckA.Location = new System.Drawing.Point(158, 86);
            this.CheckA.Name = "CheckA";
            this.CheckA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckA.Size = new System.Drawing.Size(40, 20);
            this.CheckA.TabIndex = 5;
            this.CheckA.TabStop = false;
            this.CheckA.Text = " A";
            this.CheckA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckA.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(40, 16);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(110, 13);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Escoja, al menos dos.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.Color.White;
            this.Frame2.Controls.Add(this.Option_a);
            this.Frame2.Controls.Add(this.OptionC);
            this.Frame2.Controls.Add(this.OptionB);
            this.Frame2.Controls.Add(this.OptionA);
            this.Frame2.Controls.Add(this.Option_b);
            this.Frame2.Controls.Add(this.Label11);
            this.Frame2.Controls.Add(this.pictureBox2);
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(25, 231);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(0);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(324, 174);
            this.Frame2.TabIndex = 27;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Incognita";
            // 
            // Option_a
            // 
            this.Option_a.BackColor = System.Drawing.Color.White;
            this.Option_a.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Option_a.Checked = true;
            this.Option_a.Cursor = System.Windows.Forms.Cursors.Default;
            this.Option_a.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Option_a.Location = new System.Drawing.Point(192, 122);
            this.Option_a.Name = "Option_a";
            this.Option_a.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Option_a.Size = new System.Drawing.Size(59, 17);
            this.Option_a.TabIndex = 20;
            this.Option_a.TabStop = true;
            this.Option_a.Text = "angulo";
            this.Option_a.UseVisualStyleBackColor = false;
            this.Option_a.CheckedChanged += new System.EventHandler(this.Option_a_CheckedChanged);
            // 
            // OptionC
            // 
            this.OptionC.BackColor = System.Drawing.Color.White;
            this.OptionC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OptionC.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OptionC.Location = new System.Drawing.Point(132, 151);
            this.OptionC.Name = "OptionC";
            this.OptionC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OptionC.Size = new System.Drawing.Size(42, 20);
            this.OptionC.TabIndex = 19;
            this.OptionC.Text = "C";
            this.OptionC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OptionC.UseVisualStyleBackColor = false;
            this.OptionC.CheckedChanged += new System.EventHandler(this.OptionC_CheckedChanged);
            // 
            // OptionB
            // 
            this.OptionB.BackColor = System.Drawing.Color.White;
            this.OptionB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OptionB.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OptionB.Location = new System.Drawing.Point(8, 76);
            this.OptionB.Name = "OptionB";
            this.OptionB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OptionB.Size = new System.Drawing.Size(33, 26);
            this.OptionB.TabIndex = 18;
            this.OptionB.Text = "B";
            this.OptionB.UseVisualStyleBackColor = false;
            this.OptionB.CheckedChanged += new System.EventHandler(this.OptionB_CheckedChanged);
            // 
            // OptionA
            // 
            this.OptionA.BackColor = System.Drawing.Color.White;
            this.OptionA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OptionA.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OptionA.Location = new System.Drawing.Point(159, 76);
            this.OptionA.Name = "OptionA";
            this.OptionA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OptionA.Size = new System.Drawing.Size(39, 17);
            this.OptionA.TabIndex = 16;
            this.OptionA.Text = "A";
            this.OptionA.UseVisualStyleBackColor = false;
            this.OptionA.CheckedChanged += new System.EventHandler(this.OptionA_CheckedChanged);
            // 
            // Option_b
            // 
            this.Option_b.BackColor = System.Drawing.Color.White;
            this.Option_b.Cursor = System.Windows.Forms.Cursors.Default;
            this.Option_b.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Option_b.Location = new System.Drawing.Point(53, 27);
            this.Option_b.Name = "Option_b";
            this.Option_b.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Option_b.Size = new System.Drawing.Size(81, 18);
            this.Option_b.TabIndex = 17;
            this.Option_b.Text = "b angulo";
            this.Option_b.UseVisualStyleBackColor = false;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(76, 30);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(9, 17);
            this.Label11.TabIndex = 15;
            this.Label11.Text = "b";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(525, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 417);
            this.Controls.Add(this.TxtRst);
            this.Controls.Add(this.Command2);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Frame1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Triangulos";
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Frame2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtRst;
        public System.Windows.Forms.Button Command2;
        public System.Windows.Forms.Button BtnCalcular;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.CheckBox Check_a;
        public System.Windows.Forms.CheckBox CheckC;
        public System.Windows.Forms.CheckBox CheckB;
        public System.Windows.Forms.CheckBox CheckA;
        public System.Windows.Forms.Label Label6;
        public System.Windows.Forms.GroupBox Frame2;
        public System.Windows.Forms.RadioButton Option_a;
        public System.Windows.Forms.RadioButton OptionC;
        public System.Windows.Forms.RadioButton OptionB;
        public System.Windows.Forms.RadioButton OptionA;
        public System.Windows.Forms.RadioButton Option_b;
        public System.Windows.Forms.Label Label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label1;
    }
}

