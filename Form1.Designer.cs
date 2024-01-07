namespace Windows_Pizza_Forms
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
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCrust = new System.Windows.Forms.GroupBox();
            this.radioCrustThink = new System.Windows.Forms.RadioButton();
            this.radioCrustThin = new System.Windows.Forms.RadioButton();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.checkBoxOlives = new System.Windows.Forms.CheckBox();
            this.checkBoxOnion = new System.Windows.Forms.CheckBox();
            this.checkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.checkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.checkBoxExtraChees = new System.Windows.Forms.CheckBox();
            this.groupBoxWhereToEat = new System.Windows.Forms.GroupBox();
            this.radioButtonTakeOut = new System.Windows.Forms.RadioButton();
            this.radioButtonEatIn = new System.Windows.Forms.RadioButton();
            this.labelOrderSummary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCrustType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalePrice = new System.Windows.Forms.Label();
            this.buttonOrderPizza = new System.Windows.Forms.Button();
            this.buttonResetForm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxCrust.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.groupBoxWhereToEat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSize.Controls.Add(this.radioLarge);
            this.groupBoxSize.Controls.Add(this.radioMedium);
            this.groupBoxSize.Controls.Add(this.radioSmall);
            this.groupBoxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSize.ForeColor = System.Drawing.Color.Red;
            this.groupBoxSize.Location = new System.Drawing.Point(12, 85);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(77, 92);
            this.groupBoxSize.TabIndex = 0;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLarge.Location = new System.Drawing.Point(6, 71);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(52, 17);
            this.radioLarge.TabIndex = 2;
            this.radioLarge.TabStop = true;
            this.radioLarge.Tag = "40";
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            this.radioLarge.CheckedChanged += new System.EventHandler(this.radioLarge_CheckedChanged);
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMedium.Location = new System.Drawing.Point(6, 48);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(62, 17);
            this.radioMedium.TabIndex = 1;
            this.radioMedium.TabStop = true;
            this.radioMedium.Tag = "30";
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            this.radioMedium.CheckedChanged += new System.EventHandler(this.radioMedium_CheckedChanged);
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSmall.Location = new System.Drawing.Point(6, 25);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(50, 17);
            this.radioSmall.TabIndex = 0;
            this.radioSmall.TabStop = true;
            this.radioSmall.Tag = "20";
            this.radioSmall.Text = "Small";
            this.radioSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioSmall.UseVisualStyleBackColor = true;
            this.radioSmall.CheckedChanged += new System.EventHandler(this.radioSmall_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(269, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(456, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pizza";
            // 
            // groupBoxCrust
            // 
            this.groupBoxCrust.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCrust.Controls.Add(this.radioCrustThink);
            this.groupBoxCrust.Controls.Add(this.radioCrustThin);
            this.groupBoxCrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCrust.ForeColor = System.Drawing.Color.White;
            this.groupBoxCrust.Location = new System.Drawing.Point(133, 85);
            this.groupBoxCrust.Name = "groupBoxCrust";
            this.groupBoxCrust.Size = new System.Drawing.Size(77, 92);
            this.groupBoxCrust.TabIndex = 3;
            this.groupBoxCrust.TabStop = false;
            this.groupBoxCrust.Text = "Crust ";
            // 
            // radioCrustThink
            // 
            this.radioCrustThink.AutoSize = true;
            this.radioCrustThink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCrustThink.Location = new System.Drawing.Point(6, 48);
            this.radioCrustThink.Name = "radioCrustThink";
            this.radioCrustThink.Size = new System.Drawing.Size(52, 17);
            this.radioCrustThink.TabIndex = 1;
            this.radioCrustThink.TabStop = true;
            this.radioCrustThink.Tag = "10";
            this.radioCrustThink.Text = "Think";
            this.radioCrustThink.UseVisualStyleBackColor = true;
            this.radioCrustThink.CheckedChanged += new System.EventHandler(this.radioCrustThink_CheckedChanged);
            // 
            // radioCrustThin
            // 
            this.radioCrustThin.AutoSize = true;
            this.radioCrustThin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCrustThin.Location = new System.Drawing.Point(6, 25);
            this.radioCrustThin.Name = "radioCrustThin";
            this.radioCrustThin.Size = new System.Drawing.Size(46, 17);
            this.radioCrustThin.TabIndex = 0;
            this.radioCrustThin.TabStop = true;
            this.radioCrustThin.Tag = "0";
            this.radioCrustThin.Text = "Thin";
            this.radioCrustThin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioCrustThin.UseVisualStyleBackColor = true;
            this.radioCrustThin.CheckedChanged += new System.EventHandler(this.radioCrustThin_CheckedChanged);
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxToppings.Controls.Add(this.checkBoxGreenPeppers);
            this.groupBoxToppings.Controls.Add(this.checkBoxOlives);
            this.groupBoxToppings.Controls.Add(this.checkBoxOnion);
            this.groupBoxToppings.Controls.Add(this.checkBoxTomatoes);
            this.groupBoxToppings.Controls.Add(this.checkBoxMushrooms);
            this.groupBoxToppings.Controls.Add(this.checkBoxExtraChees);
            this.groupBoxToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxToppings.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxToppings.Location = new System.Drawing.Point(254, 85);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(211, 116);
            this.groupBoxToppings.TabIndex = 4;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Toppings";
            // 
            // checkBoxGreenPeppers
            // 
            this.checkBoxGreenPeppers.AutoSize = true;
            this.checkBoxGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGreenPeppers.Location = new System.Drawing.Point(108, 93);
            this.checkBoxGreenPeppers.Name = "checkBoxGreenPeppers";
            this.checkBoxGreenPeppers.Size = new System.Drawing.Size(97, 17);
            this.checkBoxGreenPeppers.TabIndex = 11;
            this.checkBoxGreenPeppers.Tag = "5";
            this.checkBoxGreenPeppers.Text = "Green Peppers";
            this.checkBoxGreenPeppers.UseVisualStyleBackColor = true;
            this.checkBoxGreenPeppers.CheckedChanged += new System.EventHandler(this.checkBoxGreenPeppers_CheckedChanged);
            // 
            // checkBoxOlives
            // 
            this.checkBoxOlives.AutoSize = true;
            this.checkBoxOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOlives.Location = new System.Drawing.Point(108, 59);
            this.checkBoxOlives.Name = "checkBoxOlives";
            this.checkBoxOlives.Size = new System.Drawing.Size(55, 17);
            this.checkBoxOlives.TabIndex = 10;
            this.checkBoxOlives.Tag = "5";
            this.checkBoxOlives.Text = "Olives";
            this.checkBoxOlives.UseVisualStyleBackColor = true;
            this.checkBoxOlives.CheckedChanged += new System.EventHandler(this.checkBoxOlives_CheckedChanged);
            // 
            // checkBoxOnion
            // 
            this.checkBoxOnion.AutoSize = true;
            this.checkBoxOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnion.Location = new System.Drawing.Point(108, 25);
            this.checkBoxOnion.Name = "checkBoxOnion";
            this.checkBoxOnion.Size = new System.Drawing.Size(54, 17);
            this.checkBoxOnion.TabIndex = 9;
            this.checkBoxOnion.Tag = "5";
            this.checkBoxOnion.Text = "Onion";
            this.checkBoxOnion.UseVisualStyleBackColor = true;
            this.checkBoxOnion.CheckedChanged += new System.EventHandler(this.checkBoxOnion_CheckedChanged);
            // 
            // checkBoxTomatoes
            // 
            this.checkBoxTomatoes.AutoSize = true;
            this.checkBoxTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTomatoes.Location = new System.Drawing.Point(3, 93);
            this.checkBoxTomatoes.Name = "checkBoxTomatoes";
            this.checkBoxTomatoes.Size = new System.Drawing.Size(73, 17);
            this.checkBoxTomatoes.TabIndex = 8;
            this.checkBoxTomatoes.Tag = "5";
            this.checkBoxTomatoes.Text = "Tomatoes";
            this.checkBoxTomatoes.UseVisualStyleBackColor = true;
            this.checkBoxTomatoes.CheckedChanged += new System.EventHandler(this.checkBoxTomatoes_CheckedChanged);
            // 
            // checkBoxMushrooms
            // 
            this.checkBoxMushrooms.AutoSize = true;
            this.checkBoxMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMushrooms.Location = new System.Drawing.Point(3, 59);
            this.checkBoxMushrooms.Name = "checkBoxMushrooms";
            this.checkBoxMushrooms.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMushrooms.TabIndex = 7;
            this.checkBoxMushrooms.Tag = "5";
            this.checkBoxMushrooms.Text = "Mushrooms";
            this.checkBoxMushrooms.UseVisualStyleBackColor = true;
            this.checkBoxMushrooms.CheckedChanged += new System.EventHandler(this.checkBoxMushrooms_CheckedChanged);
            // 
            // checkBoxExtraChees
            // 
            this.checkBoxExtraChees.AutoSize = true;
            this.checkBoxExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExtraChees.Location = new System.Drawing.Point(3, 25);
            this.checkBoxExtraChees.Name = "checkBoxExtraChees";
            this.checkBoxExtraChees.Size = new System.Drawing.Size(83, 17);
            this.checkBoxExtraChees.TabIndex = 6;
            this.checkBoxExtraChees.Tag = "5";
            this.checkBoxExtraChees.Text = "Extra Chees";
            this.checkBoxExtraChees.UseVisualStyleBackColor = true;
            this.checkBoxExtraChees.CheckedChanged += new System.EventHandler(this.checkBoxExtraChees_CheckedChanged);
            // 
            // groupBoxWhereToEat
            // 
            this.groupBoxWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxWhereToEat.Controls.Add(this.radioButtonTakeOut);
            this.groupBoxWhereToEat.Controls.Add(this.radioButtonEatIn);
            this.groupBoxWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWhereToEat.ForeColor = System.Drawing.Color.Red;
            this.groupBoxWhereToEat.Location = new System.Drawing.Point(509, 85);
            this.groupBoxWhereToEat.Name = "groupBoxWhereToEat";
            this.groupBoxWhereToEat.Size = new System.Drawing.Size(148, 88);
            this.groupBoxWhereToEat.TabIndex = 5;
            this.groupBoxWhereToEat.TabStop = false;
            this.groupBoxWhereToEat.Text = "Where To Eat";
            // 
            // radioButtonTakeOut
            // 
            this.radioButtonTakeOut.AutoSize = true;
            this.radioButtonTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTakeOut.Location = new System.Drawing.Point(6, 43);
            this.radioButtonTakeOut.Name = "radioButtonTakeOut";
            this.radioButtonTakeOut.Size = new System.Drawing.Size(70, 17);
            this.radioButtonTakeOut.TabIndex = 1;
            this.radioButtonTakeOut.TabStop = true;
            this.radioButtonTakeOut.Text = "Take Out";
            this.radioButtonTakeOut.UseVisualStyleBackColor = true;
            this.radioButtonTakeOut.CheckedChanged += new System.EventHandler(this.radioButtonTakeOut_CheckedChanged);
            // 
            // radioButtonEatIn
            // 
            this.radioButtonEatIn.AutoSize = true;
            this.radioButtonEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEatIn.Location = new System.Drawing.Point(6, 25);
            this.radioButtonEatIn.Name = "radioButtonEatIn";
            this.radioButtonEatIn.Size = new System.Drawing.Size(53, 17);
            this.radioButtonEatIn.TabIndex = 0;
            this.radioButtonEatIn.TabStop = true;
            this.radioButtonEatIn.Text = "Eat In";
            this.radioButtonEatIn.UseVisualStyleBackColor = true;
            this.radioButtonEatIn.CheckedChanged += new System.EventHandler(this.radioButtonEatIn_CheckedChanged);
            // 
            // labelOrderSummary
            // 
            this.labelOrderSummary.AutoSize = true;
            this.labelOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.labelOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderSummary.ForeColor = System.Drawing.Color.Red;
            this.labelOrderSummary.Location = new System.Drawing.Point(603, 192);
            this.labelOrderSummary.Name = "labelOrderSummary";
            this.labelOrderSummary.Size = new System.Drawing.Size(157, 24);
            this.labelOrderSummary.TabIndex = 6;
            this.labelOrderSummary.Text = "Order Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(604, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Size : ";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.BackColor = System.Drawing.Color.Transparent;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.ForeColor = System.Drawing.Color.White;
            this.labelSize.Location = new System.Drawing.Point(652, 229);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(0, 16);
            this.labelSize.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(604, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toppings : ";
            // 
            // labelToppings
            // 
            this.labelToppings.AutoSize = true;
            this.labelToppings.BackColor = System.Drawing.Color.Transparent;
            this.labelToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToppings.ForeColor = System.Drawing.Color.White;
            this.labelToppings.Location = new System.Drawing.Point(652, 281);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(0, 16);
            this.labelToppings.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(604, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crust Type :";
            // 
            // labelCrustType
            // 
            this.labelCrustType.AutoSize = true;
            this.labelCrustType.BackColor = System.Drawing.Color.Transparent;
            this.labelCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrustType.ForeColor = System.Drawing.Color.White;
            this.labelCrustType.Location = new System.Drawing.Point(700, 304);
            this.labelCrustType.Name = "labelCrustType";
            this.labelCrustType.Size = new System.Drawing.Size(0, 16);
            this.labelCrustType.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(604, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Where To Eat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(720, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 14;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPrice.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.Lime;
            this.labelTotalPrice.Location = new System.Drawing.Point(391, 250);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(195, 47);
            this.labelTotalPrice.TabIndex = 15;
            this.labelTotalPrice.Text = "Totale Price ";
            // 
            // labelTotalePrice
            // 
            this.labelTotalePrice.AutoSize = true;
            this.labelTotalePrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalePrice.Font = new System.Drawing.Font("Segoe Print", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalePrice.ForeColor = System.Drawing.Color.Lime;
            this.labelTotalePrice.Location = new System.Drawing.Point(430, 297);
            this.labelTotalePrice.Name = "labelTotalePrice";
            this.labelTotalePrice.Size = new System.Drawing.Size(0, 47);
            this.labelTotalePrice.TabIndex = 16;
            // 
            // buttonOrderPizza
            // 
            this.buttonOrderPizza.BackColor = System.Drawing.Color.Black;
            this.buttonOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderPizza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrderPizza.Location = new System.Drawing.Point(65, 285);
            this.buttonOrderPizza.Name = "buttonOrderPizza";
            this.buttonOrderPizza.Size = new System.Drawing.Size(93, 47);
            this.buttonOrderPizza.TabIndex = 17;
            this.buttonOrderPizza.Text = "Order Pizza";
            this.buttonOrderPizza.UseVisualStyleBackColor = false;
            this.buttonOrderPizza.Click += new System.EventHandler(this.buttonOrderPizza_Click);
            // 
            // buttonResetForm
            // 
            this.buttonResetForm.BackColor = System.Drawing.Color.Black;
            this.buttonResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonResetForm.Location = new System.Drawing.Point(210, 285);
            this.buttonResetForm.Name = "buttonResetForm";
            this.buttonResetForm.Size = new System.Drawing.Size(93, 47);
            this.buttonResetForm.TabIndex = 18;
            this.buttonResetForm.Text = "Reset Form";
            this.buttonResetForm.UseVisualStyleBackColor = false;
            this.buttonResetForm.Click += new System.EventHandler(this.buttonResetForm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, -74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // labelWhereToEat
            // 
            this.labelWhereToEat.AutoSize = true;
            this.labelWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.labelWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhereToEat.ForeColor = System.Drawing.Color.White;
            this.labelWhereToEat.Location = new System.Drawing.Point(726, 335);
            this.labelWhereToEat.Name = "labelWhereToEat";
            this.labelWhereToEat.Size = new System.Drawing.Size(0, 16);
            this.labelWhereToEat.TabIndex = 20;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(487, 229);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(347, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Number of pizzas :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Pizza_Forms.Properties.Resources.Sans_titre1;
            this.ClientSize = new System.Drawing.Size(818, 377);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelWhereToEat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonResetForm);
            this.Controls.Add(this.buttonOrderPizza);
            this.Controls.Add(this.labelTotalePrice);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelCrustType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelToppings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelOrderSummary);
            this.Controls.Add(this.groupBoxWhereToEat);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBoxCrust);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxCrust.ResumeLayout(false);
            this.groupBoxCrust.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.groupBoxWhereToEat.ResumeLayout(false);
            this.groupBoxWhereToEat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxCrust;
        private System.Windows.Forms.RadioButton radioCrustThink;
        private System.Windows.Forms.RadioButton radioCrustThin;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox checkBoxOlives;
        private System.Windows.Forms.CheckBox checkBoxOnion;
        private System.Windows.Forms.CheckBox checkBoxTomatoes;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.CheckBox checkBoxExtraChees;
        private System.Windows.Forms.CheckBox checkBoxGreenPeppers;
        private System.Windows.Forms.GroupBox groupBoxWhereToEat;
        private System.Windows.Forms.RadioButton radioButtonTakeOut;
        private System.Windows.Forms.RadioButton radioButtonEatIn;
        private System.Windows.Forms.Label labelOrderSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCrustType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTotalePrice;
        private System.Windows.Forms.Button buttonOrderPizza;
        private System.Windows.Forms.Button buttonResetForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
    }
}

