namespace LotteryWinFormsApp
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.labelCheckTalon = new System.Windows.Forms.Label();
			this.labelJackpot = new System.Windows.Forms.Label();
			this.textBoxCheckTalon = new System.Windows.Forms.TextBox();
			this.textBoxJackpot = new System.Windows.Forms.TextBox();
			this.buttonWinnings = new System.Windows.Forms.Button();
			this.groupBoxInputData = new System.Windows.Forms.GroupBox();
			this.labelInfo = new System.Windows.Forms.Label();
			this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
			this.labelWinnings = new System.Windows.Forms.Label();
			this.groupBoxErrors = new System.Windows.Forms.GroupBox();
			this.labelErrors = new System.Windows.Forms.Label();
			this.groupBoxInfo = new System.Windows.Forms.GroupBox();
			this.labelInformation = new System.Windows.Forms.Label();
			this.labelRegJackpot = new System.Windows.Forms.Label();
			this.labelRegCheckTalon = new System.Windows.Forms.Label();
			this.groupBoxInputData.SuspendLayout();
			this.groupBoxOutputData.SuspendLayout();
			this.groupBoxErrors.SuspendLayout();
			this.groupBoxInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelCheckTalon
			// 
			this.labelCheckTalon.AutoSize = true;
			this.labelCheckTalon.Location = new System.Drawing.Point(6, 19);
			this.labelCheckTalon.Name = "labelCheckTalon";
			this.labelCheckTalon.Size = new System.Drawing.Size(93, 13);
			this.labelCheckTalon.TabIndex = 0;
			this.labelCheckTalon.Text = "Enter CheckTalon";
			// 
			// labelJackpot
			// 
			this.labelJackpot.AutoSize = true;
			this.labelJackpot.Location = new System.Drawing.Point(6, 51);
			this.labelJackpot.Name = "labelJackpot";
			this.labelJackpot.Size = new System.Drawing.Size(73, 13);
			this.labelJackpot.TabIndex = 1;
			this.labelJackpot.Text = "Enter Jackpot";
			// 
			// textBoxCheckTalon
			// 
			this.textBoxCheckTalon.Location = new System.Drawing.Point(163, 19);
			this.textBoxCheckTalon.Name = "textBoxCheckTalon";
			this.textBoxCheckTalon.Size = new System.Drawing.Size(127, 20);
			this.textBoxCheckTalon.TabIndex = 2;
			this.textBoxCheckTalon.TextChanged += new System.EventHandler(this.textBoxCheckTalon_TextChanged);
			// 
			// textBoxJackpot
			// 
			this.textBoxJackpot.Location = new System.Drawing.Point(163, 51);
			this.textBoxJackpot.Name = "textBoxJackpot";
			this.textBoxJackpot.Size = new System.Drawing.Size(127, 20);
			this.textBoxJackpot.TabIndex = 3;
			this.textBoxJackpot.TextChanged += new System.EventHandler(this.textBoxJackpot_TextChanged);
			// 
			// buttonWinnings
			// 
			this.buttonWinnings.Location = new System.Drawing.Point(163, 81);
			this.buttonWinnings.Name = "buttonWinnings";
			this.buttonWinnings.Size = new System.Drawing.Size(127, 23);
			this.buttonWinnings.TabIndex = 4;
			this.buttonWinnings.Text = "Get Winnings";
			this.buttonWinnings.UseVisualStyleBackColor = true;
			this.buttonWinnings.Click += new System.EventHandler(this.buttonWinnings_Click);
			// 
			// groupBoxInputData
			// 
			this.groupBoxInputData.Controls.Add(this.labelInfo);
			this.groupBoxInputData.Controls.Add(this.textBoxCheckTalon);
			this.groupBoxInputData.Controls.Add(this.buttonWinnings);
			this.groupBoxInputData.Controls.Add(this.textBoxJackpot);
			this.groupBoxInputData.Controls.Add(this.labelJackpot);
			this.groupBoxInputData.Controls.Add(this.labelCheckTalon);
			this.groupBoxInputData.Location = new System.Drawing.Point(12, 87);
			this.groupBoxInputData.Name = "groupBoxInputData";
			this.groupBoxInputData.Size = new System.Drawing.Size(296, 162);
			this.groupBoxInputData.TabIndex = 5;
			this.groupBoxInputData.TabStop = false;
			this.groupBoxInputData.Text = "Input Data";
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.Location = new System.Drawing.Point(6, 81);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(147, 65);
			this.labelInfo.TabIndex = 5;
			this.labelInfo.Text = "Enter different numbers,\r\nJackpot numbers must be 6\r\nCheck Talon numbers can be\r\n" +
    "more than six. Range ( 1-49)\r\nExample: 1,2,4,5,6,7";
			// 
			// groupBoxOutputData
			// 
			this.groupBoxOutputData.Controls.Add(this.labelRegCheckTalon);
			this.groupBoxOutputData.Controls.Add(this.labelRegJackpot);
			this.groupBoxOutputData.Controls.Add(this.labelWinnings);
			this.groupBoxOutputData.Location = new System.Drawing.Point(12, 255);
			this.groupBoxOutputData.Name = "groupBoxOutputData";
			this.groupBoxOutputData.Size = new System.Drawing.Size(490, 150);
			this.groupBoxOutputData.TabIndex = 6;
			this.groupBoxOutputData.TabStop = false;
			this.groupBoxOutputData.Text = "OutputData";
			// 
			// labelWinnings
			// 
			this.labelWinnings.AutoSize = true;
			this.labelWinnings.Location = new System.Drawing.Point(6, 25);
			this.labelWinnings.Name = "labelWinnings";
			this.labelWinnings.Size = new System.Drawing.Size(0, 13);
			this.labelWinnings.TabIndex = 0;
			// 
			// groupBoxErrors
			// 
			this.groupBoxErrors.Controls.Add(this.labelErrors);
			this.groupBoxErrors.Location = new System.Drawing.Point(327, 87);
			this.groupBoxErrors.Name = "groupBoxErrors";
			this.groupBoxErrors.Size = new System.Drawing.Size(175, 162);
			this.groupBoxErrors.TabIndex = 7;
			this.groupBoxErrors.TabStop = false;
			this.groupBoxErrors.Text = "Errors";
			// 
			// labelErrors
			// 
			this.labelErrors.AutoSize = true;
			this.labelErrors.Location = new System.Drawing.Point(6, 29);
			this.labelErrors.Name = "labelErrors";
			this.labelErrors.Size = new System.Drawing.Size(0, 13);
			this.labelErrors.TabIndex = 0;
			// 
			// groupBoxInfo
			// 
			this.groupBoxInfo.Controls.Add(this.labelInformation);
			this.groupBoxInfo.Location = new System.Drawing.Point(12, 12);
			this.groupBoxInfo.Name = "groupBoxInfo";
			this.groupBoxInfo.Size = new System.Drawing.Size(489, 69);
			this.groupBoxInfo.TabIndex = 8;
			this.groupBoxInfo.TabStop = false;
			this.groupBoxInfo.Text = "Information";
			// 
			// labelInformation
			// 
			this.labelInformation.AutoSize = true;
			this.labelInformation.Location = new System.Drawing.Point(6, 16);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(468, 39);
			this.labelInformation.TabIndex = 0;
			this.labelInformation.Text = resources.GetString("labelInformation.Text");
			// 
			// labelRegJackpot
			// 
			this.labelRegJackpot.AutoSize = true;
			this.labelRegJackpot.Location = new System.Drawing.Point(6, 101);
			this.labelRegJackpot.Name = "labelRegJackpot";
			this.labelRegJackpot.Size = new System.Drawing.Size(96, 13);
			this.labelRegJackpot.TabIndex = 1;
			this.labelRegJackpot.Text = "Jackpot Registerd:";
			// 
			// labelRegCheckTalon
			// 
			this.labelRegCheckTalon.AutoSize = true;
			this.labelRegCheckTalon.Location = new System.Drawing.Point(6, 125);
			this.labelRegCheckTalon.Name = "labelRegCheckTalon";
			this.labelRegCheckTalon.Size = new System.Drawing.Size(125, 13);
			this.labelRegCheckTalon.TabIndex = 2;
			this.labelRegCheckTalon.Text = "Check Talon Registered:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 417);
			this.Controls.Add(this.groupBoxInfo);
			this.Controls.Add(this.groupBoxErrors);
			this.Controls.Add(this.groupBoxOutputData);
			this.Controls.Add(this.groupBoxInputData);
			this.Name = "Form1";
			this.Text = "LotteryApp";
			this.groupBoxInputData.ResumeLayout(false);
			this.groupBoxInputData.PerformLayout();
			this.groupBoxOutputData.ResumeLayout(false);
			this.groupBoxOutputData.PerformLayout();
			this.groupBoxErrors.ResumeLayout(false);
			this.groupBoxErrors.PerformLayout();
			this.groupBoxInfo.ResumeLayout(false);
			this.groupBoxInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelCheckTalon;
		private System.Windows.Forms.Label labelJackpot;
		private System.Windows.Forms.TextBox textBoxCheckTalon;
		private System.Windows.Forms.TextBox textBoxJackpot;
		private System.Windows.Forms.Button buttonWinnings;
		private System.Windows.Forms.GroupBox groupBoxInputData;
		private System.Windows.Forms.GroupBox groupBoxOutputData;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.GroupBox groupBoxErrors;
		private System.Windows.Forms.Label labelErrors;
		private System.Windows.Forms.Label labelWinnings;
		private System.Windows.Forms.GroupBox groupBoxInfo;
		private System.Windows.Forms.Label labelInformation;
		private System.Windows.Forms.Label labelRegCheckTalon;
		private System.Windows.Forms.Label labelRegJackpot;
	}
}

