﻿namespace project2
{
	partial class Form1
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

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.uiGridView_CSV = new System.Windows.Forms.DataGridView();
			this.uiBtn_ReadCsv = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.uiBtn_ReadCsv2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.uiGridView_CSV)).BeginInit();
			this.SuspendLayout();
			// 
			// uiGridView_CSV
			// 
			this.uiGridView_CSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.uiGridView_CSV.Location = new System.Drawing.Point(193, 31);
			this.uiGridView_CSV.Name = "uiGridView_CSV";
			this.uiGridView_CSV.RowTemplate.Height = 23;
			this.uiGridView_CSV.Size = new System.Drawing.Size(727, 383);
			this.uiGridView_CSV.TabIndex = 0;
			// 
			// uiBtn_ReadCsv
			// 
			this.uiBtn_ReadCsv.Location = new System.Drawing.Point(47, 31);
			this.uiBtn_ReadCsv.Name = "uiBtn_ReadCsv";
			this.uiBtn_ReadCsv.Size = new System.Drawing.Size(127, 69);
			this.uiBtn_ReadCsv.TabIndex = 1;
			this.uiBtn_ReadCsv.Text = "Call";
			this.uiBtn_ReadCsv.UseVisualStyleBackColor = true;
			this.uiBtn_ReadCsv.Click += new System.EventHandler(this.uiBtn_ReadCsv_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(48, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 69);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// uiBtn_ReadCsv2
			// 
			this.uiBtn_ReadCsv2.Location = new System.Drawing.Point(47, 139);
			this.uiBtn_ReadCsv2.Name = "uiBtn_ReadCsv2";
			this.uiBtn_ReadCsv2.Size = new System.Drawing.Size(127, 69);
			this.uiBtn_ReadCsv2.TabIndex = 3;
			this.uiBtn_ReadCsv2.Text = "Call";
			this.uiBtn_ReadCsv2.UseVisualStyleBackColor = true;
			this.uiBtn_ReadCsv2.Click += new System.EventHandler(this.uiBtn_ReadCsv2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 450);
			this.Controls.Add(this.uiBtn_ReadCsv2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.uiBtn_ReadCsv);
			this.Controls.Add(this.uiGridView_CSV);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.uiGridView_CSV)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView uiGridView_CSV;
		private System.Windows.Forms.Button uiBtn_ReadCsv;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button uiBtn_ReadCsv2;
	}
}

