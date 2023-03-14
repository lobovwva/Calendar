
namespace Calendar
{
    partial class DayBlank
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayNumber = new System.Windows.Forms.Label();
            this.ActiveAppointmentPanel = new System.Windows.Forms.Panel();
            this.ActiveAppointmentLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CompletedAppointmentPanel = new System.Windows.Forms.Panel();
            this.CompletedAppointmentLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.ActiveAppointmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CompletedAppointmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dayNumber
            // 
            this.dayNumber.BackColor = System.Drawing.Color.Transparent;
            this.dayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayNumber.Location = new System.Drawing.Point(0, 0);
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.Size = new System.Drawing.Size(57, 39);
            this.dayNumber.TabIndex = 0;
            this.dayNumber.Text = "01";
            this.dayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActiveAppointmentPanel
            // 
            this.ActiveAppointmentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ActiveAppointmentPanel.Controls.Add(this.ActiveAppointmentLabel);
            this.ActiveAppointmentPanel.Controls.Add(this.pictureBox1);
            this.ActiveAppointmentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActiveAppointmentPanel.Location = new System.Drawing.Point(132, 0);
            this.ActiveAppointmentPanel.Name = "ActiveAppointmentPanel";
            this.ActiveAppointmentPanel.Size = new System.Drawing.Size(38, 84);
            this.ActiveAppointmentPanel.TabIndex = 1;
            this.ActiveAppointmentPanel.Visible = false;
            // 
            // ActiveAppointmentLabel
            // 
            this.ActiveAppointmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveAppointmentLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveAppointmentLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ActiveAppointmentLabel.Location = new System.Drawing.Point(0, 39);
            this.ActiveAppointmentLabel.Name = "ActiveAppointmentLabel";
            this.ActiveAppointmentLabel.Size = new System.Drawing.Size(38, 45);
            this.ActiveAppointmentLabel.TabIndex = 1;
            this.ActiveAppointmentLabel.Text = "01";
            this.ActiveAppointmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Calendar.Properties.Resources.calendar_timeoff;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CompletedAppointmentPanel
            // 
            this.CompletedAppointmentPanel.BackColor = System.Drawing.Color.Transparent;
            this.CompletedAppointmentPanel.Controls.Add(this.CompletedAppointmentLabel);
            this.CompletedAppointmentPanel.Controls.Add(this.pictureBox2);
            this.CompletedAppointmentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CompletedAppointmentPanel.Location = new System.Drawing.Point(92, 0);
            this.CompletedAppointmentPanel.Name = "CompletedAppointmentPanel";
            this.CompletedAppointmentPanel.Size = new System.Drawing.Size(40, 84);
            this.CompletedAppointmentPanel.TabIndex = 2;
            this.CompletedAppointmentPanel.Visible = false;
            // 
            // CompletedAppointmentLabel
            // 
            this.CompletedAppointmentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompletedAppointmentLabel.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompletedAppointmentLabel.ForeColor = System.Drawing.Color.Green;
            this.CompletedAppointmentLabel.Location = new System.Drawing.Point(0, 39);
            this.CompletedAppointmentLabel.Name = "CompletedAppointmentLabel";
            this.CompletedAppointmentLabel.Size = new System.Drawing.Size(40, 45);
            this.CompletedAppointmentLabel.TabIndex = 2;
            this.CompletedAppointmentLabel.Text = "01";
            this.CompletedAppointmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Calendar.Properties.Resources.calendar_now;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.BackColor = System.Drawing.Color.Transparent;
            this.AddAppointmentButton.FlatAppearance.BorderSize = 0;
            this.AddAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAppointmentButton.Image = global::Calendar.Properties.Resources.calendar_image;
            this.AddAppointmentButton.Location = new System.Drawing.Point(3, 42);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(57, 39);
            this.AddAppointmentButton.TabIndex = 3;
            this.AddAppointmentButton.UseVisualStyleBackColor = false;
            this.AddAppointmentButton.Visible = false;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // DayBlank
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.AddAppointmentButton);
            this.Controls.Add(this.CompletedAppointmentPanel);
            this.Controls.Add(this.ActiveAppointmentPanel);
            this.Controls.Add(this.dayNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "DayBlank";
            this.Size = new System.Drawing.Size(170, 84);
            this.Load += new System.EventHandler(this.DayBlank_Load);
            this.ActiveAppointmentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CompletedAppointmentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label dayNumber;
        private System.Windows.Forms.Panel ActiveAppointmentPanel;
        private System.Windows.Forms.Panel CompletedAppointmentPanel;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label ActiveAppointmentLabel;
        private System.Windows.Forms.Label CompletedAppointmentLabel;
    }
}
