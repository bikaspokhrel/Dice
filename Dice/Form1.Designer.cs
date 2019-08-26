namespace Dice
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.lbxDiceRoll = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(562, 145);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(125, 72);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll the Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // lbxDiceRoll
            // 
            this.lbxDiceRoll.FormattingEnabled = true;
            this.lbxDiceRoll.ItemHeight = 16;
            this.lbxDiceRoll.Location = new System.Drawing.Point(85, 67);
            this.lbxDiceRoll.Name = "lbxDiceRoll";
            this.lbxDiceRoll.Size = new System.Drawing.Size(162, 324);
            this.lbxDiceRoll.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxDiceRoll);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ListBox lbxDiceRoll;
    }
}

