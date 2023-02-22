namespace Infix_to_Prefix_and_Postfix_Conversion_Program
{
    partial class ConverterHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterHomepage));
            this.label1 = new System.Windows.Forms.Label();
            this.PrefixBtn = new System.Windows.Forms.Button();
            this.PostfixBtn = new System.Windows.Forms.Button();
            this.QuitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(32, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFIX\r\n";
            // 
            // PrefixBtn
            // 
            this.PrefixBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrefixBtn.BackgroundImage")));
            this.PrefixBtn.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PrefixBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrefixBtn.Location = new System.Drawing.Point(354, 50);
            this.PrefixBtn.Name = "PrefixBtn";
            this.PrefixBtn.Size = new System.Drawing.Size(200, 85);
            this.PrefixBtn.TabIndex = 1;
            this.PrefixBtn.Text = "PREFIX";
            this.PrefixBtn.UseVisualStyleBackColor = true;
            this.PrefixBtn.Click += new System.EventHandler(this.PrefixBtn_Click);
            // 
            // PostfixBtn
            // 
            this.PostfixBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PostfixBtn.BackgroundImage")));
            this.PostfixBtn.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PostfixBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PostfixBtn.Location = new System.Drawing.Point(354, 277);
            this.PostfixBtn.Name = "PostfixBtn";
            this.PostfixBtn.Size = new System.Drawing.Size(200, 85);
            this.PostfixBtn.TabIndex = 2;
            this.PostfixBtn.Text = "POSTFIX";
            this.PostfixBtn.UseVisualStyleBackColor = true;
            this.PostfixBtn.Click += new System.EventHandler(this.PostfixBtn_Click);
            // 
            // QuitBTN
            // 
            this.QuitBTN.BackgroundImage = global::Infix_to_Prefix_and_Postfix_Conversion_Program.Properties.Resources.shutterstock_1653624784;
            this.QuitBTN.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.QuitBTN.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.QuitBTN.Location = new System.Drawing.Point(12, 355);
            this.QuitBTN.Name = "QuitBTN";
            this.QuitBTN.Size = new System.Drawing.Size(128, 48);
            this.QuitBTN.TabIndex = 3;
            this.QuitBTN.Text = "QUIT";
            this.QuitBTN.UseVisualStyleBackColor = true;
            this.QuitBTN.Click += new System.EventHandler(this.QuickBTN_Click);
            // 
            // ConverterHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 415);
            this.Controls.Add(this.QuitBTN);
            this.Controls.Add(this.PostfixBtn);
            this.Controls.Add(this.PrefixBtn);
            this.Controls.Add(this.label1);
            this.Name = "ConverterHomepage";
            this.Text = "Infix to Prefix and Postfix Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button PrefixBtn;
        private Button PostfixBtn;
        private Button QuitBTN;
    }
}