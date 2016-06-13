namespace WeatherCheckApp {
  partial class Form1 {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent() {
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.Temperature = new System.Windows.Forms.Label();
      this.Date = new System.Windows.Forms.Label();
      this.Situation = new System.Windows.Forms.Label();
      this.Date1 = new System.Windows.Forms.Label();
      this.Date2 = new System.Windows.Forms.Label();
      this.Temperature1 = new System.Windows.Forms.Label();
      this.Temperature2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 12;
      this.listBox1.Location = new System.Drawing.Point(13, 14);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(157, 352);
      this.listBox1.TabIndex = 0;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(200, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(220, 85);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(50, 31);
      this.pictureBox1.TabIndex = 14;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Location = new System.Drawing.Point(370, 85);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(50, 31);
      this.pictureBox2.TabIndex = 15;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Location = new System.Drawing.Point(520, 85);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(50, 31);
      this.pictureBox3.TabIndex = 16;
      this.pictureBox3.TabStop = false;
      // 
      // Temperature
      // 
      this.Temperature.AutoSize = true;
      this.Temperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.Temperature.Location = new System.Drawing.Point(200, 125);
      this.Temperature.Name = "Temperature";
      this.Temperature.Size = new System.Drawing.Size(51, 24);
      this.Temperature.TabIndex = 18;
      this.Temperature.Text = "tempMax\r\ntempMin";
      // 
      // Date
      // 
      this.Date.AutoSize = true;
      this.Date.Location = new System.Drawing.Point(200, 45);
      this.Date.Name = "Date";
      this.Date.Size = new System.Drawing.Size(54, 36);
      this.Date.TabIndex = 19;
      this.Date.Text = "dateLabel\r\n\r\ndate";
      // 
      // Situation
      // 
      this.Situation.AutoSize = true;
      this.Situation.Location = new System.Drawing.Point(200, 169);
      this.Situation.Name = "Situation";
      this.Situation.Size = new System.Drawing.Size(50, 12);
      this.Situation.TabIndex = 20;
      this.Situation.Text = "Situation";
      // 
      // Date1
      // 
      this.Date1.AutoSize = true;
      this.Date1.Location = new System.Drawing.Point(350, 46);
      this.Date1.Name = "Date1";
      this.Date1.Size = new System.Drawing.Size(60, 36);
      this.Date1.TabIndex = 21;
      this.Date1.Text = "dateLabel1\r\n\r\ndate1";
      // 
      // Date2
      // 
      this.Date2.AutoSize = true;
      this.Date2.Location = new System.Drawing.Point(500, 45);
      this.Date2.Name = "Date2";
      this.Date2.Size = new System.Drawing.Size(60, 36);
      this.Date2.TabIndex = 22;
      this.Date2.Text = "dateLabel2\r\n\r\ndate2";
      // 
      // Temperature1
      // 
      this.Temperature1.AutoSize = true;
      this.Temperature1.Location = new System.Drawing.Point(350, 125);
      this.Temperature1.Name = "Temperature1";
      this.Temperature1.Size = new System.Drawing.Size(57, 24);
      this.Temperature1.TabIndex = 23;
      this.Temperature1.Text = "tempMax1\r\ntempMin1\r\n";
      // 
      // Temperature2
      // 
      this.Temperature2.AutoSize = true;
      this.Temperature2.Location = new System.Drawing.Point(500, 125);
      this.Temperature2.Name = "Temperature2";
      this.Temperature2.Size = new System.Drawing.Size(57, 24);
      this.Temperature2.TabIndex = 24;
      this.Temperature2.Text = "tempMax2\r\ntempMin2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(674, 372);
      this.Controls.Add(this.Temperature2);
      this.Controls.Add(this.Temperature1);
      this.Controls.Add(this.Date2);
      this.Controls.Add(this.Date1);
      this.Controls.Add(this.Situation);
      this.Controls.Add(this.Date);
      this.Controls.Add(this.Temperature);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.Label Temperature;
    private System.Windows.Forms.Label Date;
    private System.Windows.Forms.Label Situation;
    private System.Windows.Forms.Label Date1;
    private System.Windows.Forms.Label Date2;
    private System.Windows.Forms.Label Temperature1;
    private System.Windows.Forms.Label Temperature2;
  }
}

