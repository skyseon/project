namespace Project
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components;
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.f1Btn = new System.Windows.Forms.Button();
            this.f2Btn = new System.Windows.Forms.Button();
            this.f3Btn = new System.Windows.Forms.Button();
            this.f4Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_year = new System.Windows.Forms.Label();
            this.time_time = new System.Windows.Forms.Label();
            this.time_timer = new Multimedia.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.f1Btn);
            this.flowLayoutPanel1.Controls.Add(this.f2Btn);
            this.flowLayoutPanel1.Controls.Add(this.f3Btn);
            this.flowLayoutPanel1.Controls.Add(this.f4Btn);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1162, 79);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // f1Btn
            // 
            this.f1Btn.Image = ((System.Drawing.Image)(resources.GetObject("f1Btn.Image")));
            this.f1Btn.Location = new System.Drawing.Point(3, 3);
            this.f1Btn.Name = "f1Btn";
            this.f1Btn.Size = new System.Drawing.Size(87, 71);
            this.f1Btn.TabIndex = 0;
            this.f1Btn.UseVisualStyleBackColor = true;
            this.f1Btn.Click += new System.EventHandler(this.Frame_button);
            // 
            // f2Btn
            // 
            this.f2Btn.Image = ((System.Drawing.Image)(resources.GetObject("f2Btn.Image")));
            this.f2Btn.Location = new System.Drawing.Point(96, 3);
            this.f2Btn.Name = "f2Btn";
            this.f2Btn.Size = new System.Drawing.Size(87, 71);
            this.f2Btn.TabIndex = 1;
            this.f2Btn.UseVisualStyleBackColor = true;
            this.f2Btn.Click += new System.EventHandler(this.Frame_button);
            // 
            // f3Btn
            // 
            this.f3Btn.Image = ((System.Drawing.Image)(resources.GetObject("f3Btn.Image")));
            this.f3Btn.Location = new System.Drawing.Point(189, 3);
            this.f3Btn.Name = "f3Btn";
            this.f3Btn.Size = new System.Drawing.Size(87, 71);
            this.f3Btn.TabIndex = 2;
            this.f3Btn.UseVisualStyleBackColor = true;
            this.f3Btn.Click += new System.EventHandler(this.Frame_button);
            // 
            // f4Btn
            // 
            this.f4Btn.Image = ((System.Drawing.Image)(resources.GetObject("f4Btn.Image")));
            this.f4Btn.Location = new System.Drawing.Point(282, 3);
            this.f4Btn.Name = "f4Btn";
            this.f4Btn.Size = new System.Drawing.Size(89, 71);
            this.f4Btn.TabIndex = 3;
            this.f4Btn.UseVisualStyleBackColor = true;
            this.f4Btn.Click += new System.EventHandler(this.Frame_button);
            // 
            // button1
            // 
            this.button1.Image = global::Project.Properties.Resources.옵션;
            this.button1.Location = new System.Drawing.Point(377, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 71);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(5, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 710);
            this.panel1.TabIndex = 1;
            // 
            // time_year
            // 
            this.time_year.BackColor = System.Drawing.SystemColors.ControlLight;
            this.time_year.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time_year.Location = new System.Drawing.Point(1168, 7);
            this.time_year.Name = "time_year";
            this.time_year.Size = new System.Drawing.Size(292, 42);
            this.time_year.TabIndex = 5;
            this.time_year.Text = "년";
            this.time_year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_time
            // 
            this.time_time.BackColor = System.Drawing.SystemColors.ControlLight;
            this.time_time.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time_time.Location = new System.Drawing.Point(1168, 49);
            this.time_time.Name = "time_time";
            this.time_time.Size = new System.Drawing.Size(292, 37);
            this.time_time.TabIndex = 6;
            this.time_time.Text = "월일";
            this.time_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_timer
            // 
            this.time_timer.Mode = Multimedia.TimerMode.Periodic;
            this.time_timer.Period = 1000;
            this.time_timer.Resolution = 1;
            this.time_timer.SynchronizingObject = this;
            this.time_timer.Tick += new System.EventHandler(this.tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1465, 807);
            this.Controls.Add(this.time_year);
            this.Controls.Add(this.time_time);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1481, 845);
            this.MinimumSize = new System.Drawing.Size(1481, 845);
            this.Name = "MainForm";
            this.Text = "포스프로그램";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button f1Btn;
        private System.Windows.Forms.Button f2Btn;
        private System.Windows.Forms.Button f3Btn;
        private System.Windows.Forms.Button f4Btn;
        private System.Windows.Forms.Label time_year;
        private System.Windows.Forms.Label time_time;
        private Multimedia.Timer time_timer;
        private System.Windows.Forms.Button button1;

    }
}

