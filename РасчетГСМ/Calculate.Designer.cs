namespace РасчетГСМ
{
    partial class Calculate
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculate));
            this.distance = new System.Windows.Forms.TextBox();
            this.litersPer100Km = new System.Windows.Forms.TextBox();
            this.fuelCostPerLiter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculatebutton1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardatabaseDataSet = new РасчетГСМ.CardatabaseDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.fuelConsumption = new System.Windows.Forms.TextBox();
            this.totalFuelCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.autoTableAdapter = new РасчетГСМ.CardatabaseDataSetTableAdapters.autoTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // distance
            // 
            this.distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distance.Location = new System.Drawing.Point(655, 205);
            this.distance.Multiline = true;
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(234, 47);
            this.distance.TabIndex = 0;
            // 
            // litersPer100Km
            // 
            this.litersPer100Km.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.litersPer100Km.Location = new System.Drawing.Point(655, 284);
            this.litersPer100Km.Multiline = true;
            this.litersPer100Km.Name = "litersPer100Km";
            this.litersPer100Km.Size = new System.Drawing.Size(234, 47);
            this.litersPer100Km.TabIndex = 2;

            // 
            // fuelCostPerLiter
            // 
            this.fuelCostPerLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelCostPerLiter.Location = new System.Drawing.Point(655, 365);
            this.fuelCostPerLiter.Multiline = true;
            this.fuelCostPerLiter.Name = "fuelCostPerLiter";
            this.fuelCostPerLiter.Size = new System.Drawing.Size(234, 47);
            this.fuelCostPerLiter.TabIndex = 3;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(172, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите пройденное расстояние в км";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(172, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ваш средний расход на 100 км";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(173, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите цену за литр топлива";
            // 
            // calculatebutton1
            // 
            this.calculatebutton1.BackColor = System.Drawing.Color.White;
            this.calculatebutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculatebutton1.FlatAppearance.BorderSize = 0;
            this.calculatebutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.calculatebutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calculatebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatebutton1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatebutton1.Location = new System.Drawing.Point(338, 459);
            this.calculatebutton1.Name = "calculatebutton1";
            this.calculatebutton1.Size = new System.Drawing.Size(267, 104);
            this.calculatebutton1.TabIndex = 10;
            this.calculatebutton1.Text = "Рассчитать";
            this.calculatebutton1.UseVisualStyleBackColor = false;
            this.calculatebutton1.Click += new System.EventHandler(this.calculatebutton1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.autoBindingSource;
            this.comboBox1.DisplayMember = "brands";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(655, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 37);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "Consumption";
            
           
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "auto";
            this.autoBindingSource.DataSource = this.cardatabaseDataSet;
            // 
            // cardatabaseDataSet
            // 
            this.cardatabaseDataSet.DataSetName = "CardatabaseDataSet";
            this.cardatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(172, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Выбирете свой автомобиль";
            // 
            // fuelConsumption
            // 
            this.fuelConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fuelConsumption.Location = new System.Drawing.Point(370, 666);
            this.fuelConsumption.Multiline = true;
            this.fuelConsumption.Name = "fuelConsumption";
            this.fuelConsumption.ReadOnly = true;
            this.fuelConsumption.Size = new System.Drawing.Size(219, 53);
            this.fuelConsumption.TabIndex = 21;
            this.fuelConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // totalFuelCost
            // 
            this.totalFuelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalFuelCost.Location = new System.Drawing.Point(372, 751);
            this.totalFuelCost.Multiline = true;
            this.totalFuelCost.Name = "totalFuelCost";
            this.totalFuelCost.ReadOnly = true;
            this.totalFuelCost.Size = new System.Drawing.Size(217, 53);
            this.totalFuelCost.TabIndex = 22;
            this.totalFuelCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(42, 675);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Израсходовано топлива:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(86, 763);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Потрачено средств:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(382, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 42);
            this.label7.TabIndex = 27;
            this.label7.Text = "Результаты";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(676, 478);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(177, 67);
            this.clear.TabIndex = 28;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(849, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(72, 53);
            this.exit.TabIndex = 29;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Curlz MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(348, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 31);
            this.label8.TabIndex = 30;
            this.label8.Text = "Расчет ГСМ для т/с";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::РасчетГСМ.Properties.Resources._8673344_ic_fluent_gas_filled_icon;
            this.pictureBox5.Location = new System.Drawing.Point(713, 663);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(61, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::РасчетГСМ.Properties.Resources._2784208_finance_business_money_coin_icon;
            this.pictureBox6.Location = new System.Drawing.Point(717, 756);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::РасчетГСМ.Properties.Resources._825448_automobile_cars_magnifying_glass_search_searchicons_icon;
            this.pictureBox4.Location = new System.Drawing.Point(80, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(80, 365);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::РасчетГСМ.Properties.Resources._9025790_gas_pump_icon;
            this.pictureBox2.Location = new System.Drawing.Point(80, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::РасчетГСМ.Properties.Resources._9652709_asphalt_highway_journey_road_street_icon;
            this.pictureBox1.Location = new System.Drawing.Point(80, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(595, 675);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 31);
            this.label10.TabIndex = 32;
            this.label10.Text = "в литрах";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(595, 763);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 31);
            this.label11.TabIndex = 33;
            this.label11.Text = "в рублях";
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(924, 824);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.totalFuelCost);
            this.Controls.Add(this.fuelConsumption);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.calculatebutton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fuelCostPerLiter);
            this.Controls.Add(this.litersPer100Km);
            this.Controls.Add(this.distance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет ГСМ для т/с";
            this.Load += new System.EventHandler(this.Calculate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox litersPer100Km;
        private System.Windows.Forms.TextBox fuelCostPerLiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button calculatebutton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fuelConsumption;
        private System.Windows.Forms.TextBox totalFuelCost;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label8;
        private CardatabaseDataSet cardatabaseDataSet;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private CardatabaseDataSetTableAdapters.autoTableAdapter autoTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

