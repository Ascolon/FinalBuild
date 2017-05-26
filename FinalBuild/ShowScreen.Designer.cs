namespace FinalBuild
{
    partial class ShowScreen
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
            this.time = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.heightDrop = new System.Windows.Forms.Label();
            this.LengthDrop = new System.Windows.Forms.Label();
            this.TimeAir = new System.Windows.Forms.Label();
            this.showPic = new System.Windows.Forms.PictureBox();
            this.showtime = new System.Windows.Forms.Label();
            this.showspeed = new System.Windows.Forms.Label();
            this.showheight = new System.Windows.Forms.Label();
            this.showlength = new System.Windows.Forms.Label();
            this.showtimeair = new System.Windows.Forms.Label();
            this.Prev = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(848, 5);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(111, 36);
            this.time.TabIndex = 1;
            this.time.Text = "Время";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed
            // 
            this.speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speed.Location = new System.Drawing.Point(848, 53);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(111, 46);
            this.speed.TabIndex = 2;
            this.speed.Text = "Начальная скорость м/с";
            this.speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightDrop
            // 
            this.heightDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightDrop.Location = new System.Drawing.Point(848, 112);
            this.heightDrop.Name = "heightDrop";
            this.heightDrop.Size = new System.Drawing.Size(111, 41);
            this.heightDrop.TabIndex = 3;
            this.heightDrop.Text = "Максимальна высота";
            this.heightDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LengthDrop
            // 
            this.LengthDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LengthDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthDrop.Location = new System.Drawing.Point(848, 166);
            this.LengthDrop.Name = "LengthDrop";
            this.LengthDrop.Size = new System.Drawing.Size(111, 41);
            this.LengthDrop.TabIndex = 4;
            this.LengthDrop.Text = "Дальность броска";
            this.LengthDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeAir
            // 
            this.TimeAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeAir.Location = new System.Drawing.Point(848, 222);
            this.TimeAir.Name = "TimeAir";
            this.TimeAir.Size = new System.Drawing.Size(111, 41);
            this.TimeAir.TabIndex = 5;
            this.TimeAir.Text = "Время в полете";
            this.TimeAir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPic
            // 
            this.showPic.Dock = System.Windows.Forms.DockStyle.Left;
            this.showPic.Location = new System.Drawing.Point(0, 0);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(842, 466);
            this.showPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPic.TabIndex = 0;
            this.showPic.TabStop = false;
            // 
            // showtime
            // 
            this.showtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showtime.Location = new System.Drawing.Point(965, 5);
            this.showtime.Name = "showtime";
            this.showtime.Size = new System.Drawing.Size(111, 41);
            this.showtime.TabIndex = 6;
            this.showtime.Text = "-";
            this.showtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showspeed
            // 
            this.showspeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showspeed.Location = new System.Drawing.Point(965, 53);
            this.showspeed.Name = "showspeed";
            this.showspeed.Size = new System.Drawing.Size(111, 41);
            this.showspeed.TabIndex = 7;
            this.showspeed.Text = "-";
            this.showspeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showheight
            // 
            this.showheight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showheight.Location = new System.Drawing.Point(965, 112);
            this.showheight.Name = "showheight";
            this.showheight.Size = new System.Drawing.Size(111, 41);
            this.showheight.TabIndex = 8;
            this.showheight.Text = "-";
            this.showheight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showlength
            // 
            this.showlength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showlength.Location = new System.Drawing.Point(965, 166);
            this.showlength.Name = "showlength";
            this.showlength.Size = new System.Drawing.Size(111, 41);
            this.showlength.TabIndex = 9;
            this.showlength.Text = "-";
            this.showlength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showtimeair
            // 
            this.showtimeair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showtimeair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showtimeair.Location = new System.Drawing.Point(965, 222);
            this.showtimeair.Name = "showtimeair";
            this.showtimeair.Size = new System.Drawing.Size(111, 41);
            this.showtimeair.TabIndex = 10;
            this.showtimeair.Text = "-";
            this.showtimeair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prev
            // 
            this.Prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prev.Location = new System.Drawing.Point(848, 269);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(111, 41);
            this.Prev.TabIndex = 11;
            this.Prev.Text = "Предыдущая";
            this.Prev.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.Location = new System.Drawing.Point(968, 269);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(111, 41);
            this.Next.TabIndex = 12;
            this.Next.Text = "Следующая";
            this.Next.UseVisualStyleBackColor = true;
            // 
            // ShowScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 466);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.showtimeair);
            this.Controls.Add(this.showlength);
            this.Controls.Add(this.showheight);
            this.Controls.Add(this.showspeed);
            this.Controls.Add(this.showtime);
            this.Controls.Add(this.TimeAir);
            this.Controls.Add(this.LengthDrop);
            this.Controls.Add(this.heightDrop);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.time);
            this.Controls.Add(this.showPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ShowScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробнее...";
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox showPic;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label heightDrop;
        private System.Windows.Forms.Label LengthDrop;
        private System.Windows.Forms.Label TimeAir;
        private System.Windows.Forms.Label showtime;
        private System.Windows.Forms.Label showspeed;
        private System.Windows.Forms.Label showheight;
        private System.Windows.Forms.Label showlength;
        private System.Windows.Forms.Label showtimeair;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
    }
}