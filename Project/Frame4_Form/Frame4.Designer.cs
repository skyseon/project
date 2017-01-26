using System.Windows.Forms;
namespace Project
{
    partial class Frame4
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame4));
            this.item_view = new System.Windows.Forms.DataGridView();
            this.list_in = new System.Windows.Forms.Button();
            this.list_del = new System.Windows.Forms.Button();
            this.list_view = new System.Windows.Forms.DataGridView();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.img_tb = new System.Windows.Forms.TextBox();
            this.barcode_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_bt = new System.Windows.Forms.Button();
            this.insert_bt = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.update_bt = new System.Windows.Forms.Button();
            this.update_cb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // item_view
            // 
            this.item_view.AllowUserToAddRows = false;
            this.item_view.AllowUserToDeleteRows = false;
            this.item_view.AllowUserToResizeColumns = false;
            this.item_view.AllowUserToResizeRows = false;
            this.item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.item_view.Location = new System.Drawing.Point(148, 3);
            this.item_view.MultiSelect = false;
            this.item_view.Name = "item_view";
            this.item_view.ReadOnly = true;
            this.item_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.item_view.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.item_view.RowTemplate.Height = 23;
            this.item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_view.Size = new System.Drawing.Size(1020, 627);
            this.item_view.TabIndex = 1;
            this.item_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_view_click);
            this.item_view.KeyUp += new System.Windows.Forms.KeyEventHandler(this.item_view_KeyUp);
            // 
            // list_in
            // 
            this.list_in.Location = new System.Drawing.Point(3, 640);
            this.list_in.Name = "list_in";
            this.list_in.Size = new System.Drawing.Size(60, 32);
            this.list_in.TabIndex = 3;
            this.list_in.Text = "추가";
            this.list_in.UseVisualStyleBackColor = true;
            this.list_in.Click += new System.EventHandler(this.list_in_Click);
            // 
            // list_del
            // 
            this.list_del.Location = new System.Drawing.Point(79, 640);
            this.list_del.Name = "list_del";
            this.list_del.Size = new System.Drawing.Size(62, 32);
            this.list_del.TabIndex = 4;
            this.list_del.Text = "삭제";
            this.list_del.UseVisualStyleBackColor = true;
            this.list_del.Click += new System.EventHandler(this.list_del_Click);
            // 
            // list_view
            // 
            this.list_view.AllowUserToAddRows = false;
            this.list_view.AllowUserToDeleteRows = false;
            this.list_view.AllowUserToResizeColumns = false;
            this.list_view.AllowUserToResizeRows = false;
            this.list_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.list_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_view.DefaultCellStyle = dataGridViewCellStyle5;
            this.list_view.Location = new System.Drawing.Point(3, 3);
            this.list_view.MultiSelect = false;
            this.list_view.Name = "list_view";
            this.list_view.ReadOnly = true;
            this.list_view.RowHeadersVisible = false;
            this.list_view.RowHeadersWidth = 45;
            this.list_view.RowTemplate.Height = 23;
            this.list_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_view.Size = new System.Drawing.Size(138, 627);
            this.list_view.TabIndex = 9;
            this.list_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_doubleClick);
            // 
            // search_tb
            // 
            this.search_tb.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_tb.Location = new System.Drawing.Point(147, 640);
            this.search_tb.MaxLength = 10;
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(143, 32);
            this.search_tb.TabIndex = 11;
            this.search_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_tb_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1171, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "물품명 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1171, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "공급 단가 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1171, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "현금 단가 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1171, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "판매 단가 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(1171, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "이미지 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(1171, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "설명 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(1171, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "항목 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(1171, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 37);
            this.label8.TabIndex = 17;
            this.label8.Text = "바코드 :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(1265, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 29);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 14F);
            this.textBox2.Location = new System.Drawing.Point(1265, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(184, 29);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("굴림", 14F);
            this.textBox3.Location = new System.Drawing.Point(1265, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(184, 29);
            this.textBox3.TabIndex = 23;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("굴림", 14F);
            this.textBox4.Location = new System.Drawing.Point(1265, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(184, 29);
            this.textBox4.TabIndex = 26;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("굴림", 14F);
            this.textBox5.Location = new System.Drawing.Point(1265, 198);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(184, 29);
            this.textBox5.TabIndex = 25;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("굴림", 14F);
            this.textBox6.Location = new System.Drawing.Point(1265, 251);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(184, 29);
            this.textBox6.TabIndex = 24;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("굴림", 14F);
            this.textBox8.Location = new System.Drawing.Point(1265, 303);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(184, 84);
            this.textBox8.TabIndex = 27;
            // 
            // img_tb
            // 
            this.img_tb.Font = new System.Drawing.Font("굴림", 14F);
            this.img_tb.Location = new System.Drawing.Point(1265, 401);
            this.img_tb.Name = "img_tb";
            this.img_tb.ReadOnly = true;
            this.img_tb.Size = new System.Drawing.Size(184, 29);
            this.img_tb.TabIndex = 28;
            this.img_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // barcode_bt
            // 
            this.barcode_bt.Image = global::Project.Properties.Resources.바코드;
            this.barcode_bt.Location = new System.Drawing.Point(754, 636);
            this.barcode_bt.Name = "barcode_bt";
            this.barcode_bt.Size = new System.Drawing.Size(142, 62);
            this.barcode_bt.TabIndex = 30;
            this.barcode_bt.UseVisualStyleBackColor = true;
            this.barcode_bt.Click += new System.EventHandler(this.barcode_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1174, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Click);
            // 
            // search_bt
            // 
            this.search_bt.Image = ((System.Drawing.Image)(resources.GetObject("search_bt.Image")));
            this.search_bt.Location = new System.Drawing.Point(296, 641);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(62, 32);
            this.search_bt.TabIndex = 12;
            this.search_bt.UseVisualStyleBackColor = true;
            this.search_bt.Click += new System.EventHandler(this.search_bt_Click);
            // 
            // insert_bt
            // 
            this.insert_bt.Image = global::Project.Properties.Resources.추가;
            this.insert_bt.Location = new System.Drawing.Point(1082, 636);
            this.insert_bt.Name = "insert_bt";
            this.insert_bt.Size = new System.Drawing.Size(84, 62);
            this.insert_bt.TabIndex = 8;
            this.insert_bt.UseVisualStyleBackColor = true;
            this.insert_bt.Click += new System.EventHandler(this.insert_bt_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.Image = global::Project.Properties.Resources.삭제;
            this.delete_bt.Location = new System.Drawing.Point(902, 636);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(84, 62);
            this.delete_bt.TabIndex = 7;
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // update_bt
            // 
            this.update_bt.Image = global::Project.Properties.Resources.수정;
            this.update_bt.Location = new System.Drawing.Point(992, 636);
            this.update_bt.Name = "update_bt";
            this.update_bt.Size = new System.Drawing.Size(84, 62);
            this.update_bt.TabIndex = 6;
            this.update_bt.UseVisualStyleBackColor = true;
            this.update_bt.Click += new System.EventHandler(this.update_bt_Click);
            // 
            // update_cb
            // 
            this.update_cb.Checked = true;
            this.update_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.update_cb.Location = new System.Drawing.Point(148, 678);
            this.update_cb.Name = "update_cb";
            this.update_cb.Size = new System.Drawing.Size(142, 24);
            this.update_cb.TabIndex = 31;
            this.update_cb.Text = "수정시 재배치";
            this.update_cb.UseVisualStyleBackColor = true;
            // 
            // Frame4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.update_cb);
            this.Controls.Add(this.barcode_bt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.img_tb);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.list_view);
            this.Controls.Add(this.insert_bt);
            this.Controls.Add(this.delete_bt);
            this.Controls.Add(this.update_bt);
            this.Controls.Add(this.list_del);
            this.Controls.Add(this.list_in);
            this.Controls.Add(this.item_view);
            this.Name = "Frame4";
            this.Size = new System.Drawing.Size(1455, 710);
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView item_view;
        private Button list_in;
        private Button list_del;
        private Button update_bt;
        private Button insert_bt;
        private Button delete_bt;
        private DataGridView list_view;
        private TextBox search_tb;
        private Button search_bt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox img_tb;
        private PictureBox pictureBox1;
        private Button barcode_bt;
        private CheckBox update_cb;

        public System.Windows.Forms.HorizontalAlignment Center { get; set; }
    }
}
