namespace Infix_to_Prefix_and_Postfix_Conversion_Program
{
    partial class Infix_to_Postfix
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
            this.label1 = new System.Windows.Forms.Label();
            this.postfix = new System.Windows.Forms.Label();
            this.infix = new System.Windows.Forms.Label();
            this.toPostfixResult = new System.Windows.Forms.TextBox();
            this.toPostfixInput = new System.Windows.Forms.TextBox();
            this.BackBTN = new System.Windows.Forms.Button();
            this.ConverttoPrefixBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 100);
            this.label1.TabIndex = 15;
            this.label1.Text = "Note:\r\n*You cannot type characters in succession\r\n  (e.g., AA, 11, ++) only singl" +
    "e characters are\r\n  allowed (e.g., A, 1, +)\r\n*You cannot copy and paste expressi" +
    "on.";
            // 
            // postfix
            // 
            this.postfix.AutoSize = true;
            this.postfix.BackColor = System.Drawing.Color.Cyan;
            this.postfix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.postfix.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postfix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.postfix.Location = new System.Drawing.Point(414, 22);
            this.postfix.Name = "postfix";
            this.postfix.Size = new System.Drawing.Size(152, 39);
            this.postfix.TabIndex = 14;
            this.postfix.Text = "Postfix";
            // 
            // infix
            // 
            this.infix.AutoSize = true;
            this.infix.BackColor = System.Drawing.Color.Cyan;
            this.infix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infix.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infix.Location = new System.Drawing.Point(117, 22);
            this.infix.Name = "infix";
            this.infix.Size = new System.Drawing.Size(106, 39);
            this.infix.TabIndex = 13;
            this.infix.Text = "Infix";
            // 
            // toPostfixResult
            // 
            this.toPostfixResult.BackColor = System.Drawing.Color.LightCyan;
            this.toPostfixResult.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toPostfixResult.Location = new System.Drawing.Point(344, 62);
            this.toPostfixResult.Multiline = true;
            this.toPostfixResult.Name = "toPostfixResult";
            this.toPostfixResult.Size = new System.Drawing.Size(282, 63);
            this.toPostfixResult.TabIndex = 12;
            // 
            // toPostfixInput
            // 
            this.toPostfixInput.BackColor = System.Drawing.Color.LightCyan;
            this.toPostfixInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toPostfixInput.Location = new System.Drawing.Point(26, 62);
            this.toPostfixInput.Multiline = true;
            this.toPostfixInput.Name = "toPostfixInput";
            this.toPostfixInput.Size = new System.Drawing.Size(282, 63);
            this.toPostfixInput.TabIndex = 11;
            this.toPostfixInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toPostfixInput_KeyPress);
            // 
            // BackBTN
            // 
            this.BackBTN.BackgroundImage = global::Infix_to_Prefix_and_Postfix_Conversion_Program.Properties.Resources.shutterstock_1653624784;
            this.BackBTN.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BackBTN.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BackBTN.Location = new System.Drawing.Point(231, 348);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(174, 55);
            this.BackBTN.TabIndex = 9;
            this.BackBTN.Text = "back";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // ConverttoPrefixBTN
            // 
            this.ConverttoPrefixBTN.BackgroundImage = global::Infix_to_Prefix_and_Postfix_Conversion_Program.Properties.Resources.shutterstock_1653624784;
            this.ConverttoPrefixBTN.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ConverttoPrefixBTN.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ConverttoPrefixBTN.Location = new System.Drawing.Point(162, 252);
            this.ConverttoPrefixBTN.Name = "ConverttoPrefixBTN";
            this.ConverttoPrefixBTN.Size = new System.Drawing.Size(331, 76);
            this.ConverttoPrefixBTN.TabIndex = 8;
            this.ConverttoPrefixBTN.Text = "Convert to Postfix";
            this.ConverttoPrefixBTN.UseVisualStyleBackColor = true;
            this.ConverttoPrefixBTN.Click += new System.EventHandler(this.Infix_to_Postfix_Click);
            this.ConverttoPrefixBTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toPostfixInput_KeyPress);
            // 
            // Infix_to_Postfix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Infix_to_Prefix_and_Postfix_Conversion_Program.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postfix);
            this.Controls.Add(this.infix);
            this.Controls.Add(this.toPostfixResult);
            this.Controls.Add(this.toPostfixInput);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.ConverttoPrefixBTN);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Infix_to_Postfix";
            this.Text = "Infix_to_Postfix";
            this.Click += new System.EventHandler(this.Infix_to_Postfix_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label postfix;
        private Label infix;
        private TextBox toPostfixResult;
        private TextBox toPostfixInput;
        private Button BackBTN;
        private Button ConverttoPrefixBTN;
    }
}