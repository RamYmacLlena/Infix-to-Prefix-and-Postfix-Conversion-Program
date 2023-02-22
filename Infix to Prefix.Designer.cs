namespace Infix_to_Prefix_and_Postfix_Conversion_Program
{
    partial class Infix_to_Prefix
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
            this.ConverttoPrefixBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.toPrefixInput = new System.Windows.Forms.TextBox();
            this.toPrefixResult = new System.Windows.Forms.TextBox();
            this.infix = new System.Windows.Forms.Label();
            this.prefix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConverttoPrefixBTN
            // 
            this.ConverttoPrefixBTN.BackgroundImage = global::Infix_to_Prefix_and_Postfix_Conversion_Program.Properties.Resources.shutterstock_1653624784;
            this.ConverttoPrefixBTN.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ConverttoPrefixBTN.Location = new System.Drawing.Point(164, 249);
            this.ConverttoPrefixBTN.Name = "ConverttoPrefixBTN";
            this.ConverttoPrefixBTN.Size = new System.Drawing.Size(331, 76);
            this.ConverttoPrefixBTN.TabIndex = 0;
            this.ConverttoPrefixBTN.Text = "Convert to Prefix";
            this.ConverttoPrefixBTN.UseVisualStyleBackColor = true;
            this.ConverttoPrefixBTN.Click += new System.EventHandler(this.ConverttoPrefixBTN_Click);
            this.ConverttoPrefixBTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toPrefixInput_KeyPress);
            // 
            // BackBTN
            // 
            this.BackBTN.BackgroundImage = global::Infix_to_Prefix_and_Postfix_Conversion_Program.Properties.Resources.shutterstock_1653624784;
            this.BackBTN.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BackBTN.Location = new System.Drawing.Point(234, 348);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(174, 55);
            this.BackBTN.TabIndex = 1;
            this.BackBTN.Text = "back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // toPrefixInput
            // 
            this.toPrefixInput.BackColor = System.Drawing.Color.LightCyan;
            this.toPrefixInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toPrefixInput.Location = new System.Drawing.Point(31, 53);
            this.toPrefixInput.Multiline = true;
            this.toPrefixInput.Name = "toPrefixInput";
            this.toPrefixInput.Size = new System.Drawing.Size(282, 63);
            this.toPrefixInput.TabIndex = 3;
            this.toPrefixInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toPrefixInput_KeyPress);
            // 
            // toPrefixResult
            // 
            this.toPrefixResult.BackColor = System.Drawing.Color.LightCyan;
            this.toPrefixResult.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toPrefixResult.Location = new System.Drawing.Point(349, 53);
            this.toPrefixResult.Multiline = true;
            this.toPrefixResult.Name = "toPrefixResult";
            this.toPrefixResult.Size = new System.Drawing.Size(282, 63);
            this.toPrefixResult.TabIndex = 4;
            // 
            // infix
            // 
            this.infix.AutoSize = true;
            this.infix.BackColor = System.Drawing.Color.Cyan;
            this.infix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infix.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infix.Location = new System.Drawing.Point(118, 13);
            this.infix.Name = "infix";
            this.infix.Size = new System.Drawing.Size(106, 39);
            this.infix.TabIndex = 5;
            this.infix.Text = "Infix";
            // 
            // prefix
            // 
            this.prefix.AutoSize = true;
            this.prefix.BackColor = System.Drawing.Color.Cyan;
            this.prefix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prefix.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prefix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prefix.Location = new System.Drawing.Point(425, 13);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(133, 39);
            this.prefix.TabIndex = 6;
            this.prefix.Text = "Prefix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 100);
            this.label1.TabIndex = 7;
            this.label1.Text = "Note:\r\n*You cannot type characters in succession\r\n  (e.g., AA, 11, ++) only singl" +
    "e characters are\r\n  allowed (e.g., A, 1, +)\r\n*You cannot copy and paste expressi" +
    "on.";
            // 
            // Infix_to_Prefix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Infix_to_Prefix_and_Postfix_Conversion_Program.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prefix);
            this.Controls.Add(this.infix);
            this.Controls.Add(this.toPrefixResult);
            this.Controls.Add(this.toPrefixInput);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.ConverttoPrefixBTN);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Infix_to_Prefix";
            this.Text = "Infix_to_Prefix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ConverttoPrefixBTN;
        private Button BackBTN;
        private TextBox toPrefixInput;
        private TextBox toPrefixResult;
        private Label infix;
        private Label prefix;
        private Label label1;
    }
}