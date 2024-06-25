namespace farmacia
{
    partial class farmaciaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            nameField = new TextBox();
            label2 = new Label();
            typeField = new ComboBox();
            btnSave = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            errorProvider = new ErrorProvider(components);
            label4 = new Label();
            quantity = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            btnClear = new Button();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // nameField
            // 
            nameField.Location = new Point(120, 66);
            nameField.MaxLength = 150;
            nameField.Name = "nameField";
            nameField.Size = new Size(377, 27);
            nameField.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo";
            // 
            // typeField
            // 
            typeField.DropDownStyle = ComboBoxStyle.DropDownList;
            typeField.FlatStyle = FlatStyle.Flat;
            typeField.FormattingEnabled = true;
            typeField.Items.AddRange(new object[] { "analgésico", "analéptico", "anestésico", "antiácido", "antidepresivo", "antibióticos" });
            typeField.Location = new Point(120, 128);
            typeField.Name = "typeField";
            typeField.Size = new Size(377, 28);
            typeField.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 128, 255);
            btnSave.Location = new Point(12, 359);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(207, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 250);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 5;
            label3.Text = "Distruibuidor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(120, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 55);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(213, 25);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(86, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Cemefar";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cofarma";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(99, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Empsephar ";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "Cantidad";
            // 
            // quantity
            // 
            quantity.Location = new Point(120, 183);
            quantity.MaxLength = 5;
            quantity.Name = "quantity";
            quantity.Size = new Size(377, 27);
            quantity.TabIndex = 9;
            quantity.KeyPress += quantity_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(124, 308);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Principal";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(223, 308);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 24);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Secundaria";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 128);
            btnClear.Location = new Point(300, 359);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(197, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(200, 9);
            label5.Name = "label5";
            label5.Size = new Size(134, 41);
            label5.TabIndex = 13;
            label5.Text = "Farmacia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 308);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 14;
            label6.Text = "Sucursal";
            // 
            // farmaciaForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 412);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(quantity);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(typeField);
            Controls.Add(label2);
            Controls.Add(nameField);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "farmaciaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox nameField;
        private Label label2;
        public ComboBox typeField;
        private Button btnSave;
        private Label label3;
        private GroupBox groupBox1;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        private ErrorProvider errorProvider;
        public TextBox quantity;
        private Label label4;
        public CheckBox checkBox2;
        public CheckBox checkBox1;
        private Button btnClear;
        private Label label5;
        public RadioButton radioButton3;
        private Label label6;
    }
}
