namespace Paths_and_Pipes
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
            this.pictureBoxGameBoard = new System.Windows.Forms.PictureBox();
            this.cbPlayerPosition = new System.Windows.Forms.ComboBox();
            this.cbPlayerCardValue = new System.Windows.Forms.ComboBox();
            this.cbCompPos = new System.Windows.Forms.ComboBox();
            this.cbCompCardValue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonPlayerMove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGameBoard
            // 
            this.pictureBoxGameBoard.Location = new System.Drawing.Point(226, 12);
            this.pictureBoxGameBoard.Name = "pictureBoxGameBoard";
            this.pictureBoxGameBoard.Size = new System.Drawing.Size(350, 350);
            this.pictureBoxGameBoard.TabIndex = 0;
            this.pictureBoxGameBoard.TabStop = false;
            // 
            // cbPlayerPosition
            // 
            this.cbPlayerPosition.FormattingEnabled = true;
            this.cbPlayerPosition.Location = new System.Drawing.Point(53, 185);
            this.cbPlayerPosition.Name = "cbPlayerPosition";
            this.cbPlayerPosition.Size = new System.Drawing.Size(121, 21);
            this.cbPlayerPosition.TabIndex = 1;
            // 
            // cbPlayerCardValue
            // 
            this.cbPlayerCardValue.FormattingEnabled = true;
            this.cbPlayerCardValue.Location = new System.Drawing.Point(53, 251);
            this.cbPlayerCardValue.Name = "cbPlayerCardValue";
            this.cbPlayerCardValue.Size = new System.Drawing.Size(121, 21);
            this.cbPlayerCardValue.TabIndex = 2;
            // 
            // cbCompPos
            // 
            this.cbCompPos.FormattingEnabled = true;
            this.cbCompPos.Location = new System.Drawing.Point(628, 185);
            this.cbCompPos.Name = "cbCompPos";
            this.cbCompPos.Size = new System.Drawing.Size(121, 21);
            this.cbCompPos.TabIndex = 3;
            // 
            // cbCompCardValue
            // 
            this.cbCompCardValue.FormattingEnabled = true;
            this.cbCompCardValue.Location = new System.Drawing.Point(628, 251);
            this.cbCompCardValue.Name = "cbCompCardValue";
            this.cbCompCardValue.Size = new System.Drawing.Size(121, 21);
            this.cbCompCardValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computer";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(226, 385);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(350, 35);
            this.buttonStartGame.TabIndex = 7;
            this.buttonStartGame.Text = "button1";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerMove
            // 
            this.buttonPlayerMove.Location = new System.Drawing.Point(53, 314);
            this.buttonPlayerMove.Name = "buttonPlayerMove";
            this.buttonPlayerMove.Size = new System.Drawing.Size(121, 23);
            this.buttonPlayerMove.TabIndex = 8;
            this.buttonPlayerMove.Text = "Move";
            this.buttonPlayerMove.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Move";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPlayerMove);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCompCardValue);
            this.Controls.Add(this.cbCompPos);
            this.Controls.Add(this.cbPlayerCardValue);
            this.Controls.Add(this.cbPlayerPosition);
            this.Controls.Add(this.pictureBoxGameBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGameBoard;
        private System.Windows.Forms.ComboBox cbPlayerPosition;
        private System.Windows.Forms.ComboBox cbPlayerCardValue;
        private System.Windows.Forms.ComboBox cbCompPos;
        private System.Windows.Forms.ComboBox cbCompCardValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonPlayerMove;
        private System.Windows.Forms.Button button1;
    }
}

