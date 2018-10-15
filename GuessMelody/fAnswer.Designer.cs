namespace GuessMelody
{
    partial class fAnswer
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
            this.components = new System.ComponentModel.Container();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnAnswerYes = new System.Windows.Forms.Button();
            this.btnAnswerNo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeAnswer = new System.Windows.Forms.Label();
            this.lblShowAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswer.Location = new System.Drawing.Point(13, 13);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(93, 38);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "label1";
            // 
            // btnAnswerYes
            // 
            this.btnAnswerYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAnswerYes.Location = new System.Drawing.Point(20, 276);
            this.btnAnswerYes.Name = "btnAnswerYes";
            this.btnAnswerYes.Size = new System.Drawing.Size(114, 85);
            this.btnAnswerYes.TabIndex = 1;
            this.btnAnswerYes.Text = "Да";
            this.btnAnswerYes.UseVisualStyleBackColor = true;
            // 
            // btnAnswerNo
            // 
            this.btnAnswerNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnAnswerNo.Location = new System.Drawing.Point(140, 276);
            this.btnAnswerNo.Name = "btnAnswerNo";
            this.btnAnswerNo.Size = new System.Drawing.Size(114, 85);
            this.btnAnswerNo.TabIndex = 3;
            this.btnAnswerNo.Text = "Нет";
            this.btnAnswerNo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimeAnswer
            // 
            this.lblTimeAnswer.AutoSize = true;
            this.lblTimeAnswer.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeAnswer.Location = new System.Drawing.Point(154, 74);
            this.lblTimeAnswer.Name = "lblTimeAnswer";
            this.lblTimeAnswer.Size = new System.Drawing.Size(43, 49);
            this.lblTimeAnswer.TabIndex = 4;
            this.lblTimeAnswer.Text = "0";
            // 
            // lblShowAnswer
            // 
            this.lblShowAnswer.AutoSize = true;
            this.lblShowAnswer.Location = new System.Drawing.Point(17, 191);
            this.lblShowAnswer.Name = "lblShowAnswer";
            this.lblShowAnswer.Size = new System.Drawing.Size(90, 13);
            this.lblShowAnswer.TabIndex = 5;
            this.lblShowAnswer.Text = "Показать ответ:";
            this.lblShowAnswer.Click += new System.EventHandler(this.lblShowAnswer_Click);
            // 
            // fAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.lblShowAnswer);
            this.Controls.Add(this.lblTimeAnswer);
            this.Controls.Add(this.btnAnswerNo);
            this.Controls.Add(this.btnAnswerYes);
            this.Controls.Add(this.lblAnswer);
            this.Name = "fAnswer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAnswer_FormClosing);
            this.Load += new System.EventHandler(this.fAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnswerYes;
        private System.Windows.Forms.Button btnAnswerNo;
        public System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblTimeAnswer;
        private System.Windows.Forms.Label lblShowAnswer;
    }
}