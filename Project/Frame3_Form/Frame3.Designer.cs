namespace Project
{
    partial class Frame3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.item_view = new System.Windows.Forms.DataGridView();
            this.month_combo = new System.Windows.Forms.ComboBox();
            this.list_view = new System.Windows.Forms.DataGridView();
            this.wholesale_del = new System.Windows.Forms.Button();
            this.wholesale_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.year_combo = new System.Windows.Forms.ComboBox();
            this.imfor_Bt = new System.Windows.Forms.Button();
            this.item_search = new System.Windows.Forms.Button();
            this.radio_bt1 = new System.Windows.Forms.RadioButton();
            this.radio_bt2 = new System.Windows.Forms.RadioButton();
            this.full_payment = new System.Windows.Forms.Button();
            this.payment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.search_view = new System.Windows.Forms.DataGridView();
            this.sum_Tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBack_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_view)).BeginInit();
            this.SuspendLayout();
            // 
            // search_combo
            // 
            this.search_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_combo.Font = new System.Drawing.Font("굴림", 16F);
            this.search_combo.FormattingEnabled = true;
            this.search_combo.Items.AddRange(new object[] {
            "일별",
            "월별",
            "연도별"});
            this.search_combo.Location = new System.Drawing.Point(319, 10);
            this.search_combo.Name = "search_combo";
            this.search_combo.Size = new System.Drawing.Size(86, 29);
            this.search_combo.TabIndex = 16;
            this.search_combo.Tag = "";
            this.search_combo.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexchanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 16F);
            this.label2.Location = new System.Drawing.Point(437, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "선택 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("굴림", 16F);
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 29);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // item_view
            // 
            this.item_view.AllowUserToAddRows = false;
            this.item_view.AllowUserToDeleteRows = false;
            this.item_view.AllowUserToResizeColumns = false;
            this.item_view.AllowUserToResizeRows = false;
            this.item_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.DefaultCellStyle = dataGridViewCellStyle20;
            this.item_view.Location = new System.Drawing.Point(198, 44);
            this.item_view.MultiSelect = false;
            this.item_view.Name = "item_view";
            this.item_view.ReadOnly = true;
            this.item_view.RowHeadersVisible = false;
            this.item_view.RowHeadersWidth = 45;
            this.item_view.RowTemplate.Height = 23;
            this.item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.item_view.Size = new System.Drawing.Size(937, 596);
            this.item_view.TabIndex = 13;
            // 
            // month_combo
            // 
            this.month_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_combo.Font = new System.Drawing.Font("굴림", 16F);
            this.month_combo.FormattingEnabled = true;
            this.month_combo.Items.AddRange(new object[] {
            "1월",
            "2월",
            "3월",
            "4월",
            "5월",
            "6월",
            "7월",
            "8월",
            "9월",
            "10월",
            "11월",
            "12월"});
            this.month_combo.Location = new System.Drawing.Point(596, 10);
            this.month_combo.Name = "month_combo";
            this.month_combo.Size = new System.Drawing.Size(77, 29);
            this.month_combo.TabIndex = 19;
            // 
            // list_view
            // 
            this.list_view.AllowUserToAddRows = false;
            this.list_view.AllowUserToDeleteRows = false;
            this.list_view.AllowUserToResizeColumns = false;
            this.list_view.AllowUserToResizeRows = false;
            this.list_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.list_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_view.DefaultCellStyle = dataGridViewCellStyle22;
            this.list_view.Location = new System.Drawing.Point(11, 44);
            this.list_view.MultiSelect = false;
            this.list_view.Name = "list_view";
            this.list_view.ReadOnly = true;
            this.list_view.RowHeadersVisible = false;
            this.list_view.RowHeadersWidth = 45;
            this.list_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.list_view.RowTemplate.Height = 23;
            this.list_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_view.Size = new System.Drawing.Size(181, 596);
            this.list_view.TabIndex = 12;
            // 
            // wholesale_del
            // 
            this.wholesale_del.Location = new System.Drawing.Point(127, 10);
            this.wholesale_del.Name = "wholesale_del";
            this.wholesale_del.Size = new System.Drawing.Size(65, 28);
            this.wholesale_del.TabIndex = 11;
            this.wholesale_del.Text = "삭제";
            this.wholesale_del.UseVisualStyleBackColor = true;
            this.wholesale_del.Click += new System.EventHandler(this.wholesale_del_click);
            // 
            // wholesale_in
            // 
            this.wholesale_in.Location = new System.Drawing.Point(11, 10);
            this.wholesale_in.Name = "wholesale_in";
            this.wholesale_in.Size = new System.Drawing.Size(65, 28);
            this.wholesale_in.TabIndex = 10;
            this.wholesale_in.Text = "추가";
            this.wholesale_in.UseVisualStyleBackColor = true;
            this.wholesale_in.Click += new System.EventHandler(this.wholesale_in_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 16F);
            this.label1.Location = new System.Drawing.Point(198, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "검색방법 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // year_combo
            // 
            this.year_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_combo.Font = new System.Drawing.Font("굴림", 16F);
            this.year_combo.FormattingEnabled = true;
            this.year_combo.Location = new System.Drawing.Point(513, 10);
            this.year_combo.Name = "year_combo";
            this.year_combo.Size = new System.Drawing.Size(77, 29);
            this.year_combo.TabIndex = 20;
            // 
            // imfor_Bt
            // 
            this.imfor_Bt.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.imfor_Bt.Location = new System.Drawing.Point(202, 646);
            this.imfor_Bt.Name = "imfor_Bt";
            this.imfor_Bt.Size = new System.Drawing.Size(81, 51);
            this.imfor_Bt.TabIndex = 23;
            this.imfor_Bt.Text = "입  력";
            this.imfor_Bt.UseVisualStyleBackColor = true;
            this.imfor_Bt.Click += new System.EventHandler(this.imfor_Bt_Click);
            // 
            // item_search
            // 
            this.item_search.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.item_search.Image = ((System.Drawing.Image)(resources.GetObject("item_search.Image")));
            this.item_search.Location = new System.Drawing.Point(897, 13);
            this.item_search.Name = "item_search";
            this.item_search.Size = new System.Drawing.Size(60, 29);
            this.item_search.TabIndex = 26;
            this.item_search.UseVisualStyleBackColor = true;
            this.item_search.Click += new System.EventHandler(this.item_search_Click);
            // 
            // radio_bt1
            // 
            this.radio_bt1.Checked = true;
            this.radio_bt1.Location = new System.Drawing.Point(679, 13);
            this.radio_bt1.Name = "radio_bt1";
            this.radio_bt1.Size = new System.Drawing.Size(86, 28);
            this.radio_bt1.TabIndex = 27;
            this.radio_bt1.TabStop = true;
            this.radio_bt1.Text = "물품별검색";
            this.radio_bt1.UseVisualStyleBackColor = true;
            // 
            // radio_bt2
            // 
            this.radio_bt2.Location = new System.Drawing.Point(771, 13);
            this.radio_bt2.Name = "radio_bt2";
            this.radio_bt2.Size = new System.Drawing.Size(102, 28);
            this.radio_bt2.TabIndex = 28;
            this.radio_bt2.Text = "도매상별검색";
            this.radio_bt2.UseVisualStyleBackColor = true;
            // 
            // full_payment
            // 
            this.full_payment.Location = new System.Drawing.Point(11, 646);
            this.full_payment.Name = "full_payment";
            this.full_payment.Size = new System.Drawing.Size(86, 51);
            this.full_payment.TabIndex = 29;
            this.full_payment.Text = "완불";
            this.full_payment.UseVisualStyleBackColor = true;
            this.full_payment.Click += new System.EventHandler(this.full_payment_Click);
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(111, 646);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(81, 51);
            this.payment.TabIndex = 30;
            this.payment.Text = "입금";
            this.payment.UseVisualStyleBackColor = true;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1337, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 29);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_tb
            // 
            this.search_tb.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_tb.Location = new System.Drawing.Point(1187, 13);
            this.search_tb.MaxLength = 10;
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(143, 26);
            this.search_tb.TabIndex = 34;
            this.search_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_tb_KeyDown);
            // 
            // search_view
            // 
            this.search_view.AllowUserToAddRows = false;
            this.search_view.AllowUserToDeleteRows = false;
            this.search_view.AllowUserToResizeColumns = false;
            this.search_view.AllowUserToResizeRows = false;
            this.search_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.search_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.search_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.search_view.DefaultCellStyle = dataGridViewCellStyle24;
            this.search_view.Location = new System.Drawing.Point(1141, 44);
            this.search_view.MultiSelect = false;
            this.search_view.Name = "search_view";
            this.search_view.ReadOnly = true;
            this.search_view.RowHeadersVisible = false;
            this.search_view.RowHeadersWidth = 30;
            this.search_view.RowTemplate.Height = 23;
            this.search_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.search_view.Size = new System.Drawing.Size(299, 596);
            this.search_view.TabIndex = 45;
            // 
            // sum_Tb
            // 
            this.sum_Tb.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_Tb.Location = new System.Drawing.Point(992, 644);
            this.sum_Tb.MaxLength = 10;
            this.sum_Tb.Name = "sum_Tb";
            this.sum_Tb.ReadOnly = true;
            this.sum_Tb.Size = new System.Drawing.Size(143, 29);
            this.sum_Tb.TabIndex = 47;
            this.sum_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 16F);
            this.label3.Location = new System.Drawing.Point(897, 646);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 48;
            this.label3.Text = "합계 :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBack_bt
            // 
            this.tBack_bt.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBack_bt.Location = new System.Drawing.Point(289, 646);
            this.tBack_bt.Name = "tBack_bt";
            this.tBack_bt.Size = new System.Drawing.Size(81, 51);
            this.tBack_bt.TabIndex = 49;
            this.tBack_bt.Text = "반  품";
            this.tBack_bt.UseVisualStyleBackColor = true;
            this.tBack_bt.Click += new System.EventHandler(this.tBack_bt_Click);
            // 
            // Frame3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tBack_bt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sum_Tb);
            this.Controls.Add(this.search_view);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.item_view);
            this.Controls.Add(this.list_view);
            this.Controls.Add(this.radio_bt1);
            this.Controls.Add(this.wholesale_in);
            this.Controls.Add(this.item_search);
            this.Controls.Add(this.imfor_Bt);
            this.Controls.Add(this.radio_bt2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.search_combo);
            this.Controls.Add(this.full_payment);
            this.Controls.Add(this.wholesale_del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.month_combo);
            this.Name = "Frame3";
            this.Size = new System.Drawing.Size(1455, 710);
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox search_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView item_view;
        private System.Windows.Forms.ComboBox month_combo;
        private System.Windows.Forms.DataGridView list_view;
        private System.Windows.Forms.Button wholesale_del;
        private System.Windows.Forms.Button wholesale_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox year_combo;
        private System.Windows.Forms.Button imfor_Bt;
        private System.Windows.Forms.Button item_search;
        private System.Windows.Forms.RadioButton radio_bt1;
        private System.Windows.Forms.RadioButton radio_bt2;
        private System.Windows.Forms.Button full_payment;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.DataGridView search_view;
        private System.Windows.Forms.TextBox sum_Tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tBack_bt;


    }
}
