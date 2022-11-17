namespace UserStory_Airoport
{
    partial class FlightsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pribTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.count_pas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.procent = new System.Windows.Forms.NumericUpDown();
            this.reis = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.pas_price = new System.Windows.Forms.NumericUpDown();
            this.ekprice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ekCrew = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.allmoney = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_pas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pas_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekCrew)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Информация о рейсе";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип самолёта";
            // 
            // type
            // 
            this.type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(237, 126);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(228, 21);
            this.type.TabIndex = 2;
            this.type.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboType_DrawItem);
            this.type.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время прибытия";
            // 
            // pribTime
            // 
            this.pribTime.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            this.pribTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pribTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pribTime.Location = new System.Drawing.Point(237, 166);
            this.pribTime.Name = "pribTime";
            this.pribTime.Size = new System.Drawing.Size(228, 20);
            this.pribTime.TabIndex = 4;
            this.pribTime.Value = new System.DateTime(2022, 11, 16, 0, 0, 0, 0);
            this.pribTime.ValueChanged += new System.EventHandler(this.dateTimeETA_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Кол-во пассажиров";
            // 
            // count_pas
            // 
            this.count_pas.Location = new System.Drawing.Point(237, 206);
            this.count_pas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.count_pas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count_pas.Name = "count_pas";
            this.count_pas.Size = new System.Drawing.Size(228, 20);
            this.count_pas.TabIndex = 6;
            this.count_pas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.count_pas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count_pas.ValueChanged += new System.EventHandler(this.numericCountPas_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Сбор на пассажира";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Процент надбавки";
            // 
            // procent
            // 
            this.procent.DecimalPlaces = 2;
            this.procent.Location = new System.Drawing.Point(237, 369);
            this.procent.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(228, 20);
            this.procent.TabIndex = 10;
            this.procent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.procent.ValueChanged += new System.EventHandler(this.numericProcDop_ValueChanged);
            // 
            // reis
            // 
            this.reis.Location = new System.Drawing.Point(237, 90);
            this.reis.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.reis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reis.Name = "reis";
            this.reis.Size = new System.Drawing.Size(228, 20);
            this.reis.TabIndex = 18;
            this.reis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reis.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reis.ValueChanged += new System.EventHandler(this.numericFlight_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Linen;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Номер рейса";
            // 
            // pas_price
            // 
            this.pas_price.DecimalPlaces = 2;
            this.pas_price.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pas_price.Location = new System.Drawing.Point(237, 248);
            this.pas_price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pas_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pas_price.Name = "pas_price";
            this.pas_price.Size = new System.Drawing.Size(228, 20);
            this.pas_price.TabIndex = 19;
            this.pas_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pas_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pas_price.ValueChanged += new System.EventHandler(this.numericPricePas_ValueChanged);
            // 
            // ekprice
            // 
            this.ekprice.DecimalPlaces = 2;
            this.ekprice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ekprice.Location = new System.Drawing.Point(237, 327);
            this.ekprice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ekprice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ekprice.Name = "ekprice";
            this.ekprice.Size = new System.Drawing.Size(228, 20);
            this.ekprice.TabIndex = 23;
            this.ekprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ekprice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ekprice.ValueChanged += new System.EventHandler(this.numericPriceCrew_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Linen;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Сбор на экипаж";
            // 
            // ekCrew
            // 
            this.ekCrew.Location = new System.Drawing.Point(237, 288);
            this.ekCrew.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ekCrew.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ekCrew.Name = "ekCrew";
            this.ekCrew.Size = new System.Drawing.Size(228, 20);
            this.ekCrew.TabIndex = 21;
            this.ekCrew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ekCrew.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ekCrew.ValueChanged += new System.EventHandler(this.numericCountCrew_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Linen;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(13, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Кол-во экипажа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Linen;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(13, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "Выручка";
            // 
            // allmoney
            // 
            this.allmoney.BackColor = System.Drawing.SystemColors.Menu;
            this.allmoney.Location = new System.Drawing.Point(237, 410);
            this.allmoney.Name = "allmoney";
            this.allmoney.ReadOnly = true;
            this.allmoney.Size = new System.Drawing.Size(228, 20);
            this.allmoney.TabIndex = 25;
            this.allmoney.Text = "2";
            this.allmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.allmoney.TextChanged += new System.EventHandler(this.textSum_TextChanged);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.butSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(340, 456);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(132, 51);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCancel.Location = new System.Drawing.Point(17, 456);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(132, 51);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = false;
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(484, 519);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.allmoney);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ekprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ekCrew);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pas_price);
            this.Controls.Add(this.reis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.count_pas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pribTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FlightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавления рейса";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.count_pas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pas_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekCrew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.DateTimePicker pribTime;
        private System.Windows.Forms.NumericUpDown count_pas;
        private System.Windows.Forms.NumericUpDown procent;
        private System.Windows.Forms.NumericUpDown reis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown pas_price;
        private System.Windows.Forms.NumericUpDown ekprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ekCrew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox allmoney;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
    }
}