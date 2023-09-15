namespace Celcius_to_Fahrenheit
{
    partial class AsteMuunninForm
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
            groupBox1 = new GroupBox();
            FahrenheitRB = new RadioButton();
            CelsiusRB = new RadioButton();
            label1 = new Label();
            AsteetTB = new TextBox();
            MuunnaBT = new Button();
            VastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FahrenheitRB);
            groupBox1.Controls.Add(CelsiusRB);
            groupBox1.Location = new Point(270, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miten muunnat?";
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FahrenheitRB.Location = new Point(18, 71);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(123, 29);
            FahrenheitRB.TabIndex = 1;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CelsiusRB.Location = new Point(18, 36);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(90, 29);
            CelsiusRB.TabIndex = 0;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(153, 41);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(100, 33);
            AsteetTB.TabIndex = 2;
            // 
            // MuunnaBT
            // 
            MuunnaBT.Location = new Point(500, 37);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(95, 39);
            MuunnaBT.TabIndex = 3;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = true;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(32, 104);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(76, 25);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // AsteMuunninForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 155);
            Controls.Add(VastausLB);
            Controls.Add(MuunnaBT);
            Controls.Add(AsteetTB);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AsteMuunninForm";
            Text = "Celsius to Fahrenheit";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton FahrenheitRB;
        private RadioButton CelsiusRB;
        private Label label1;
        private TextBox AsteetTB;
        private Button MuunnaBT;
        private Label VastausLB;
    }
}