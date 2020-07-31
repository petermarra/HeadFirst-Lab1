namespace ADayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.grayHound1 = new System.Windows.Forms.PictureBox();
            this.grayHound4 = new System.Windows.Forms.PictureBox();
            this.grayHound3 = new System.Windows.Forms.PictureBox();
            this.grayHound2 = new System.Windows.Forms.PictureBox();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.placeBetAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.selectDog = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHound1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHound4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHound3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHound2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 24;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // racetrack
            // 
            this.racetrack.Enabled = false;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(12, 12);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(769, 203);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // grayHound1
            // 
            this.grayHound1.Image = ((System.Drawing.Image)(resources.GetObject("grayHound1.Image")));
            this.grayHound1.Location = new System.Drawing.Point(12, 21);
            this.grayHound1.Name = "grayHound1";
            this.grayHound1.Size = new System.Drawing.Size(79, 23);
            this.grayHound1.TabIndex = 1;
            this.grayHound1.TabStop = false;
            // 
            // grayHound4
            // 
            this.grayHound4.Image = ((System.Drawing.Image)(resources.GetObject("grayHound4.Image")));
            this.grayHound4.Location = new System.Drawing.Point(12, 174);
            this.grayHound4.Name = "grayHound4";
            this.grayHound4.Size = new System.Drawing.Size(79, 23);
            this.grayHound4.TabIndex = 2;
            this.grayHound4.TabStop = false;
            // 
            // grayHound3
            // 
            this.grayHound3.Image = ((System.Drawing.Image)(resources.GetObject("grayHound3.Image")));
            this.grayHound3.Location = new System.Drawing.Point(12, 123);
            this.grayHound3.Name = "grayHound3";
            this.grayHound3.Size = new System.Drawing.Size(79, 23);
            this.grayHound3.TabIndex = 3;
            this.grayHound3.TabStop = false;
            // 
            // grayHound2
            // 
            this.grayHound2.Image = ((System.Drawing.Image)(resources.GetObject("grayHound2.Image")));
            this.grayHound2.Location = new System.Drawing.Point(12, 71);
            this.grayHound2.Name = "grayHound2";
            this.grayHound2.Size = new System.Drawing.Size(79, 23);
            this.grayHound2.TabIndex = 4;
            this.grayHound2.TabStop = false;
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(20, 38);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 5;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(20, 61);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 6;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(20, 84);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 7;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(17, 22);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(98, 17);
            this.minimumBetLabel.TabIndex = 9;
            this.minimumBetLabel.Text = "minimumBetLabel";
            this.minimumBetLabel.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(166, 40);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(63, 13);
            this.joeBetLabel.TabIndex = 11;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(166, 86);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(57, 13);
            this.alBetLabel.TabIndex = 13;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(166, 63);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(67, 13);
            this.bobBetLabel.TabIndex = 14;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // race
            // 
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(593, 38);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(142, 102);
            this.race.TabIndex = 15;
            this.race.Text = "Race!";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(29, 129);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 16;
            this.name.Text = "name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // placeBetAmount
            // 
            this.placeBetAmount.Location = new System.Drawing.Point(118, 127);
            this.placeBetAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.placeBetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.placeBetAmount.Name = "placeBetAmount";
            this.placeBetAmount.Size = new System.Drawing.Size(46, 20);
            this.placeBetAmount.TabIndex = 17;
            this.placeBetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "bucks on dog number";
            // 
            // selectDog
            // 
            this.selectDog.Location = new System.Drawing.Point(286, 127);
            this.selectDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.selectDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectDog.Name = "selectDog";
            this.selectDog.Size = new System.Drawing.Size(46, 20);
            this.selectDog.TabIndex = 19;
            this.selectDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(68, 124);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(44, 23);
            this.betButton.TabIndex = 20;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.selectDog);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.placeBetAmount);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 159);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grayHound2);
            this.Controls.Add(this.grayHound3);
            this.Controls.Add(this.grayHound4);
            this.Controls.Add(this.grayHound1);
            this.Controls.Add(this.racetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHound1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHound4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHound3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayHound2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox grayHound1;
        private System.Windows.Forms.PictureBox grayHound4;
        private System.Windows.Forms.PictureBox grayHound3;
        private System.Windows.Forms.PictureBox grayHound2;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.NumericUpDown placeBetAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown selectDog;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

