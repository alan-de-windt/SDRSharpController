namespace SDRSharp.SDRSharpController
{
    partial class ControlPanel
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


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            comboSerial = new System.Windows.Forms.ComboBox();
            checkSerial = new System.Windows.Forms.CheckBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            labelControl = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            labelNoMemory = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            labelModeInfo = new System.Windows.Forms.Label();
            labelModeValue = new System.Windows.Forms.Label();
            labelFilterBandwidthInfo = new System.Windows.Forms.Label();
            labelFilterBandwidthValue = new System.Windows.Forms.Label();
            labelTuningStepInfo = new System.Windows.Forms.Label();
            labelTuningStepValue = new System.Windows.Forms.Label();
            labelSquelchThresholdInfo = new System.Windows.Forms.Label();
            labelSquelchThresholdValue = new System.Windows.Forms.Label();
            labelZoomInfo = new System.Windows.Forms.Label();
            labelZoomValue = new System.Windows.Forms.Label();
            labelMode = new System.Windows.Forms.Label();
            labelFrequency = new System.Windows.Forms.Label();
            labelFilterBandwidth = new System.Windows.Forms.Label();
            labelTuningStep = new System.Windows.Forms.Label();
            trackBarAudioGain = new System.Windows.Forms.TrackBar();
            trackBarZoom = new System.Windows.Forms.TrackBar();
            trackBarSquelch = new System.Windows.Forms.TrackBar();
            labelNoSquelch = new System.Windows.Forms.Label();
            labelMemory = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarAudioGain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSquelch).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(50, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(200, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serial Connection";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(comboSerial, 0, 0);
            tableLayoutPanel2.Controls.Add(checkSerial, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(194, 26);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // comboSerial
            // 
            comboSerial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            comboSerial.Location = new System.Drawing.Point(3, 3);
            comboSerial.Name = "comboSerial";
            comboSerial.Size = new System.Drawing.Size(61, 28);
            comboSerial.TabIndex = 0;
            comboSerial.TabStop = false;
            // 
            // checkSerial
            // 
            checkSerial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkSerial.Location = new System.Drawing.Point(70, 3);
            checkSerial.Name = "checkSerial";
            checkSerial.Size = new System.Drawing.Size(104, 20);
            checkSerial.TabIndex = 1;
            checkSerial.TabStop = false;
            checkSerial.Text = "Connect";
            checkSerial.CheckedChanged += CheckChangedSerial;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(3, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(200, 79);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Current Control";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 23);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.Size = new System.Drawing.Size(194, 53);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // labelControl
            // 
            labelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelControl.Location = new System.Drawing.Point(3, 0);
            labelControl.Name = "labelControl";
            labelControl.Size = new System.Drawing.Size(188, 25);
            labelControl.TabIndex = 0;
            labelControl.Text = "Not connected";
            labelControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelNoMemory);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox3.Location = new System.Drawing.Point(3, 146);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(200, 52);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Memory";
            // 
            // labelNoMemory
            // 
            labelNoMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNoMemory.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNoMemory.Location = new System.Drawing.Point(3, 23);
            labelNoMemory.Name = "labelNoMemory";
            labelNoMemory.Size = new System.Drawing.Size(194, 26);
            labelNoMemory.TabIndex = 0;
            labelNoMemory.Text = "None";
            labelNoMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox4.Location = new System.Drawing.Point(3, 204);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(200, 129);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Controller Settings";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tableLayoutPanel4.Controls.Add(labelModeInfo, 0, 0);
            tableLayoutPanel4.Controls.Add(labelModeValue, 1, 0);
            tableLayoutPanel4.Controls.Add(labelFilterBandwidthInfo, 0, 1);
            tableLayoutPanel4.Controls.Add(labelFilterBandwidthValue, 1, 1);
            tableLayoutPanel4.Controls.Add(labelTuningStepInfo, 0, 2);
            tableLayoutPanel4.Controls.Add(labelTuningStepValue, 1, 2);
            tableLayoutPanel4.Controls.Add(labelSquelchThresholdInfo, 0, 3);
            tableLayoutPanel4.Controls.Add(labelSquelchThresholdValue, 1, 3);
            tableLayoutPanel4.Controls.Add(labelZoomInfo, 0, 4);
            tableLayoutPanel4.Controls.Add(labelZoomValue, 1, 4);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.Size = new System.Drawing.Size(194, 103);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelModeInfo
            // 
            labelModeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelModeInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelModeInfo.Location = new System.Drawing.Point(3, 0);
            labelModeInfo.Name = "labelModeInfo";
            labelModeInfo.Size = new System.Drawing.Size(120, 20);
            labelModeInfo.TabIndex = 0;
            labelModeInfo.Text = "Mode:";
            labelModeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelModeValue
            // 
            labelModeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelModeValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelModeValue.Location = new System.Drawing.Point(129, 0);
            labelModeValue.Name = "labelModeValue";
            labelModeValue.Size = new System.Drawing.Size(62, 20);
            labelModeValue.TabIndex = 1;
            labelModeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFilterBandwidthInfo
            // 
            labelFilterBandwidthInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFilterBandwidthInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFilterBandwidthInfo.Location = new System.Drawing.Point(3, 20);
            labelFilterBandwidthInfo.Name = "labelFilterBandwidthInfo";
            labelFilterBandwidthInfo.Size = new System.Drawing.Size(120, 20);
            labelFilterBandwidthInfo.TabIndex = 2;
            labelFilterBandwidthInfo.Text = "Filter Bandwidth:";
            labelFilterBandwidthInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFilterBandwidthValue
            // 
            labelFilterBandwidthValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFilterBandwidthValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelFilterBandwidthValue.Location = new System.Drawing.Point(129, 20);
            labelFilterBandwidthValue.Name = "labelFilterBandwidthValue";
            labelFilterBandwidthValue.Size = new System.Drawing.Size(62, 20);
            labelFilterBandwidthValue.TabIndex = 3;
            labelFilterBandwidthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTuningStepInfo
            // 
            labelTuningStepInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTuningStepInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTuningStepInfo.Location = new System.Drawing.Point(3, 40);
            labelTuningStepInfo.Name = "labelTuningStepInfo";
            labelTuningStepInfo.Size = new System.Drawing.Size(120, 20);
            labelTuningStepInfo.TabIndex = 4;
            labelTuningStepInfo.Text = "Tuning Step:";
            labelTuningStepInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTuningStepValue
            // 
            labelTuningStepValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTuningStepValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTuningStepValue.Location = new System.Drawing.Point(129, 40);
            labelTuningStepValue.Name = "labelTuningStepValue";
            labelTuningStepValue.Size = new System.Drawing.Size(62, 20);
            labelTuningStepValue.TabIndex = 5;
            labelTuningStepValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSquelchThresholdInfo
            // 
            labelSquelchThresholdInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelSquelchThresholdInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSquelchThresholdInfo.Location = new System.Drawing.Point(3, 60);
            labelSquelchThresholdInfo.Name = "labelSquelchThresholdInfo";
            labelSquelchThresholdInfo.Size = new System.Drawing.Size(120, 20);
            labelSquelchThresholdInfo.TabIndex = 6;
            labelSquelchThresholdInfo.Text = "Squelch Threshold:";
            labelSquelchThresholdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSquelchThresholdValue
            // 
            labelSquelchThresholdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelSquelchThresholdValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSquelchThresholdValue.Location = new System.Drawing.Point(129, 60);
            labelSquelchThresholdValue.Name = "labelSquelchThresholdValue";
            labelSquelchThresholdValue.Size = new System.Drawing.Size(62, 20);
            labelSquelchThresholdValue.TabIndex = 7;
            labelSquelchThresholdValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelZoomInfo
            // 
            labelZoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelZoomInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelZoomInfo.Location = new System.Drawing.Point(3, 80);
            labelZoomInfo.Name = "labelZoomInfo";
            labelZoomInfo.Size = new System.Drawing.Size(120, 20);
            labelZoomInfo.TabIndex = 8;
            labelZoomInfo.Text = "Zoom:";
            labelZoomInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelZoomValue
            // 
            labelZoomValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelZoomValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelZoomValue.Location = new System.Drawing.Point(129, 80);
            labelZoomValue.Name = "labelZoomValue";
            labelZoomValue.Size = new System.Drawing.Size(62, 20);
            labelZoomValue.TabIndex = 9;
            labelZoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMode
            // 
            labelMode.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMode.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMode.Location = new System.Drawing.Point(3, 25);
            labelMode.Name = "labelMode";
            labelMode.Size = new System.Drawing.Size(188, 28);
            labelMode.TabIndex = 0;
            labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFrequency
            // 
            labelFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFrequency.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFrequency.Location = new System.Drawing.Point(0, 0);
            labelFrequency.Name = "labelFrequency";
            labelFrequency.Size = new System.Drawing.Size(100, 23);
            labelFrequency.TabIndex = 0;
            labelFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFilterBandwidth
            // 
            labelFilterBandwidth.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFilterBandwidth.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFilterBandwidth.Location = new System.Drawing.Point(0, 0);
            labelFilterBandwidth.Name = "labelFilterBandwidth";
            labelFilterBandwidth.Size = new System.Drawing.Size(100, 23);
            labelFilterBandwidth.TabIndex = 0;
            labelFilterBandwidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTuningStep
            // 
            labelTuningStep.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTuningStep.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTuningStep.Location = new System.Drawing.Point(0, 0);
            labelTuningStep.Name = "labelTuningStep";
            labelTuningStep.Size = new System.Drawing.Size(100, 23);
            labelTuningStep.TabIndex = 0;
            labelTuningStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarAudioGain
            // 
            trackBarAudioGain.Dock = System.Windows.Forms.DockStyle.Fill;
            trackBarAudioGain.Enabled = false;
            trackBarAudioGain.Location = new System.Drawing.Point(0, 0);
            trackBarAudioGain.Maximum = 20;
            trackBarAudioGain.Minimum = -60;
            trackBarAudioGain.Name = "trackBarAudioGain";
            trackBarAudioGain.Size = new System.Drawing.Size(104, 56);
            trackBarAudioGain.TabIndex = 0;
            trackBarAudioGain.TabStop = false;
            trackBarAudioGain.TickFrequency = 10;
            trackBarAudioGain.Value = -60;
            // 
            // trackBarZoom
            // 
            trackBarZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            trackBarZoom.Enabled = false;
            trackBarZoom.Location = new System.Drawing.Point(0, 0);
            trackBarZoom.Maximum = 60;
            trackBarZoom.Name = "trackBarZoom";
            trackBarZoom.Size = new System.Drawing.Size(104, 56);
            trackBarZoom.TabIndex = 0;
            trackBarZoom.TabStop = false;
            trackBarZoom.TickFrequency = 5;
            // 
            // trackBarSquelch
            // 
            trackBarSquelch.Dock = System.Windows.Forms.DockStyle.Fill;
            trackBarSquelch.Enabled = false;
            trackBarSquelch.Location = new System.Drawing.Point(0, 0);
            trackBarSquelch.Maximum = 100;
            trackBarSquelch.Name = "trackBarSquelch";
            trackBarSquelch.Size = new System.Drawing.Size(104, 56);
            trackBarSquelch.TabIndex = 0;
            trackBarSquelch.TabStop = false;
            trackBarSquelch.TickFrequency = 10;
            // 
            // labelNoSquelch
            // 
            labelNoSquelch.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNoSquelch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNoSquelch.Location = new System.Drawing.Point(0, 0);
            labelNoSquelch.Name = "labelNoSquelch";
            labelNoSquelch.Size = new System.Drawing.Size(100, 23);
            labelNoSquelch.TabIndex = 0;
            labelNoSquelch.Text = "Not available";
            labelNoSquelch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMemory
            // 
            labelMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMemory.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMemory.Location = new System.Drawing.Point(0, 0);
            labelMemory.Name = "labelMemory";
            labelMemory.Size = new System.Drawing.Size(100, 23);
            labelMemory.TabIndex = 0;
            labelMemory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ControlPanel
            // 
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "ControlPanel";
            Size = new System.Drawing.Size(50, 50);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarAudioGain).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarZoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSquelch).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkSerial;
        private System.Windows.Forms.ComboBox comboSerial;
        private System.Windows.Forms.Label labelControl;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelFilterBandwidth;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelTuningStep;
        private System.Windows.Forms.TrackBar trackBarAudioGain;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.TrackBar trackBarSquelch;
        private System.Windows.Forms.Label labelNoSquelch;
        private System.Windows.Forms.Label labelNoMemory;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.Label labelModeInfo;
        private System.Windows.Forms.Label labelModeValue;
        private System.Windows.Forms.Label labelTuningStepInfo;
        private System.Windows.Forms.Label labelTuningStepValue;
        private System.Windows.Forms.Label labelFilterBandwidthInfo;
        private System.Windows.Forms.Label labelFilterBandwidthValue;
        private System.Windows.Forms.Label labelSquelchThresholdInfo;
        private System.Windows.Forms.Label labelSquelchThresholdValue;
        private System.Windows.Forms.Label labelZoomInfo;
        private System.Windows.Forms.Label labelZoomValue;
    }
}
