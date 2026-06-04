namespace Pizza_Project
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
            this.laTitle = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.chkChees = new System.Windows.Forms.CheckBox();
            this.chkGreen = new System.Windows.Forms.CheckBox();
            this.chkOlivs = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatos = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.rbeatin = new System.Windows.Forms.RadioButton();
            this.rbtakeout = new System.Windows.Forms.RadioButton();
            this.gbeat = new System.Windows.Forms.GroupBox();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnresetForm = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.gbTotalPrice = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.laWhereEat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.laCrustType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laToppings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbeat.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.gbTotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.laTitle.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.ForeColor = System.Drawing.Color.Brown;
            this.laTitle.Location = new System.Drawing.Point(220, 9);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(362, 61);
            this.laTitle.TabIndex = 0;
            this.laTitle.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(51, 110);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(109, 125);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbLarge.Location = new System.Drawing.Point(6, 88);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(66, 21);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbMedium.Location = new System.Drawing.Point(6, 59);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(79, 21);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbSmall.ForeColor = System.Drawing.SystemColors.Control;
            this.rbSmall.Location = new System.Drawing.Point(6, 30);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(65, 21);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.Location = new System.Drawing.Point(51, 284);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(109, 107);
            this.gbCrust.TabIndex = 3;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbThick.Location = new System.Drawing.Point(6, 69);
            this.rbThick.Name = "rbThick";
            this.rbThick.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbThick.Size = new System.Drawing.Size(97, 21);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbThin.Location = new System.Drawing.Point(6, 31);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(90, 21);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // chkChees
            // 
            this.chkChees.AutoSize = true;
            this.chkChees.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkChees.Location = new System.Drawing.Point(6, 26);
            this.chkChees.Name = "chkChees";
            this.chkChees.Size = new System.Drawing.Size(89, 18);
            this.chkChees.TabIndex = 4;
            this.chkChees.Tag = "5";
            this.chkChees.Text = "Extra Chees";
            this.chkChees.UseVisualStyleBackColor = true;
            this.chkChees.CheckedChanged += new System.EventHandler(this.chkChees_CheckedChanged);
            // 
            // chkGreen
            // 
            this.chkGreen.AutoSize = true;
            this.chkGreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkGreen.Location = new System.Drawing.Point(105, 91);
            this.chkGreen.Name = "chkGreen";
            this.chkGreen.Size = new System.Drawing.Size(103, 18);
            this.chkGreen.TabIndex = 5;
            this.chkGreen.Tag = "2";
            this.chkGreen.Text = "Green Peppers";
            this.chkGreen.UseVisualStyleBackColor = true;
            this.chkGreen.CheckedChanged += new System.EventHandler(this.chkGreen_CheckedChanged);
            // 
            // chkOlivs
            // 
            this.chkOlivs.AutoSize = true;
            this.chkOlivs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkOlivs.Location = new System.Drawing.Point(105, 59);
            this.chkOlivs.Name = "chkOlivs";
            this.chkOlivs.Size = new System.Drawing.Size(61, 18);
            this.chkOlivs.TabIndex = 6;
            this.chkOlivs.Tag = "0";
            this.chkOlivs.Text = "Olives";
            this.chkOlivs.UseVisualStyleBackColor = true;
            this.chkOlivs.CheckedChanged += new System.EventHandler(this.chkOlivs_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkOnion.Location = new System.Drawing.Point(105, 26);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(65, 18);
            this.chkOnion.TabIndex = 7;
            this.chkOnion.Tag = "1";
            this.chkOnion.Text = "Onions";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatos
            // 
            this.chkTomatos.AutoSize = true;
            this.chkTomatos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkTomatos.Location = new System.Drawing.Point(6, 91);
            this.chkTomatos.Name = "chkTomatos";
            this.chkTomatos.Size = new System.Drawing.Size(79, 18);
            this.chkTomatos.TabIndex = 8;
            this.chkTomatos.Tag = "0";
            this.chkTomatos.Text = "Tomatoes";
            this.chkTomatos.UseVisualStyleBackColor = true;
            this.chkTomatos.CheckedChanged += new System.EventHandler(this.chkTomatos_CheckedChanged);
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMushroom.Location = new System.Drawing.Point(6, 59);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMushroom.Size = new System.Drawing.Size(86, 18);
            this.chkMushroom.TabIndex = 9;
            this.chkMushroom.Tag = "5";
            this.chkMushroom.Text = "Mushrooms";
            this.chkMushroom.UseVisualStyleBackColor = true;
            this.chkMushroom.CheckedChanged += new System.EventHandler(this.chkMushroom_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkTomatos);
            this.gbToppings.Controls.Add(this.chkMushroom);
            this.gbToppings.Controls.Add(this.chkChees);
            this.gbToppings.Controls.Add(this.chkGreen);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkOlivs);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbToppings.Location = new System.Drawing.Point(255, 110);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(205, 129);
            this.gbToppings.TabIndex = 10;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // rbeatin
            // 
            this.rbeatin.AutoSize = true;
            this.rbeatin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbeatin.Location = new System.Drawing.Point(6, 28);
            this.rbeatin.Name = "rbeatin";
            this.rbeatin.Size = new System.Drawing.Size(59, 18);
            this.rbeatin.TabIndex = 11;
            this.rbeatin.TabStop = true;
            this.rbeatin.Text = "Eat In";
            this.rbeatin.UseVisualStyleBackColor = true;
            this.rbeatin.CheckedChanged += new System.EventHandler(this.rbeatin_CheckedChanged);
            // 
            // rbtakeout
            // 
            this.rbtakeout.AutoSize = true;
            this.rbtakeout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtakeout.Location = new System.Drawing.Point(70, 28);
            this.rbtakeout.Name = "rbtakeout";
            this.rbtakeout.Size = new System.Drawing.Size(76, 18);
            this.rbtakeout.TabIndex = 12;
            this.rbtakeout.TabStop = true;
            this.rbtakeout.Text = "Take Out";
            this.rbtakeout.UseVisualStyleBackColor = true;
            this.rbtakeout.CheckedChanged += new System.EventHandler(this.rbtakeout_CheckedChanged);
            // 
            // gbeat
            // 
            this.gbeat.Controls.Add(this.rbeatin);
            this.gbeat.Controls.Add(this.rbtakeout);
            this.gbeat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbeat.Location = new System.Drawing.Point(261, 284);
            this.gbeat.Name = "gbeat";
            this.gbeat.Size = new System.Drawing.Size(167, 58);
            this.gbeat.TabIndex = 13;
            this.gbeat.TabStop = false;
            this.gbeat.Text = "Where to eat ? ";
            // 
            // btnorder
            // 
            this.btnorder.BackColor = System.Drawing.SystemColors.Info;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(255, 433);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(152, 39);
            this.btnorder.TabIndex = 14;
            this.btnorder.Text = "Order Pizza";
            this.btnorder.UseVisualStyleBackColor = false;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // btnresetForm
            // 
            this.btnresetForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnresetForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnresetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetForm.Location = new System.Drawing.Point(482, 433);
            this.btnresetForm.Name = "btnresetForm";
            this.btnresetForm.Size = new System.Drawing.Size(137, 39);
            this.btnresetForm.TabIndex = 15;
            this.btnresetForm.Text = "Reset Form";
            this.btnresetForm.UseVisualStyleBackColor = false;
            this.btnresetForm.Click += new System.EventHandler(this.btnresetForm_Click);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.gbTotalPrice);
            this.gbSummary.Controls.Add(this.laWhereEat);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.laCrustType);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.laToppings);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Controls.Add(this.laSize);
            this.gbSummary.Controls.Add(this.label1);
            this.gbSummary.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSummary.Location = new System.Drawing.Point(610, 98);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(219, 330);
            this.gbSummary.TabIndex = 16;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Order Summary";
            // 
            // gbTotalPrice
            // 
            this.gbTotalPrice.Controls.Add(this.lblTotalPrice);
            this.gbTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotalPrice.Location = new System.Drawing.Point(6, 214);
            this.gbTotalPrice.Name = "gbTotalPrice";
            this.gbTotalPrice.Size = new System.Drawing.Size(186, 105);
            this.gbTotalPrice.TabIndex = 8;
            this.gbTotalPrice.TabStop = false;
            this.gbTotalPrice.Text = "Total Price: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(48, 50);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(38, 42);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "0";
            // 
            // laWhereEat
            // 
            this.laWhereEat.AutoSize = true;
            this.laWhereEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laWhereEat.Location = new System.Drawing.Point(135, 186);
            this.laWhereEat.Name = "laWhereEat";
            this.laWhereEat.Size = new System.Drawing.Size(0, 15);
            this.laWhereEat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Where to Eat : ";
            // 
            // laCrustType
            // 
            this.laCrustType.AutoSize = true;
            this.laCrustType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.laCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCrustType.Location = new System.Drawing.Point(129, 154);
            this.laCrustType.Name = "laCrustType";
            this.laCrustType.Size = new System.Drawing.Size(0, 15);
            this.laCrustType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Crust Type : ";
            // 
            // laToppings
            // 
            this.laToppings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.laToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laToppings.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.laToppings.Location = new System.Drawing.Point(21, 100);
            this.laToppings.Name = "laToppings";
            this.laToppings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.laToppings.Size = new System.Drawing.Size(192, 37);
            this.laToppings.TabIndex = 3;
            this.laToppings.Text = "No Toppings!";
            this.laToppings.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Toppings : ";
            // 
            // laSize
            // 
            this.laSize.AutoSize = true;
            this.laSize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.laSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSize.Location = new System.Drawing.Point(76, 38);
            this.laSize.Name = "laSize";
            this.laSize.Size = new System.Drawing.Size(0, 15);
            this.laSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(897, 511);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.btnresetForm);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.gbeat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.laTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbeat.ResumeLayout(false);
            this.gbeat.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbTotalPrice.ResumeLayout(false);
            this.gbTotalPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.CheckBox chkChees;
        private System.Windows.Forms.CheckBox chkGreen;
        private System.Windows.Forms.CheckBox chkOlivs;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatos;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.RadioButton rbeatin;
        private System.Windows.Forms.RadioButton rbtakeout;
        private System.Windows.Forms.GroupBox gbeat;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnresetForm;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laWhereEat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label laCrustType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laToppings;
        private System.Windows.Forms.GroupBox gbTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}

