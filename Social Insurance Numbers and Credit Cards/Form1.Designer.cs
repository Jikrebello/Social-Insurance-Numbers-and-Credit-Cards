
namespace Social_Insurance_Numbers_and_Credit_Cards
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
            this.Btn_Number_Validator = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.Btn_Product_Codes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Number_Validator
            // 
            this.Btn_Number_Validator.Location = new System.Drawing.Point(12, 78);
            this.Btn_Number_Validator.Name = "Btn_Number_Validator";
            this.Btn_Number_Validator.Size = new System.Drawing.Size(230, 32);
            this.Btn_Number_Validator.TabIndex = 0;
            this.Btn_Number_Validator.Text = "Number Validator";
            this.Btn_Number_Validator.UseVisualStyleBackColor = true;
            this.Btn_Number_Validator.Click += new System.EventHandler(this.Btn_Number_Validator_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(12, 12);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(230, 60);
            this.TxtDisplay.TabIndex = 1;
            // 
            // Btn_Product_Codes
            // 
            this.Btn_Product_Codes.Location = new System.Drawing.Point(12, 116);
            this.Btn_Product_Codes.Name = "Btn_Product_Codes";
            this.Btn_Product_Codes.Size = new System.Drawing.Size(230, 32);
            this.Btn_Product_Codes.TabIndex = 2;
            this.Btn_Product_Codes.Text = "J.M. Schneider product codes.";
            this.Btn_Product_Codes.UseVisualStyleBackColor = true;
            this.Btn_Product_Codes.Click += new System.EventHandler(this.Btn_Product_Codes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 158);
            this.Controls.Add(this.Btn_Product_Codes);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.Btn_Number_Validator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Number_Validator;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button Btn_Product_Codes;
    }
}

