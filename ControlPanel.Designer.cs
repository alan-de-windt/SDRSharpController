using System.ComponentModel.Design;
using System.Globalization;

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
            labelMode = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            labelNoMemory = new System.Windows.Forms.Label();
            labelControl = new System.Windows.Forms.Label();
            labelFrequency = new System.Windows.Forms.Label();
            labelFilterBandwidth = new System.Windows.Forms.Label();
            labelTuningStep = new System.Windows.Forms.Label();
            trackBarAudioGain = new System.Windows.Forms.TrackBar();
            trackBarZoom = new System.Windows.Forms.TrackBar();
            trackBarSquelch = new System.Windows.Forms.TrackBar();
            labelNoSquelch = new System.Windows.Forms.Label();
            labelMemory = new System.Windows.Forms.Label();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            groupBox4 = new System.Windows.Forms.GroupBox();
            labelModeInfo = new System.Windows.Forms.Label();
            labelModeValue = new System.Windows.Forms.Label();
            labelTuningStepInfo = new System.Windows.Forms.Label();
            labelTuningStepValue = new System.Windows.Forms.Label();
            labelFilterBandwidthInfo = new System.Windows.Forms.Label();
            labelFilterBandwidthValue = new System.Windows.Forms.Label();
            labelSquelchThresholdInfo = new System.Windows.Forms.Label();
            labelSquelchThresholdValue = new System.Windows.Forms.Label();
            labelZoomInfo = new System.Windows.Forms.Label();
            labelZoomValue = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarAudioGain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSquelch).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox4, 0, 3);
            tableLayoutPanel1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(200, 52);
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
            tableLayoutPanel2.TabStop = false;
            // 
            // comboSerial
            // 
            comboSerial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            comboSerial.Location = new System.Drawing.Point(3, 3);
            comboSerial.Name = "comboSerial";
            comboSerial.Size = new System.Drawing.Size(61, 28);
            comboSerial.TabStop = false;
            // 
            // checkSerial
            // 
            checkSerial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkSerial.Location = new System.Drawing.Point(70, 3);
            checkSerial.Name = "checkSerial";
            checkSerial.Size = new System.Drawing.Size(104, 20);
            checkSerial.Text = "Connect";
            checkSerial.CheckedChanged += CheckChangedSerial;
            checkSerial.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(3, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(200, 79);
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
            tableLayoutPanel3.TabStop = false;
            // 
            // labelMode
            // 
            labelMode.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMode.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMode.Location = new System.Drawing.Point(3, 25);
            labelMode.Name = "labelMode";
            labelMode.Size = new System.Drawing.Size(188, 28);
            labelMode.Text = "";
            labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelNoMemory);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox3.Location = new System.Drawing.Point(3, 146);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(200, 52);
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
            labelNoMemory.Text = "None";
            labelNoMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelControl
            // 
            labelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            labelControl.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelControl.Location = new System.Drawing.Point(0, 0);
            labelControl.Name = "labelControl";
            labelControl.Size = new System.Drawing.Size(100, 23);
            labelControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelControl.Text = "Not connected";
            // 
            // labelFrequency
            // 
            labelFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFrequency.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFrequency.Location = new System.Drawing.Point(0, 0);
            labelFrequency.Name = "labelFrequency";
            labelFrequency.Size = new System.Drawing.Size(100, 23);
            labelFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFilterBandwidth
            // 
            labelFilterBandwidth.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFilterBandwidth.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFilterBandwidth.Location = new System.Drawing.Point(0, 0);
            labelFilterBandwidth.Name = "labelFilterBandwidth";
            labelFilterBandwidth.Size = new System.Drawing.Size(100, 23);
            labelFilterBandwidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTuningStep
            // 
            labelTuningStep.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTuningStep.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTuningStep.Location = new System.Drawing.Point(0, 0);
            labelTuningStep.Name = "labelTuningStep";
            labelTuningStep.Size = new System.Drawing.Size(100, 23);
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
            trackBarAudioGain.TickFrequency = 10;
            trackBarAudioGain.Value = -60;
            trackBarAudioGain.TabStop = false;
            // 
            // trackBarZoom
            // 
            trackBarZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            trackBarZoom.Enabled = false;
            trackBarZoom.Location = new System.Drawing.Point(0, 0);
            trackBarZoom.Maximum = 60;
            trackBarZoom.Name = "trackBarZoom";
            trackBarZoom.Size = new System.Drawing.Size(104, 56);
            trackBarZoom.TickFrequency = 5;
            trackBarZoom.TabStop = false;
            // 
            // trackBarSquelch
            // 
            trackBarSquelch.Dock = System.Windows.Forms.DockStyle.Fill;
            trackBarSquelch.Enabled = false;
            trackBarSquelch.Location = new System.Drawing.Point(0, 0);
            trackBarSquelch.Maximum = 100;
            trackBarSquelch.Name = "trackBarSquelch";
            trackBarSquelch.Size = new System.Drawing.Size(104, 56);
            trackBarSquelch.TickFrequency = 10;
            trackBarSquelch.TabStop = false;
            // 
            // labelNoSquelch
            // 
            labelNoSquelch.Dock = System.Windows.Forms.DockStyle.Fill;
            labelNoSquelch.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNoSquelch.Location = new System.Drawing.Point(0, 0);
            labelNoSquelch.Name = "labelNoSquelch";
            labelNoSquelch.Size = new System.Drawing.Size(100, 23);
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
            labelMemory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 20);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            tableLayoutPanel4.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox4.Controls.Add(tableLayoutPanel4);
            groupBox4.Location = new System.Drawing.Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            groupBox4.Text = "Controller Settings";
            // 
            // labelModeInfo
            // 
            labelModeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelModeInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelModeInfo.Location = new System.Drawing.Point(0, 0);
            labelModeInfo.Name = "labelModeInfo";
            labelModeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            labelModeInfo.Text = "Mode:";
            labelModeInfo.Size = new System.Drawing.Size(100, 23);

            // 
            // labelModeValue
            // 
            labelModeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelModeValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelModeValue.Location = new System.Drawing.Point(0, 0);
            labelModeValue.Name = "labelModeValue";
            labelModeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelModeValue.Text = "";
            labelModeValue.Size = new System.Drawing.Size(100, 23);
            // 
            // labelTuningStepInfo
            // 
            labelTuningStepInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTuningStepInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTuningStepInfo.Location = new System.Drawing.Point(0, 0);
            labelTuningStepInfo.Name = "labelTuningStepInfo";
            labelTuningStepInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            labelTuningStepInfo.Text = "Tuning Step:";
            labelTuningStepInfo.Size = new System.Drawing.Size(100, 23);
            // 
            // labelTuningStepValue
            // 
            labelTuningStepValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTuningStepValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTuningStepValue.Location = new System.Drawing.Point(0, 0);
            labelTuningStepValue.Name = "labelTuningStepValue";
            labelTuningStepValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelTuningStepValue.Text = "";
            labelTuningStepValue.Size = new System.Drawing.Size(100, 23);
            // 
            // labelFilterBandwidthInfo
            // 
            labelFilterBandwidthInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFilterBandwidthInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFilterBandwidthInfo.Location = new System.Drawing.Point(0, 0);
            labelFilterBandwidthInfo.Name = "labelFilterBandwidthInfo";
            labelFilterBandwidthInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            labelFilterBandwidthInfo.Text = "Filter Bandwidth:";
            labelFilterBandwidthInfo.Size = new System.Drawing.Size(100, 23);
            // 
            // labelFilterBandwidthValue
            // 
            labelFilterBandwidthValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelFilterBandwidthValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelFilterBandwidthValue.Location = new System.Drawing.Point(0, 0);
            labelFilterBandwidthValue.Name = "labelFilterBandwidthValue";
            labelFilterBandwidthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelFilterBandwidthValue.Text = "";
            labelFilterBandwidthValue.Size = new System.Drawing.Size(100, 23);
            // 
            // labelSquelchThresholdInfo
            // 
            labelSquelchThresholdInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelSquelchThresholdInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSquelchThresholdInfo.Location = new System.Drawing.Point(0, 0);
            labelSquelchThresholdInfo.Name = "labelSquelchThresholdInfo";
            labelSquelchThresholdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            labelSquelchThresholdInfo.Text = "Squelch Threshold:";
            labelSquelchThresholdInfo.Size = new System.Drawing.Size(100, 23);
            // 
            // labelSquelchThresholdValue
            // 
            labelSquelchThresholdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelSquelchThresholdValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSquelchThresholdValue.Location = new System.Drawing.Point(0, 0);
            labelSquelchThresholdValue.Name = "labelSquelchThresholdValue";
            labelSquelchThresholdValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelSquelchThresholdValue.Text = "";
            labelSquelchThresholdValue.Size = new System.Drawing.Size(100, 23);
            // 
            // labelZoomInfo
            // 
            labelZoomInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            labelZoomInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelZoomInfo.Location = new System.Drawing.Point(0, 0);
            labelZoomInfo.Name = "labelZoomInfo";
            labelZoomInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            labelZoomInfo.Text = "Zoom:";
            labelZoomInfo.Size = new System.Drawing.Size(100, 23);
            // 
            // labelZoomValue
            // 
            labelZoomValue.Dock = System.Windows.Forms.DockStyle.Fill;
            labelZoomValue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelZoomValue.Location = new System.Drawing.Point(0, 0);
            labelZoomValue.Name = "labelZoomValue";
            labelZoomValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelZoomValue.Text = "";
            labelZoomValue.Size = new System.Drawing.Size(100, 23);
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
            tableLayoutPanel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
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
