namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblmsg = new System.Windows.Forms.Label();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.btnDateCheck = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblmsg
			// 
			this.lblmsg.AutoSize = true;
			this.lblmsg.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblmsg.Location = new System.Drawing.Point(36, 62);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.Size = new System.Drawing.Size(115, 30);
			this.lblmsg.TabIndex = 0;
			this.lblmsg.Text = "查詢日期:";
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(157, 70);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(100, 22);
			this.txtDate.TabIndex = 1;
			// 
			// btnDateCheck
			// 
			this.btnDateCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDateCheck.Location = new System.Drawing.Point(111, 121);
			this.btnDateCheck.Name = "btnDateCheck";
			this.btnDateCheck.Size = new System.Drawing.Size(75, 30);
			this.btnDateCheck.TabIndex = 2;
			this.btnDateCheck.Text = "查詢";
			this.btnDateCheck.UseVisualStyleBackColor = true;
			this.btnDateCheck.Click += new System.EventHandler(this.btnDateCheck_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 194);
			this.Controls.Add(this.btnDateCheck);
			this.Controls.Add(this.txtDate);
			this.Controls.Add(this.lblmsg);
			this.Name = "Form1";
			this.Text = "台灣股市營業日查詢";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblmsg;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.Button btnDateCheck;
	}
}

