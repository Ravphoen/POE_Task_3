namespace Gade_Assignment_1
{
    partial class BattleForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.textDisplayBox = new System.Windows.Forms.RichTextBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.MapTextBox = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblResources = new System.Windows.Forms.Label();
            this.lblMapSize = new System.Windows.Forms.Label();
            this.cb10 = new System.Windows.Forms.CheckBox();
            this.cb15 = new System.Windows.Forms.CheckBox();
            this.cb20 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(384, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 42);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(384, 106);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(96, 42);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(13, 9);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(131, 29);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "roundlabel";
            this.lblRound.Click += new System.EventHandler(this.lblRound_Click);
            // 
            // textDisplayBox
            // 
            this.textDisplayBox.Location = new System.Drawing.Point(384, 161);
            this.textDisplayBox.Name = "textDisplayBox";
            this.textDisplayBox.Size = new System.Drawing.Size(260, 233);
            this.textDisplayBox.TabIndex = 3;
            this.textDisplayBox.Text = "";
            this.textDisplayBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MapTextBox
            // 
            this.MapTextBox.Location = new System.Drawing.Point(18, 44);
            this.MapTextBox.Name = "MapTextBox";
            this.MapTextBox.Size = new System.Drawing.Size(350, 350);
            this.MapTextBox.TabIndex = 4;
            this.MapTextBox.Text = "";
            this.MapTextBox.TextChanged += new System.EventHandler(this.MapTextBox_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(464, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(384, 59);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(96, 41);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResources.Location = new System.Drawing.Point(180, 9);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(165, 29);
            this.lblResources.TabIndex = 5;
            this.lblResources.Text = "resourcelabel";
            // 
            // lblMapSize
            // 
            this.lblMapSize.AutoSize = true;
            this.lblMapSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapSize.Location = new System.Drawing.Point(549, 22);
            this.lblMapSize.Name = "lblMapSize";
            this.lblMapSize.Size = new System.Drawing.Size(101, 25);
            this.lblMapSize.TabIndex = 6;
            this.lblMapSize.Text = "Map Size:";
            // 
            // cb10
            // 
            this.cb10.AutoSize = true;
            this.cb10.Location = new System.Drawing.Point(554, 50);
            this.cb10.Name = "cb10";
            this.cb10.Size = new System.Drawing.Size(68, 21);
            this.cb10.TabIndex = 7;
            this.cb10.Text = "10x10";
            this.cb10.UseVisualStyleBackColor = true;
            // 
            // cb15
            // 
            this.cb15.AutoSize = true;
            this.cb15.Location = new System.Drawing.Point(554, 77);
            this.cb15.Name = "cb15";
            this.cb15.Size = new System.Drawing.Size(68, 21);
            this.cb15.TabIndex = 7;
            this.cb15.Text = "15x15";
            this.cb15.UseVisualStyleBackColor = true;
            // 
            // cb20
            // 
            this.cb20.AutoSize = true;
            this.cb20.Location = new System.Drawing.Point(554, 106);
            this.cb20.Name = "cb20";
            this.cb20.Size = new System.Drawing.Size(68, 21);
            this.cb20.TabIndex = 7;
            this.cb20.Text = "20x20";
            this.cb20.UseVisualStyleBackColor = true;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 420);
            this.Controls.Add(this.cb20);
            this.Controls.Add(this.cb15);
            this.Controls.Add(this.cb10);
            this.Controls.Add(this.lblMapSize);
            this.Controls.Add(this.lblResources);
            this.Controls.Add(this.MapTextBox);
            this.Controls.Add(this.textDisplayBox);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Name = "BattleForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.RichTextBox textDisplayBox;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.RichTextBox MapTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.Label lblMapSize;
        private System.Windows.Forms.CheckBox cb10;
        private System.Windows.Forms.CheckBox cb15;
        private System.Windows.Forms.CheckBox cb20;
    }
}

