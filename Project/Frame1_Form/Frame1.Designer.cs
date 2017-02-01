using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    partial class Frame1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame1));
            this.item_view = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.search_View = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.search_Tb = new System.Windows.Forms.TextBox();
            this.search_Bt = new System.Windows.Forms.Button();
            this.total_Lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_View)).BeginInit();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.item_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.item_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.item_code,
            this.amount,
            this.cash,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.item_view.Location = new System.Drawing.Point(3, 3);
            this.item_view.MultiSelect = false;
            this.item_view.Name = "item_view";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.item_view.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.item_view.RowHeadersWidth = 30;
            this.item_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.item_view.RowTemplate.Height = 23;
            this.item_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.item_view.ShowRowErrors = false;
            this.item_view.Size = new System.Drawing.Size(844, 575);
            this.item_view.TabIndex = 14;
            this.item_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_view_CellContentClick);
            this.item_view.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_view_CellEndEdit);
            // 
            // item
            // 
            this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.item.FillWeight = 593.4009F;
            this.item.HeaderText = "물품명";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item.Width = 270;
            // 
            // item_code
            // 
            this.item_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.item_code.FillWeight = 17.76652F;
            this.item_code.HeaderText = "제품코드";
            this.item_code.Name = "item_code";
            this.item_code.ReadOnly = true;
            this.item_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_code.Width = 132;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.amount.FillWeight = 17.76652F;
            this.amount.HeaderText = "수량";
            this.amount.Name = "amount";
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amount.Width = 80;
            // 
            // cash
            // 
            this.cash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cash.FillWeight = 17.76652F;
            this.cash.HeaderText = "금액";
            this.cash.Name = "cash";
            this.cash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cash.Width = 115;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.FillWeight = 17.76652F;
            this.Column5.HeaderText = "총금액";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 115;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.FillWeight = 17.76652F;
            this.Column6.HeaderText = "표시";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.FillWeight = 1F;
            this.Column7.HeaderText = "삭제";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.Text = "삭제";
            this.Column7.Width = 50;
            // 
            // search_View
            // 
            this.search_View.AllowUserToAddRows = false;
            this.search_View.AllowUserToDeleteRows = false;
            this.search_View.AllowUserToResizeColumns = false;
            this.search_View.AllowUserToResizeRows = false;
            this.search_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.search_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.search_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.search_View.DefaultCellStyle = dataGridViewCellStyle5;
            this.search_View.Location = new System.Drawing.Point(853, 3);
            this.search_View.MultiSelect = false;
            this.search_View.Name = "search_View";
            this.search_View.ReadOnly = true;
            this.search_View.RowHeadersVisible = false;
            this.search_View.RowHeadersWidth = 45;
            this.search_View.RowTemplate.Height = 23;
            this.search_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.search_View.Size = new System.Drawing.Size(451, 575);
            this.search_View.TabIndex = 15;
            this.search_View.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.search_View_DoubleClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(544, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "합계 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // search_Tb
            // 
            this.search_Tb.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_Tb.Location = new System.Drawing.Point(986, 584);
            this.search_Tb.MaxLength = 10;
            this.search_Tb.Name = "search_Tb";
            this.search_Tb.Size = new System.Drawing.Size(143, 32);
            this.search_Tb.TabIndex = 36;
            this.search_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_Tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_Tb_KeyDown);
            // 
            // search_Bt
            // 
            this.search_Bt.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_Bt.Image = ((System.Drawing.Image)(resources.GetObject("search_Bt.Image")));
            this.search_Bt.Location = new System.Drawing.Point(1135, 584);
            this.search_Bt.Name = "search_Bt";
            this.search_Bt.Size = new System.Drawing.Size(60, 35);
            this.search_Bt.TabIndex = 35;
            this.search_Bt.UseVisualStyleBackColor = true;
            this.search_Bt.Click += new System.EventHandler(this.search_Bt_Click);
            // 
            // total_Lb
            // 
            this.total_Lb.BackColor = System.Drawing.Color.White;
            this.total_Lb.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.total_Lb.Location = new System.Drawing.Point(628, 584);
            this.total_Lb.Name = "total_Lb";
            this.total_Lb.Size = new System.Drawing.Size(186, 52);
            this.total_Lb.TabIndex = 37;
            this.total_Lb.Text = "0";
            this.total_Lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(814, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 52);
            this.label3.TabIndex = 38;
            this.label3.Text = "원";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(542, 52);
            this.label4.TabIndex = 39;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frame1
            // 
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total_Lb);
            this.Controls.Add(this.search_Tb);
            this.Controls.Add(this.search_Bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_View);
            this.Controls.Add(this.item_view);
            this.Name = "Frame1";
            this.Size = new System.Drawing.Size(1455, 710);
            ((System.ComponentModel.ISupportInitialize)(this.item_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView item_view;
        private DataGridView search_View;
        private Label label1;
        private TextBox search_Tb;
        private Button search_Bt;
        private Label total_Lb;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn item_code;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn cash;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewCheckBoxColumn Column6;
        private DataGridViewButtonColumn Column7;

    }
}
