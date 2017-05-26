namespace FinalBuild
{
    partial class vSpeed
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.movie = new System.Windows.Forms.Timer(this.components);
            this.air = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.speedV = new System.Windows.Forms.TrackBar();
            this.Angle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vOrigin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedV)).BeginInit();
            this.SuspendLayout();
            // 
            // movie
            // 
            this.movie.Interval = 30;
            this.movie.Tick += new System.EventHandler(this.movie_Tick);
            // 
            // air
            // 
            this.air.AutoSize = true;
            this.air.Location = new System.Drawing.Point(270, 68);
            this.air.Name = "air";
            this.air.Size = new System.Drawing.Size(15, 14);
            this.air.TabIndex = 5;
            this.air.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.speedV);
            this.groupBox1.Controls.Add(this.Angle);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.vOrigin);
            this.groupBox1.Controls.Add(this.air);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // speedV
            // 
            this.speedV.AutoSize = false;
            this.speedV.Location = new System.Drawing.Point(28, 16);
            this.speedV.Maximum = 117;
            this.speedV.Minimum = 70;
            this.speedV.Name = "speedV";
            this.speedV.Size = new System.Drawing.Size(160, 22);
            this.speedV.TabIndex = 7;
            this.speedV.TickStyle = System.Windows.Forms.TickStyle.None;
            this.speedV.Value = 95;
            // 
            // Angle
            // 
            this.Angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Angle.Location = new System.Drawing.Point(121, 45);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(67, 23);
            this.Angle.TabIndex = 7;
            this.Angle.Text = "null";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(13, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 28);
            this.title.TabIndex = 7;
            this.title.Text = "Угол броска -";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сопротивление воздуха";
            // 
            // vOrigin
            // 
            this.vOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vOrigin.Location = new System.Drawing.Point(9, 14);
            this.vOrigin.Name = "vOrigin";
            this.vOrigin.Size = new System.Drawing.Size(25, 25);
            this.vOrigin.TabIndex = 7;
            this.vOrigin.Text = "V";
            this.vOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 754);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vSpeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimCity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectVector);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MianForm_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer movie;
        private System.Windows.Forms.CheckBox air;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label vOrigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Angle;
        private System.Windows.Forms.TrackBar speedV;
    }
}

