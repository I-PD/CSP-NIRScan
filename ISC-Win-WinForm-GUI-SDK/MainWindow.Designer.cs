using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;

namespace ISC_Win_WinForm_GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_DeviceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_ErrorStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label_SensorBattStatus = new System.Windows.Forms.Label();
            this.Label_SensorBattCapacity = new System.Windows.Forms.Label();
            this.Label_SensorHumidity = new System.Windows.Forms.Label();
            this.Label_SensorSysTemp = new System.Windows.Forms.Label();
            this.Label_SensorTivaTemp = new System.Windows.Forms.Label();
            this.Label_SensorLampVM1Value = new System.Windows.Forms.Label();
            this.Label_SensorLampVM2Value = new System.Windows.Forms.Label();
            this.Label_SensorLampCM1Value = new System.Windows.Forms.Label();
            this.Label_SensorLampCM2Value = new System.Windows.Forms.Label();
            this.label_DevInfoGUIVer = new System.Windows.Forms.Label();
            this.label_DevInfoTivaSWVer = new System.Windows.Forms.Label();
            this.label_DevInfoDLPCVer = new System.Windows.Forms.Label();
            this.label_DevInfoMainBoardVer = new System.Windows.Forms.Label();
            this.label_DevInfoDetectorBoardVer = new System.Windows.Forms.Label();
            this.label_DevInfoModelName = new System.Windows.Forms.Label();
            this.label_DevInfoDevSerNum = new System.Windows.Forms.Label();
            this.label_DevInfoManfacSerNum = new System.Windows.Forms.Label();
            this.label_DevInfoUUID = new System.Windows.Forms.Label();
            this.label_DevInfoLampUsageValue = new System.Windows.Forms.Label();
            this.Label_BleNameValue = new System.Windows.Forms.Label();
            this.Label_CurrentConfig = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.ListBox_TargetCfgs = new System.Windows.Forms.ListBox();
            this.label_ActiveConfig = new System.Windows.Forms.Label();
            this.ListBox_LocalCfgs = new System.Windows.Forms.ListBox();
            this.Button_CopyCfgL2T = new System.Windows.Forms.Button();
            this.Button_CopyCfgT2L = new System.Windows.Forms.Button();
            this.Button_MoveCfgL2T = new System.Windows.Forms.Button();
            this.Button_MoveCfgT2L = new System.Windows.Forms.Button();
            this.CheckBox_SaveCombCSV = new System.Windows.Forms.CheckBox();
            this.GroupBox_ScanAvg = new System.Windows.Forms.GroupBox();
            this.Button_SaveNumAvgToConfig = new System.Windows.Forms.Button();
            this.textBox_ScanAvg = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.rb_tooltip4single = new System.Windows.Forms.RadioButton();
            this.rb_tooltip4multi = new System.Windows.Forms.RadioButton();
            this.timer_AutoClickScanButton = new System.Windows.Forms.Timer(this.components);
            this.tabPage_Utility = new System.Windows.Forms.TabPage();
            this.GroupBox_LogFile = new System.Windows.Forms.GroupBox();
            this.Button_DisableLog = new System.Windows.Forms.Button();
            this.Button_EnableLog = new System.Windows.Forms.Button();
            this.Label_LogStatus = new System.Windows.Forms.Label();
            this.GroupBox_BleName = new System.Windows.Forms.GroupBox();
            this.Button_Get_BLE_Display_Name = new System.Windows.Forms.Button();
            this.Button_Set_BLE_Display_Name = new System.Windows.Forms.Button();
            this.Button_Clear_BLE_Display_Name = new System.Windows.Forms.Button();
            this.TextBox_BLE_Display_Name = new System.Windows.Forms.TextBox();
            this.groupBox_Device = new System.Windows.Forms.GroupBox();
            this.button_SwitchDevice = new System.Windows.Forms.Button();
            this.textBox_FanOffTime = new System.Windows.Forms.TextBox();
            this.Button_GetFanDelayOffTime = new System.Windows.Forms.Button();
            this.Button_SetFanDelayOffTime = new System.Windows.Forms.Button();
            this.label_FanOffTimeSetting = new System.Windows.Forms.Label();
            this.button_restore_fac_ref_warning = new System.Windows.Forms.Button();
            this.Button_LockButton = new System.Windows.Forms.Button();
            this.Label_ButtonStatus = new System.Windows.Forms.Label();
            this.Button_UnlockButton = new System.Windows.Forms.Button();
            this.button_DeviceRestoreFacRef = new System.Windows.Forms.Button();
            this.label_RestoreFacRef = new System.Windows.Forms.Label();
            this.button_DeviceUpdateRef = new System.Windows.Forms.Button();
            this.label119 = new System.Windows.Forms.Label();
            this.button_DeviceResetSys = new System.Windows.Forms.Button();
            this.label118 = new System.Windows.Forms.Label();
            this.groupBox_ActivationKey = new System.Windows.Forms.GroupBox();
            this.label_ActivateStatus = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.button_KeySet = new System.Windows.Forms.Button();
            this.TextBox_Key = new System.Windows.Forms.TextBox();
            this.label117 = new System.Windows.Forms.Label();
            this.groupBox_DevInfo = new System.Windows.Forms.GroupBox();
            this.Label_Blename = new System.Windows.Forms.Label();
            this.label_DevInfoLampUsage = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label_MFC_Seri_Num = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.GroupBox_CalibCoeffs = new System.Windows.Forms.GroupBox();
            this.Button_Cal_WriteCoeffs = new System.Windows.Forms.Button();
            this.Button_Cal_ReadCoeffs = new System.Windows.Forms.Button();
            this.Button_Cal_RestoreDefaultCoeffs = new System.Windows.Forms.Button();
            this.Button_Cal_WriteGenCoeffs = new System.Windows.Forms.Button();
            this.CheckBox_Cal_WriteEnable = new System.Windows.Forms.CheckBox();
            this.TextBox_ShiftVectCoeff2 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.TextBox_ShiftVectCoeff1 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.TextBox_ShiftVectCoeff0 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TextBox_P2WCoeff2 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Label_ScanCfgVer = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.TextBox_P2WCoeff1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Label_RefCalVer = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TextBox_P2WCoeff0 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Label_CalCoeffVer = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.GroupBox_Sensors = new System.Windows.Forms.GroupBox();
            this.Button_SensorRead = new System.Windows.Forms.Button();
            this.Label_SensorLampCM2 = new System.Windows.Forms.Label();
            this.Label_SensorLampCM1 = new System.Windows.Forms.Label();
            this.Label_SensorLampVM2 = new System.Windows.Forms.Label();
            this.Label_SensorLampVM1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_sys_humidity = new System.Windows.Forms.Label();
            this.lb_BattCapTitle = new System.Windows.Forms.Label();
            this.lb_BattChargerStatusTitle = new System.Windows.Forms.Label();
            this.GroupBox_DateTime = new System.Windows.Forms.GroupBox();
            this.Button_DateTimeGet = new System.Windows.Forms.Button();
            this.Button_DateTimeSync = new System.Windows.Forms.Button();
            this.TextBox_DateTime = new System.Windows.Forms.TextBox();
            this.GroupBox_LampUsage = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_LampUsageGet = new System.Windows.Forms.Button();
            this.Button_LampUsageSet = new System.Windows.Forms.Button();
            this.TextBox_LampUsage = new System.Windows.Forms.TextBox();
            this.GroupBox_DLPC150FWUpdate = new System.Windows.Forms.GroupBox();
            this.Button_DLPC150FWUpdate = new System.Windows.Forms.Button();
            this.ProgressBar_DLPC150FWUpdateStatus = new System.Windows.Forms.ProgressBar();
            this.Button_DLPC150FWBrowse = new System.Windows.Forms.Button();
            this.TextBox_DLPC150FWPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupBox_TivaFWUpdate = new System.Windows.Forms.GroupBox();
            this.Button_TivaFWUpdate = new System.Windows.Forms.Button();
            this.ProgressBar_TivaFWUpdateStatus = new System.Windows.Forms.ProgressBar();
            this.Button_TivaFWBrowse = new System.Windows.Forms.Button();
            this.TextBox_TivaFWPath = new System.Windows.Forms.TextBox();
            this.Label_TivaFWName = new System.Windows.Forms.Label();
            this.GroupBox_SerialNumber = new System.Windows.Forms.GroupBox();
            this.Button_SerialNumberGet = new System.Windows.Forms.Button();
            this.Button_SerialNumberSet = new System.Windows.Forms.Button();
            this.TextBox_SerialNumber = new System.Windows.Forms.TextBox();
            this.GroupBox_ModelName = new System.Windows.Forms.GroupBox();
            this.Button_ModelNameGet = new System.Windows.Forms.Button();
            this.Button_ModelNameSet = new System.Windows.Forms.Button();
            this.TextBox_ModelName = new System.Windows.Forms.TextBox();
            this.tabPage_Scan = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_ClearPlots = new System.Windows.Forms.Button();
            this.Button_ClearAllErrors = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyChart = new LiveCharts.WinForms.CartesianChart();
            this.Check_Overlay = new System.Windows.Forms.CheckBox();
            this.RadioButton_Reference = new System.Windows.Forms.RadioButton();
            this.RadioButton_Intensity = new System.Windows.Forms.RadioButton();
            this.RadioButton_Absorbance = new System.Windows.Forms.RadioButton();
            this.RadioButton_Reflectance = new System.Windows.Forms.RadioButton();
            this.Label_EstimatedScanTime = new System.Windows.Forms.Label();
            this.Label_ScanStatus = new System.Windows.Forms.Label();
            this.tabScanPositions = new System.Windows.Forms.TabControl();
            this.tabPage_SavePositions = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox_GainControl = new System.Windows.Forms.GroupBox();
            this.CheckBox_AutoGain = new System.Windows.Forms.CheckBox();
            this.ComboBox_PGAGain = new MyComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox_SaveScan = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBox_AverageCSV = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBox_FileNamePrefix3 = new System.Windows.Forms.TextBox();
            this.TextBox_FileNamePrefix2 = new System.Windows.Forms.TextBox();
            this.CheckBox_SaveOneCSV = new System.Windows.Forms.CheckBox();
            this.TextBox_FileNamePrefix1 = new System.Windows.Forms.TextBox();
            this.CheckBox_FileNamePrefix = new System.Windows.Forms.CheckBox();
            this.TextBox_SaveDirPath = new System.Windows.Forms.TextBox();
            this.Button_SaveDirChange = new System.Windows.Forms.Button();
            this.CheckBox_SaveRCSV = new System.Windows.Forms.CheckBox();
            this.CheckBox_SaveACSV = new System.Windows.Forms.CheckBox();
            this.CheckBox_SaveICSV = new System.Windows.Forms.CheckBox();
            this.GroupBox_LampControl = new System.Windows.Forms.GroupBox();
            this.TextBox_LampStableTime = new System.Windows.Forms.TextBox();
            this.RadioButton_LampStableTime = new System.Windows.Forms.RadioButton();
            this.button_Undo = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_COMport = new System.Windows.Forms.ComboBox();
            this.label_usb = new System.Windows.Forms.Label();
            this.groupBox_Display = new System.Windows.Forms.GroupBox();
            this.groupBox_plate4 = new System.Windows.Forms.GroupBox();
            this.checkBox_Pos24 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos22 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos23 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos21 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos19 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos20 = new System.Windows.Forms.CheckBox();
            this.groupBox_plate3 = new System.Windows.Forms.GroupBox();
            this.checkBox_Pos18 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos16 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos17 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos15 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos13 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos14 = new System.Windows.Forms.CheckBox();
            this.groupBox_plate2 = new System.Windows.Forms.GroupBox();
            this.checkBox_Pos12 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos10 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos11 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos9 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos7 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos8 = new System.Windows.Forms.CheckBox();
            this.groupBox_plate1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Pos6 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos4 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos5 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos3 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Pos2 = new System.Windows.Forms.CheckBox();
            this.tabPage_ScanConfig = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Button_SetActive = new System.Windows.Forms.Button();
            this.Button_CfgCancel = new System.Windows.Forms.Button();
            this.Button_CfgSave = new System.Windows.Forms.Button();
            this.Button_CfgDelete = new System.Windows.Forms.Button();
            this.Button_CfgEdit = new System.Windows.Forms.Button();
            this.Button_CfgNew = new System.Windows.Forms.Button();
            this.GroupBox_CfgDetails = new System.Windows.Forms.GroupBox();
            this.label_overSampleRate5 = new System.Windows.Forms.Label();
            this.label_overSampleRate4 = new System.Windows.Forms.Label();
            this.label_overSampleRate3 = new System.Windows.Forms.Label();
            this.label_overSampleRate2 = new System.Windows.Forms.Label();
            this.label_overSampleRate1 = new System.Windows.Forms.Label();
            this.comboBox_cfgNumSec = new MyComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.TextBox_CfgDigRes1 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgDigRes2 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgDigRes3 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgDigRes4 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgDigRes5 = new System.Windows.Forms.TextBox();
            this.ComboBox_CfgExposure1 = new System.Windows.Forms.ComboBox();
            this.ComboBox_CfgExposure2 = new System.Windows.Forms.ComboBox();
            this.ComboBox_CfgExposure3 = new System.Windows.Forms.ComboBox();
            this.ComboBox_CfgExposure4 = new System.Windows.Forms.ComboBox();
            this.ComboBox_CfgExposure5 = new System.Windows.Forms.ComboBox();
            this.ComboBox_CfgWidth1 = new MyComboBox();
            this.ComboBox_CfgWidth2 = new MyComboBox();
            this.ComboBox_CfgWidth3 = new MyComboBox();
            this.ComboBox_CfgWidth4 = new MyComboBox();
            this.ComboBox_CfgWidth5 = new MyComboBox();
            this.TextBox_CfgRangeEnd1 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgRangeEnd2 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgRangeEnd3 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgRangeEnd4 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgRangeEnd5 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgRangeStart1 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgRangeStart2 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgRangeStart3 = new System.Windows.Forms.TextBox();
            this.TextBox_CfgRangeStart4 = new System.Windows.Forms.TextBox();
            this.ComboBox_CfgScanType1 = new MyComboBox();
            this.ComboBox_CfgScanType2 = new MyComboBox();
            this.ComboBox_CfgScanType3 = new MyComboBox();
            this.ComboBox_CfgScanType4 = new MyComboBox();
            this.TextBox_CfgRangeStart5 = new System.Windows.Forms.TextBox();
            this.ComboBox_CfgScanType5 = new MyComboBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.TextBox_CfgAvg = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.TextBox_CfgName = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.tabPage_SaveScans = new System.Windows.Forms.TabPage();
            this.panel_Saved_Scan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_FileListRefresh = new System.Windows.Forms.Button();
            this.RadioButton_SavedScanSelDat = new System.Windows.Forms.RadioButton();
            this.RadioButton_SavedScanSelCsv = new System.Windows.Forms.RadioButton();
            this.totalScan = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_filter = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView_savescan = new System.Windows.Forms.DataGridView();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.Label_SavedAvg = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.Label_SavedExposure1 = new System.Windows.Forms.Label();
            this.Label_SavedExposure2 = new System.Windows.Forms.Label();
            this.Label_SavedExposure3 = new System.Windows.Forms.Label();
            this.Label_SavedExposure4 = new System.Windows.Forms.Label();
            this.Label_SavedExposure5 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.Label_SavedDigRes1 = new System.Windows.Forms.Label();
            this.Label_SavedDigRes2 = new System.Windows.Forms.Label();
            this.Label_SavedDigRes3 = new System.Windows.Forms.Label();
            this.Label_SavedDigRes4 = new System.Windows.Forms.Label();
            this.Label_SavedDigRes5 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.Label_SavedWidth1 = new System.Windows.Forms.Label();
            this.Label_SavedWidth2 = new System.Windows.Forms.Label();
            this.Label_SavedWidth3 = new System.Windows.Forms.Label();
            this.Label_SavedWidth4 = new System.Windows.Forms.Label();
            this.Label_SavedWidth5 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.Label_SavedRangeEnd1 = new System.Windows.Forms.Label();
            this.Label_SavedRangeEnd2 = new System.Windows.Forms.Label();
            this.Label_SavedRangeEnd3 = new System.Windows.Forms.Label();
            this.Label_SavedRangeEnd4 = new System.Windows.Forms.Label();
            this.Label_SavedRangeEnd5 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.Label_SavedRangeStart1 = new System.Windows.Forms.Label();
            this.Label_SavedRangeStart2 = new System.Windows.Forms.Label();
            this.Label_SavedRangeStart3 = new System.Windows.Forms.Label();
            this.Label_SavedRangeStart4 = new System.Windows.Forms.Label();
            this.Label_SavedRangeStart5 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.Label_SavedScanType1 = new System.Windows.Forms.Label();
            this.Label_SavedScanType2 = new System.Windows.Forms.Label();
            this.Label_SavedScanType3 = new System.Windows.Forms.Label();
            this.Label_SavedScanType4 = new System.Windows.Forms.Label();
            this.Label_SavedScanType5 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.Button_DisplayDirChange = new System.Windows.Forms.Button();
            this.TextBox_SavedFileDirPath = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.tabPage_PickTable = new System.Windows.Forms.TabPage();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_TestSequence = new System.Windows.Forms.Button();
            this.dataGridView_Table = new System.Windows.Forms.DataGridView();
            this.tabPage_ChemicalImage = new System.Windows.Forms.TabPage();
            this.label_CI = new System.Windows.Forms.Label();
            this.pictureBox_heatMap = new System.Windows.Forms.PictureBox();
            this.checkBox_tooltip = new System.Windows.Forms.CheckBox();
            this.tabControl_MainFunctions = new System.Windows.Forms.TabControl();
            this.tabPage_PosData = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox_Subtype = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Material = new System.Windows.Forms.TextBox();
            this.labelModelingMaterial = new System.Windows.Forms.Label();
            this.labelPredictions = new System.Windows.Forms.Label();
            this.dataGridView_Predicitons = new System.Windows.Forms.DataGridView();
            this.btnTrain = new System.Windows.Forms.Button();
            this.pictureBox_BestModel = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.GroupBox_ScanAvg.SuspendLayout();
            this.tabPage_Utility.SuspendLayout();
            this.GroupBox_LogFile.SuspendLayout();
            this.GroupBox_BleName.SuspendLayout();
            this.groupBox_Device.SuspendLayout();
            this.groupBox_ActivationKey.SuspendLayout();
            this.groupBox_DevInfo.SuspendLayout();
            this.GroupBox_CalibCoeffs.SuspendLayout();
            this.GroupBox_Sensors.SuspendLayout();
            this.GroupBox_DateTime.SuspendLayout();
            this.GroupBox_LampUsage.SuspendLayout();
            this.GroupBox_DLPC150FWUpdate.SuspendLayout();
            this.GroupBox_TivaFWUpdate.SuspendLayout();
            this.GroupBox_SerialNumber.SuspendLayout();
            this.GroupBox_ModelName.SuspendLayout();
            this.tabPage_Scan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabScanPositions.SuspendLayout();
            this.tabPage_SavePositions.SuspendLayout();
            this.GroupBox_GainControl.SuspendLayout();
            this.GroupBox_SaveScan.SuspendLayout();
            this.GroupBox_LampControl.SuspendLayout();
            this.groupBox_Display.SuspendLayout();
            this.groupBox_plate4.SuspendLayout();
            this.groupBox_plate3.SuspendLayout();
            this.groupBox_plate2.SuspendLayout();
            this.groupBox_plate1.SuspendLayout();
            this.tabPage_ScanConfig.SuspendLayout();
            this.GroupBox_CfgDetails.SuspendLayout();
            this.tabPage_SaveScans.SuspendLayout();
            this.panel_Saved_Scan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_savescan)).BeginInit();
            this.tabPage_PickTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).BeginInit();
            this.tabPage_ChemicalImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heatMap)).BeginInit();
            this.tabControl_MainFunctions.SuspendLayout();
            this.tabPage_PosData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Predicitons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BestModel)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_DeviceStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 816);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1578, 33);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus_DeviceStatus
            // 
            this.toolStripStatus_DeviceStatus.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatus_DeviceStatus.Image")));
            this.toolStripStatus_DeviceStatus.Name = "toolStripStatus_DeviceStatus";
            this.toolStripStatus_DeviceStatus.Size = new System.Drawing.Size(155, 27);
            this.toolStripStatus_DeviceStatus.Text = "Device Disconnect!";
            // 
            // label_ErrorStatus
            // 
            this.label_ErrorStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ErrorStatus.AutoSize = true;
            this.label_ErrorStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_ErrorStatus.Location = new System.Drawing.Point(1281, -635);
            this.label_ErrorStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ErrorStatus.Name = "label_ErrorStatus";
            this.label_ErrorStatus.Size = new System.Drawing.Size(0, 17);
            this.label_ErrorStatus.TabIndex = 3;
            // 
            // Label_SensorBattStatus
            // 
            this.Label_SensorBattStatus.Location = new System.Drawing.Point(221, 22);
            this.Label_SensorBattStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorBattStatus.Name = "Label_SensorBattStatus";
            this.Label_SensorBattStatus.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorBattStatus.TabIndex = 7;
            this.toolTip1.SetToolTip(this.Label_SensorBattStatus, "Double Click to Copy Text");
            // 
            // Label_SensorBattCapacity
            // 
            this.Label_SensorBattCapacity.Location = new System.Drawing.Point(221, 54);
            this.Label_SensorBattCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorBattCapacity.Name = "Label_SensorBattCapacity";
            this.Label_SensorBattCapacity.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorBattCapacity.TabIndex = 8;
            this.toolTip1.SetToolTip(this.Label_SensorBattCapacity, "Double Click to Copy Text");
            // 
            // Label_SensorHumidity
            // 
            this.Label_SensorHumidity.Location = new System.Drawing.Point(221, 85);
            this.Label_SensorHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorHumidity.Name = "Label_SensorHumidity";
            this.Label_SensorHumidity.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorHumidity.TabIndex = 9;
            this.toolTip1.SetToolTip(this.Label_SensorHumidity, "Double Click to Copy Text");
            // 
            // Label_SensorSysTemp
            // 
            this.Label_SensorSysTemp.Location = new System.Drawing.Point(221, 116);
            this.Label_SensorSysTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorSysTemp.Name = "Label_SensorSysTemp";
            this.Label_SensorSysTemp.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorSysTemp.TabIndex = 10;
            this.toolTip1.SetToolTip(this.Label_SensorSysTemp, "Double Click to Copy Text");
            // 
            // Label_SensorTivaTemp
            // 
            this.Label_SensorTivaTemp.Location = new System.Drawing.Point(221, 148);
            this.Label_SensorTivaTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorTivaTemp.Name = "Label_SensorTivaTemp";
            this.Label_SensorTivaTemp.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorTivaTemp.TabIndex = 11;
            this.toolTip1.SetToolTip(this.Label_SensorTivaTemp, "Double Click to Copy Text");
            // 
            // Label_SensorLampVM1Value
            // 
            this.Label_SensorLampVM1Value.Location = new System.Drawing.Point(221, 179);
            this.Label_SensorLampVM1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorLampVM1Value.Name = "Label_SensorLampVM1Value";
            this.Label_SensorLampVM1Value.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorLampVM1Value.TabIndex = 12;
            this.toolTip1.SetToolTip(this.Label_SensorLampVM1Value, "Double Click to Copy Text");
            // 
            // Label_SensorLampVM2Value
            // 
            this.Label_SensorLampVM2Value.Location = new System.Drawing.Point(221, 241);
            this.Label_SensorLampVM2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorLampVM2Value.Name = "Label_SensorLampVM2Value";
            this.Label_SensorLampVM2Value.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorLampVM2Value.TabIndex = 17;
            this.toolTip1.SetToolTip(this.Label_SensorLampVM2Value, "Double Click to Copy Text");
            // 
            // Label_SensorLampCM1Value
            // 
            this.Label_SensorLampCM1Value.Location = new System.Drawing.Point(221, 210);
            this.Label_SensorLampCM1Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorLampCM1Value.Name = "Label_SensorLampCM1Value";
            this.Label_SensorLampCM1Value.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorLampCM1Value.TabIndex = 18;
            this.toolTip1.SetToolTip(this.Label_SensorLampCM1Value, "Double Click to Copy Text");
            // 
            // Label_SensorLampCM2Value
            // 
            this.Label_SensorLampCM2Value.Location = new System.Drawing.Point(220, 272);
            this.Label_SensorLampCM2Value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorLampCM2Value.Name = "Label_SensorLampCM2Value";
            this.Label_SensorLampCM2Value.Size = new System.Drawing.Size(161, 18);
            this.Label_SensorLampCM2Value.TabIndex = 19;
            this.toolTip1.SetToolTip(this.Label_SensorLampCM2Value, "Double Click to Copy Text");
            // 
            // label_DevInfoGUIVer
            // 
            this.label_DevInfoGUIVer.Location = new System.Drawing.Point(225, 22);
            this.label_DevInfoGUIVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoGUIVer.Name = "label_DevInfoGUIVer";
            this.label_DevInfoGUIVer.Size = new System.Drawing.Size(200, 19);
            this.label_DevInfoGUIVer.TabIndex = 1;
            this.toolTip1.SetToolTip(this.label_DevInfoGUIVer, "Double Click to Copy Text");
            this.label_DevInfoGUIVer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoTivaSWVer
            // 
            this.label_DevInfoTivaSWVer.Location = new System.Drawing.Point(225, 51);
            this.label_DevInfoTivaSWVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoTivaSWVer.Name = "label_DevInfoTivaSWVer";
            this.label_DevInfoTivaSWVer.Size = new System.Drawing.Size(200, 19);
            this.label_DevInfoTivaSWVer.TabIndex = 3;
            this.toolTip1.SetToolTip(this.label_DevInfoTivaSWVer, "Double Click to Copy Text");
            this.label_DevInfoTivaSWVer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoDLPCVer
            // 
            this.label_DevInfoDLPCVer.Location = new System.Drawing.Point(225, 81);
            this.label_DevInfoDLPCVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoDLPCVer.Name = "label_DevInfoDLPCVer";
            this.label_DevInfoDLPCVer.Size = new System.Drawing.Size(200, 18);
            this.label_DevInfoDLPCVer.TabIndex = 5;
            this.toolTip1.SetToolTip(this.label_DevInfoDLPCVer, "Double Click to Copy Text");
            this.label_DevInfoDLPCVer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoMainBoardVer
            // 
            this.label_DevInfoMainBoardVer.Location = new System.Drawing.Point(225, 110);
            this.label_DevInfoMainBoardVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoMainBoardVer.Name = "label_DevInfoMainBoardVer";
            this.label_DevInfoMainBoardVer.Size = new System.Drawing.Size(200, 18);
            this.label_DevInfoMainBoardVer.TabIndex = 9;
            this.toolTip1.SetToolTip(this.label_DevInfoMainBoardVer, "Double Click to Copy Text");
            this.label_DevInfoMainBoardVer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoDetectorBoardVer
            // 
            this.label_DevInfoDetectorBoardVer.Location = new System.Drawing.Point(225, 138);
            this.label_DevInfoDetectorBoardVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoDetectorBoardVer.Name = "label_DevInfoDetectorBoardVer";
            this.label_DevInfoDetectorBoardVer.Size = new System.Drawing.Size(200, 18);
            this.label_DevInfoDetectorBoardVer.TabIndex = 11;
            this.toolTip1.SetToolTip(this.label_DevInfoDetectorBoardVer, "Double Click to Copy Text");
            this.label_DevInfoDetectorBoardVer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoModelName
            // 
            this.label_DevInfoModelName.Location = new System.Drawing.Point(225, 166);
            this.label_DevInfoModelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoModelName.Name = "label_DevInfoModelName";
            this.label_DevInfoModelName.Size = new System.Drawing.Size(200, 18);
            this.label_DevInfoModelName.TabIndex = 13;
            this.toolTip1.SetToolTip(this.label_DevInfoModelName, "Double Click to Copy Text");
            this.label_DevInfoModelName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoDevSerNum
            // 
            this.label_DevInfoDevSerNum.Location = new System.Drawing.Point(225, 196);
            this.label_DevInfoDevSerNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoDevSerNum.Name = "label_DevInfoDevSerNum";
            this.label_DevInfoDevSerNum.Size = new System.Drawing.Size(200, 16);
            this.label_DevInfoDevSerNum.TabIndex = 15;
            this.toolTip1.SetToolTip(this.label_DevInfoDevSerNum, "Double Click to Copy Text");
            this.label_DevInfoDevSerNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoManfacSerNum
            // 
            this.label_DevInfoManfacSerNum.Location = new System.Drawing.Point(225, 225);
            this.label_DevInfoManfacSerNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoManfacSerNum.Name = "label_DevInfoManfacSerNum";
            this.label_DevInfoManfacSerNum.Size = new System.Drawing.Size(200, 18);
            this.label_DevInfoManfacSerNum.TabIndex = 17;
            this.toolTip1.SetToolTip(this.label_DevInfoManfacSerNum, "Double Click to Copy Text");
            this.label_DevInfoManfacSerNum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoUUID
            // 
            this.label_DevInfoUUID.Location = new System.Drawing.Point(225, 254);
            this.label_DevInfoUUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoUUID.Name = "label_DevInfoUUID";
            this.label_DevInfoUUID.Size = new System.Drawing.Size(200, 18);
            this.label_DevInfoUUID.TabIndex = 19;
            this.toolTip1.SetToolTip(this.label_DevInfoUUID, "Double Click to Copy Text");
            this.label_DevInfoUUID.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // label_DevInfoLampUsageValue
            // 
            this.label_DevInfoLampUsageValue.Location = new System.Drawing.Point(225, 282);
            this.label_DevInfoLampUsageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoLampUsageValue.Name = "label_DevInfoLampUsageValue";
            this.label_DevInfoLampUsageValue.Size = new System.Drawing.Size(200, 18);
            this.label_DevInfoLampUsageValue.TabIndex = 21;
            this.toolTip1.SetToolTip(this.label_DevInfoLampUsageValue, "Double Click to Copy Text");
            this.label_DevInfoLampUsageValue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // Label_BleNameValue
            // 
            this.Label_BleNameValue.Enabled = false;
            this.Label_BleNameValue.Location = new System.Drawing.Point(225, 311);
            this.Label_BleNameValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_BleNameValue.Name = "Label_BleNameValue";
            this.Label_BleNameValue.Size = new System.Drawing.Size(200, 18);
            this.Label_BleNameValue.TabIndex = 23;
            this.Label_BleNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.Label_BleNameValue, "Double Click to Copy Text");
            this.Label_BleNameValue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseDoubleClick);
            // 
            // Label_CurrentConfig
            // 
            this.Label_CurrentConfig.Location = new System.Drawing.Point(394, 18);
            this.Label_CurrentConfig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_CurrentConfig.Name = "Label_CurrentConfig";
            this.Label_CurrentConfig.Size = new System.Drawing.Size(294, 34);
            this.Label_CurrentConfig.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Label_CurrentConfig, "Current scan configuration for scan.\r\nMouse click to quick change configuration.");
            this.Label_CurrentConfig.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label_CurrentConfig_MouseClick);
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(10, 266);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 16);
            this.label14.TabIndex = 59;
            this.label14.Text = "Oversampling";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label14, "The maximum resolution is limited by 3x pattern overlap.");
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label94.Location = new System.Drawing.Point(280, 9);
            this.label94.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(180, 17);
            this.label94.TabIndex = 7;
            this.label94.Text = "Device Default Configuration : ";
            this.label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label94, "Config that actively applied at device boot-up");
            // 
            // ListBox_TargetCfgs
            // 
            this.ListBox_TargetCfgs.FormattingEnabled = true;
            this.ListBox_TargetCfgs.ItemHeight = 15;
            this.ListBox_TargetCfgs.Location = new System.Drawing.Point(279, 68);
            this.ListBox_TargetCfgs.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox_TargetCfgs.Name = "ListBox_TargetCfgs";
            this.ListBox_TargetCfgs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_TargetCfgs.Size = new System.Drawing.Size(200, 259);
            this.ListBox_TargetCfgs.TabIndex = 41;
            this.toolTip1.SetToolTip(this.ListBox_TargetCfgs, "Device Config List");
            this.ListBox_TargetCfgs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_TargetCfgs_MouseClick);
            this.ListBox_TargetCfgs.SelectedIndexChanged += new System.EventHandler(this.ListBox_TargetCfgs_SelectedIndexChanged);
            this.ListBox_TargetCfgs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_TargetCfgs_MouseDoubleClick);
            // 
            // label_ActiveConfig
            // 
            this.label_ActiveConfig.AutoSize = true;
            this.label_ActiveConfig.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_ActiveConfig.Location = new System.Drawing.Point(280, 26);
            this.label_ActiveConfig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ActiveConfig.Name = "label_ActiveConfig";
            this.label_ActiveConfig.Size = new System.Drawing.Size(60, 17);
            this.label_ActiveConfig.TabIndex = 10;
            this.label_ActiveConfig.Text = "Column 1";
            this.label_ActiveConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label_ActiveConfig, "Config that actively applied at device boot-up");
            // 
            // ListBox_LocalCfgs
            // 
            this.ListBox_LocalCfgs.FormattingEnabled = true;
            this.ListBox_LocalCfgs.ItemHeight = 15;
            this.ListBox_LocalCfgs.Location = new System.Drawing.Point(8, 68);
            this.ListBox_LocalCfgs.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox_LocalCfgs.Name = "ListBox_LocalCfgs";
            this.ListBox_LocalCfgs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox_LocalCfgs.Size = new System.Drawing.Size(200, 259);
            this.ListBox_LocalCfgs.TabIndex = 40;
            this.toolTip1.SetToolTip(this.ListBox_LocalCfgs, "Local Config List");
            this.ListBox_LocalCfgs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_LocalCfgs_MouseClick);
            this.ListBox_LocalCfgs.SelectedIndexChanged += new System.EventHandler(this.ListBox_LocalCfgs_SelectedIndexChanged);
            this.ListBox_LocalCfgs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_LocalCfgs_MouseDoubleClick);
            // 
            // Button_CopyCfgL2T
            // 
            this.Button_CopyCfgL2T.Location = new System.Drawing.Point(212, 86);
            this.Button_CopyCfgL2T.Margin = new System.Windows.Forms.Padding(4);
            this.Button_CopyCfgL2T.Name = "Button_CopyCfgL2T";
            this.Button_CopyCfgL2T.Size = new System.Drawing.Size(62, 44);
            this.Button_CopyCfgL2T.TabIndex = 42;
            this.Button_CopyCfgL2T.Text = "Copy";
            this.toolTip1.SetToolTip(this.Button_CopyCfgL2T, "Copy config from local to device");
            this.Button_CopyCfgL2T.UseVisualStyleBackColor = true;
            this.Button_CopyCfgL2T.Click += new System.EventHandler(this.Button_CopyCfgL2T_Click);
            // 
            // Button_CopyCfgT2L
            // 
            this.Button_CopyCfgT2L.Location = new System.Drawing.Point(212, 152);
            this.Button_CopyCfgT2L.Margin = new System.Windows.Forms.Padding(4);
            this.Button_CopyCfgT2L.Name = "Button_CopyCfgT2L";
            this.Button_CopyCfgT2L.Size = new System.Drawing.Size(62, 44);
            this.Button_CopyCfgT2L.TabIndex = 43;
            this.Button_CopyCfgT2L.Text = "Copy";
            this.toolTip1.SetToolTip(this.Button_CopyCfgT2L, "Copy config from device to local");
            this.Button_CopyCfgT2L.UseVisualStyleBackColor = true;
            this.Button_CopyCfgT2L.Click += new System.EventHandler(this.Button_CopyCfgT2L_Click);
            // 
            // Button_MoveCfgL2T
            // 
            this.Button_MoveCfgL2T.Location = new System.Drawing.Point(212, 219);
            this.Button_MoveCfgL2T.Margin = new System.Windows.Forms.Padding(4);
            this.Button_MoveCfgL2T.Name = "Button_MoveCfgL2T";
            this.Button_MoveCfgL2T.Size = new System.Drawing.Size(62, 44);
            this.Button_MoveCfgL2T.TabIndex = 44;
            this.Button_MoveCfgL2T.Text = "Move";
            this.toolTip1.SetToolTip(this.Button_MoveCfgL2T, "Move config from local to device");
            this.Button_MoveCfgL2T.UseVisualStyleBackColor = true;
            this.Button_MoveCfgL2T.Click += new System.EventHandler(this.Button_MoveCfgL2T_Click);
            // 
            // Button_MoveCfgT2L
            // 
            this.Button_MoveCfgT2L.Location = new System.Drawing.Point(212, 285);
            this.Button_MoveCfgT2L.Margin = new System.Windows.Forms.Padding(4);
            this.Button_MoveCfgT2L.Name = "Button_MoveCfgT2L";
            this.Button_MoveCfgT2L.Size = new System.Drawing.Size(62, 44);
            this.Button_MoveCfgT2L.TabIndex = 45;
            this.Button_MoveCfgT2L.Text = "Move";
            this.toolTip1.SetToolTip(this.Button_MoveCfgT2L, "Move config from device to local");
            this.Button_MoveCfgT2L.UseVisualStyleBackColor = true;
            this.Button_MoveCfgT2L.Click += new System.EventHandler(this.Button_MoveCfgT2L_Click);
            // 
            // CheckBox_SaveCombCSV
            // 
            this.CheckBox_SaveCombCSV.AutoSize = true;
            this.CheckBox_SaveCombCSV.Checked = true;
            this.CheckBox_SaveCombCSV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_SaveCombCSV.Location = new System.Drawing.Point(24, 35);
            this.CheckBox_SaveCombCSV.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_SaveCombCSV.Name = "CheckBox_SaveCombCSV";
            this.CheckBox_SaveCombCSV.Size = new System.Drawing.Size(58, 21);
            this.CheckBox_SaveCombCSV.TabIndex = 0;
            this.CheckBox_SaveCombCSV.TabStop = false;
            this.CheckBox_SaveCombCSV.Text = "*.csv";
            this.toolTip1.SetToolTip(this.CheckBox_SaveCombCSV, "Mouse right-click to change the output CSV delimiter.");
            this.CheckBox_SaveCombCSV.UseVisualStyleBackColor = true;
            // 
            // GroupBox_ScanAvg
            // 
            this.GroupBox_ScanAvg.Controls.Add(this.Button_SaveNumAvgToConfig);
            this.GroupBox_ScanAvg.Controls.Add(this.textBox_ScanAvg);
            this.GroupBox_ScanAvg.Controls.Add(this.label34);
            this.GroupBox_ScanAvg.Location = new System.Drawing.Point(6, 429);
            this.GroupBox_ScanAvg.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_ScanAvg.Name = "GroupBox_ScanAvg";
            this.GroupBox_ScanAvg.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_ScanAvg.Size = new System.Drawing.Size(480, 66);
            this.GroupBox_ScanAvg.TabIndex = 9;
            this.GroupBox_ScanAvg.TabStop = false;
            this.GroupBox_ScanAvg.Text = "Scan Average";
            this.toolTip1.SetToolTip(this.GroupBox_ScanAvg, "The value is temporarily changed only. Click \"Apply to Config\" to save it into th" +
        "e config permanently.");
            // 
            // Button_SaveNumAvgToConfig
            // 
            this.Button_SaveNumAvgToConfig.Enabled = false;
            this.Button_SaveNumAvgToConfig.Location = new System.Drawing.Point(315, 22);
            this.Button_SaveNumAvgToConfig.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SaveNumAvgToConfig.Name = "Button_SaveNumAvgToConfig";
            this.Button_SaveNumAvgToConfig.Size = new System.Drawing.Size(158, 32);
            this.Button_SaveNumAvgToConfig.TabIndex = 2;
            this.Button_SaveNumAvgToConfig.Text = "Save to Config";
            this.Button_SaveNumAvgToConfig.UseVisualStyleBackColor = true;
            // 
            // textBox_ScanAvg
            // 
            this.textBox_ScanAvg.Location = new System.Drawing.Point(174, 26);
            this.textBox_ScanAvg.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ScanAvg.Name = "textBox_ScanAvg";
            this.textBox_ScanAvg.Size = new System.Drawing.Size(129, 24);
            this.textBox_ScanAvg.TabIndex = 1;
            this.textBox_ScanAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_ScanAvg, "The value is temporarily changed for scan only. Click \"Save to Config\" to save it" +
        " into the config permanently.");
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(21, 30);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(143, 17);
            this.label34.TabIndex = 0;
            this.label34.Text = "Num Scans of Average : ";
            this.toolTip1.SetToolTip(this.label34, "The value is temporarily changed only. Click \"Apply to Config\" to save it into th" +
        "e config permanently.");
            // 
            // rb_tooltip4single
            // 
            this.rb_tooltip4single.Location = new System.Drawing.Point(0, 0);
            this.rb_tooltip4single.Name = "rb_tooltip4single";
            this.rb_tooltip4single.Size = new System.Drawing.Size(104, 24);
            this.rb_tooltip4single.TabIndex = 0;
            // 
            // rb_tooltip4multi
            // 
            this.rb_tooltip4multi.Location = new System.Drawing.Point(0, 0);
            this.rb_tooltip4multi.Name = "rb_tooltip4multi";
            this.rb_tooltip4multi.Size = new System.Drawing.Size(104, 24);
            this.rb_tooltip4multi.TabIndex = 0;
            // 
            // timer_AutoClickScanButton
            // 
            this.timer_AutoClickScanButton.Interval = 8000;
            this.timer_AutoClickScanButton.Tick += new System.EventHandler(this.timer_AutoClickScanButton_Tick);
            // 
            // tabPage_Utility
            // 
            this.tabPage_Utility.Controls.Add(this.GroupBox_LogFile);
            this.tabPage_Utility.Controls.Add(this.GroupBox_BleName);
            this.tabPage_Utility.Controls.Add(this.groupBox_Device);
            this.tabPage_Utility.Controls.Add(this.groupBox_ActivationKey);
            this.tabPage_Utility.Controls.Add(this.groupBox_DevInfo);
            this.tabPage_Utility.Controls.Add(this.GroupBox_CalibCoeffs);
            this.tabPage_Utility.Controls.Add(this.GroupBox_Sensors);
            this.tabPage_Utility.Controls.Add(this.GroupBox_DateTime);
            this.tabPage_Utility.Controls.Add(this.GroupBox_LampUsage);
            this.tabPage_Utility.Controls.Add(this.GroupBox_DLPC150FWUpdate);
            this.tabPage_Utility.Controls.Add(this.GroupBox_TivaFWUpdate);
            this.tabPage_Utility.Controls.Add(this.GroupBox_SerialNumber);
            this.tabPage_Utility.Controls.Add(this.GroupBox_ModelName);
            this.tabPage_Utility.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Utility.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Utility.Name = "tabPage_Utility";
            this.tabPage_Utility.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Utility.Size = new System.Drawing.Size(1570, 795);
            this.tabPage_Utility.TabIndex = 1;
            this.tabPage_Utility.Text = "Utility";
            this.tabPage_Utility.UseVisualStyleBackColor = true;
            // 
            // GroupBox_LogFile
            // 
            this.GroupBox_LogFile.Controls.Add(this.Button_DisableLog);
            this.GroupBox_LogFile.Controls.Add(this.Button_EnableLog);
            this.GroupBox_LogFile.Controls.Add(this.Label_LogStatus);
            this.GroupBox_LogFile.Location = new System.Drawing.Point(10, 699);
            this.GroupBox_LogFile.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_LogFile.Name = "GroupBox_LogFile";
            this.GroupBox_LogFile.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_LogFile.Size = new System.Drawing.Size(441, 62);
            this.GroupBox_LogFile.TabIndex = 13;
            this.GroupBox_LogFile.TabStop = false;
            this.GroupBox_LogFile.Text = "Log File";
            // 
            // Button_DisableLog
            // 
            this.Button_DisableLog.Location = new System.Drawing.Point(334, 26);
            this.Button_DisableLog.Margin = new System.Windows.Forms.Padding(4);
            this.Button_DisableLog.Name = "Button_DisableLog";
            this.Button_DisableLog.Size = new System.Drawing.Size(94, 29);
            this.Button_DisableLog.TabIndex = 2;
            this.Button_DisableLog.Text = "Disable";
            this.Button_DisableLog.UseVisualStyleBackColor = true;
            this.Button_DisableLog.Click += new System.EventHandler(this.Button_DisableLog_Click);
            // 
            // Button_EnableLog
            // 
            this.Button_EnableLog.Location = new System.Drawing.Point(232, 26);
            this.Button_EnableLog.Margin = new System.Windows.Forms.Padding(4);
            this.Button_EnableLog.Name = "Button_EnableLog";
            this.Button_EnableLog.Size = new System.Drawing.Size(94, 29);
            this.Button_EnableLog.TabIndex = 1;
            this.Button_EnableLog.Text = "Enable";
            this.Button_EnableLog.UseVisualStyleBackColor = true;
            this.Button_EnableLog.Click += new System.EventHandler(this.Button_EnableLog_Click);
            // 
            // Label_LogStatus
            // 
            this.Label_LogStatus.AutoSize = true;
            this.Label_LogStatus.Location = new System.Drawing.Point(8, 31);
            this.Label_LogStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_LogStatus.Name = "Label_LogStatus";
            this.Label_LogStatus.Size = new System.Drawing.Size(141, 17);
            this.Label_LogStatus.TabIndex = 0;
            this.Label_LogStatus.Text = "Log File Status: Disable!";
            // 
            // GroupBox_BleName
            // 
            this.GroupBox_BleName.Controls.Add(this.Button_Get_BLE_Display_Name);
            this.GroupBox_BleName.Controls.Add(this.Button_Set_BLE_Display_Name);
            this.GroupBox_BleName.Controls.Add(this.Button_Clear_BLE_Display_Name);
            this.GroupBox_BleName.Controls.Add(this.TextBox_BLE_Display_Name);
            this.GroupBox_BleName.Location = new System.Drawing.Point(10, 591);
            this.GroupBox_BleName.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_BleName.Name = "GroupBox_BleName";
            this.GroupBox_BleName.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_BleName.Size = new System.Drawing.Size(441, 100);
            this.GroupBox_BleName.TabIndex = 6;
            this.GroupBox_BleName.TabStop = false;
            this.GroupBox_BleName.Text = "Bluetooth LE Advertising Name";
            // 
            // Button_Get_BLE_Display_Name
            // 
            this.Button_Get_BLE_Display_Name.Location = new System.Drawing.Point(210, 61);
            this.Button_Get_BLE_Display_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Get_BLE_Display_Name.Name = "Button_Get_BLE_Display_Name";
            this.Button_Get_BLE_Display_Name.Size = new System.Drawing.Size(94, 29);
            this.Button_Get_BLE_Display_Name.TabIndex = 3;
            this.Button_Get_BLE_Display_Name.Text = "Get";
            this.Button_Get_BLE_Display_Name.UseVisualStyleBackColor = true;
            this.Button_Get_BLE_Display_Name.Click += new System.EventHandler(this.Button_Get_BLE_Display_Name_Click);
            // 
            // Button_Set_BLE_Display_Name
            // 
            this.Button_Set_BLE_Display_Name.Location = new System.Drawing.Point(109, 61);
            this.Button_Set_BLE_Display_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Set_BLE_Display_Name.Name = "Button_Set_BLE_Display_Name";
            this.Button_Set_BLE_Display_Name.Size = new System.Drawing.Size(94, 29);
            this.Button_Set_BLE_Display_Name.TabIndex = 2;
            this.Button_Set_BLE_Display_Name.Text = "Set";
            this.Button_Set_BLE_Display_Name.UseVisualStyleBackColor = true;
            this.Button_Set_BLE_Display_Name.Click += new System.EventHandler(this.Button_Set_BLE_Display_Name_Click);
            // 
            // Button_Clear_BLE_Display_Name
            // 
            this.Button_Clear_BLE_Display_Name.Location = new System.Drawing.Point(8, 61);
            this.Button_Clear_BLE_Display_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Clear_BLE_Display_Name.Name = "Button_Clear_BLE_Display_Name";
            this.Button_Clear_BLE_Display_Name.Size = new System.Drawing.Size(94, 29);
            this.Button_Clear_BLE_Display_Name.TabIndex = 1;
            this.Button_Clear_BLE_Display_Name.Text = "Default";
            this.Button_Clear_BLE_Display_Name.UseVisualStyleBackColor = true;
            this.Button_Clear_BLE_Display_Name.Click += new System.EventHandler(this.Button_Clear_BLE_Display_Name_Click);
            // 
            // TextBox_BLE_Display_Name
            // 
            this.TextBox_BLE_Display_Name.Location = new System.Drawing.Point(8, 26);
            this.TextBox_BLE_Display_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_BLE_Display_Name.Name = "TextBox_BLE_Display_Name";
            this.TextBox_BLE_Display_Name.Size = new System.Drawing.Size(295, 24);
            this.TextBox_BLE_Display_Name.TabIndex = 0;
            this.TextBox_BLE_Display_Name.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox_BLE_Display_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.TextBox_BLE_Display_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // groupBox_Device
            // 
            this.groupBox_Device.Controls.Add(this.button_SwitchDevice);
            this.groupBox_Device.Controls.Add(this.textBox_FanOffTime);
            this.groupBox_Device.Controls.Add(this.Button_GetFanDelayOffTime);
            this.groupBox_Device.Controls.Add(this.Button_SetFanDelayOffTime);
            this.groupBox_Device.Controls.Add(this.label_FanOffTimeSetting);
            this.groupBox_Device.Controls.Add(this.button_restore_fac_ref_warning);
            this.groupBox_Device.Controls.Add(this.Button_LockButton);
            this.groupBox_Device.Controls.Add(this.Label_ButtonStatus);
            this.groupBox_Device.Controls.Add(this.Button_UnlockButton);
            this.groupBox_Device.Controls.Add(this.button_DeviceRestoreFacRef);
            this.groupBox_Device.Controls.Add(this.label_RestoreFacRef);
            this.groupBox_Device.Controls.Add(this.button_DeviceUpdateRef);
            this.groupBox_Device.Controls.Add(this.label119);
            this.groupBox_Device.Controls.Add(this.button_DeviceResetSys);
            this.groupBox_Device.Controls.Add(this.label118);
            this.groupBox_Device.Location = new System.Drawing.Point(1104, 481);
            this.groupBox_Device.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Device.Name = "groupBox_Device";
            this.groupBox_Device.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Device.Size = new System.Drawing.Size(435, 312);
            this.groupBox_Device.TabIndex = 12;
            this.groupBox_Device.TabStop = false;
            this.groupBox_Device.Text = "Device";
            this.groupBox_Device.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.groupBox_Device_MouseDoubleClick);
            // 
            // button_SwitchDevice
            // 
            this.button_SwitchDevice.Location = new System.Drawing.Point(232, 274);
            this.button_SwitchDevice.Margin = new System.Windows.Forms.Padding(4);
            this.button_SwitchDevice.Name = "button_SwitchDevice";
            this.button_SwitchDevice.Size = new System.Drawing.Size(194, 31);
            this.button_SwitchDevice.TabIndex = 26;
            this.button_SwitchDevice.Text = "Switch Device";
            this.button_SwitchDevice.UseVisualStyleBackColor = true;
            this.button_SwitchDevice.Click += new System.EventHandler(this.button_SwitchDevice_Click);
            // 
            // textBox_FanOffTime
            // 
            this.textBox_FanOffTime.Location = new System.Drawing.Point(112, 174);
            this.textBox_FanOffTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_FanOffTime.Name = "textBox_FanOffTime";
            this.textBox_FanOffTime.Size = new System.Drawing.Size(112, 24);
            this.textBox_FanOffTime.TabIndex = 19;
            this.textBox_FanOffTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_FanOffTime.Visible = false;
            this.textBox_FanOffTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tt_FanOffTime_MouseClick);
            this.textBox_FanOffTime.Leave += new System.EventHandler(this.tt_FanOffTime_Leave);
            // 
            // Button_GetFanDelayOffTime
            // 
            this.Button_GetFanDelayOffTime.Location = new System.Drawing.Point(232, 174);
            this.Button_GetFanDelayOffTime.Margin = new System.Windows.Forms.Padding(4);
            this.Button_GetFanDelayOffTime.Name = "Button_GetFanDelayOffTime";
            this.Button_GetFanDelayOffTime.Size = new System.Drawing.Size(94, 29);
            this.Button_GetFanDelayOffTime.TabIndex = 0;
            this.Button_GetFanDelayOffTime.Text = "Get";
            this.Button_GetFanDelayOffTime.Visible = false;
            this.Button_GetFanDelayOffTime.Click += new System.EventHandler(this.Button_GetFanDelayOffTime_Click);
            // 
            // Button_SetFanDelayOffTime
            // 
            this.Button_SetFanDelayOffTime.Location = new System.Drawing.Point(334, 174);
            this.Button_SetFanDelayOffTime.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SetFanDelayOffTime.Name = "Button_SetFanDelayOffTime";
            this.Button_SetFanDelayOffTime.Size = new System.Drawing.Size(91, 29);
            this.Button_SetFanDelayOffTime.TabIndex = 1;
            this.Button_SetFanDelayOffTime.Text = "Set";
            this.Button_SetFanDelayOffTime.Visible = false;
            this.Button_SetFanDelayOffTime.Click += new System.EventHandler(this.Button_SetFanDelayOffTime_Click);
            // 
            // label_FanOffTimeSetting
            // 
            this.label_FanOffTimeSetting.AutoSize = true;
            this.label_FanOffTimeSetting.Location = new System.Drawing.Point(8, 178);
            this.label_FanOffTimeSetting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FanOffTimeSetting.Name = "label_FanOffTimeSetting";
            this.label_FanOffTimeSetting.Size = new System.Drawing.Size(83, 17);
            this.label_FanOffTimeSetting.TabIndex = 18;
            this.label_FanOffTimeSetting.Text = "Fan Off Time:";
            this.label_FanOffTimeSetting.Visible = false;
            // 
            // button_restore_fac_ref_warning
            // 
            this.button_restore_fac_ref_warning.FlatAppearance.BorderSize = 0;
            this.button_restore_fac_ref_warning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_restore_fac_ref_warning.Image = global::ISC_Win_WinForm_GUI.Properties.Resources.warning;
            this.button_restore_fac_ref_warning.Location = new System.Drawing.Point(200, 98);
            this.button_restore_fac_ref_warning.Margin = new System.Windows.Forms.Padding(4);
            this.button_restore_fac_ref_warning.Name = "button_restore_fac_ref_warning";
            this.button_restore_fac_ref_warning.Size = new System.Drawing.Size(26, 29);
            this.button_restore_fac_ref_warning.TabIndex = 17;
            this.button_restore_fac_ref_warning.TabStop = false;
            this.button_restore_fac_ref_warning.UseVisualStyleBackColor = true;
            this.button_restore_fac_ref_warning.Click += new System.EventHandler(this.button_restore_fac_ref_warning_Click);
            // 
            // Button_LockButton
            // 
            this.Button_LockButton.Location = new System.Drawing.Point(232, 136);
            this.Button_LockButton.Margin = new System.Windows.Forms.Padding(4);
            this.Button_LockButton.Name = "Button_LockButton";
            this.Button_LockButton.Size = new System.Drawing.Size(94, 29);
            this.Button_LockButton.TabIndex = 4;
            this.Button_LockButton.Text = "Lock";
            this.Button_LockButton.UseVisualStyleBackColor = true;
            this.Button_LockButton.Click += new System.EventHandler(this.Button_LockButton_Click);
            // 
            // Label_ButtonStatus
            // 
            this.Label_ButtonStatus.AutoSize = true;
            this.Label_ButtonStatus.Location = new System.Drawing.Point(8, 141);
            this.Label_ButtonStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ButtonStatus.Name = "Label_ButtonStatus";
            this.Label_ButtonStatus.Size = new System.Drawing.Size(91, 17);
            this.Label_ButtonStatus.TabIndex = 12;
            this.Label_ButtonStatus.Text = "Button Status: ";
            // 
            // Button_UnlockButton
            // 
            this.Button_UnlockButton.Location = new System.Drawing.Point(334, 136);
            this.Button_UnlockButton.Margin = new System.Windows.Forms.Padding(4);
            this.Button_UnlockButton.Name = "Button_UnlockButton";
            this.Button_UnlockButton.Size = new System.Drawing.Size(94, 29);
            this.Button_UnlockButton.TabIndex = 5;
            this.Button_UnlockButton.Text = "Unlock";
            this.Button_UnlockButton.UseVisualStyleBackColor = true;
            this.Button_UnlockButton.Click += new System.EventHandler(this.Button_UnlockButton_Click);
            // 
            // button_DeviceRestoreFacRef
            // 
            this.button_DeviceRestoreFacRef.Location = new System.Drawing.Point(334, 98);
            this.button_DeviceRestoreFacRef.Margin = new System.Windows.Forms.Padding(4);
            this.button_DeviceRestoreFacRef.Name = "button_DeviceRestoreFacRef";
            this.button_DeviceRestoreFacRef.Size = new System.Drawing.Size(94, 29);
            this.button_DeviceRestoreFacRef.TabIndex = 3;
            this.button_DeviceRestoreFacRef.Text = "Restore";
            this.button_DeviceRestoreFacRef.UseVisualStyleBackColor = true;
            this.button_DeviceRestoreFacRef.Click += new System.EventHandler(this.button_DeviceRestoreFacRef_Click);
            // 
            // label_RestoreFacRef
            // 
            this.label_RestoreFacRef.AutoSize = true;
            this.label_RestoreFacRef.Location = new System.Drawing.Point(8, 102);
            this.label_RestoreFacRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RestoreFacRef.Name = "label_RestoreFacRef";
            this.label_RestoreFacRef.Size = new System.Drawing.Size(158, 17);
            this.label_RestoreFacRef.TabIndex = 6;
            this.label_RestoreFacRef.Text = "Restore Factory Reference";
            // 
            // button_DeviceUpdateRef
            // 
            this.button_DeviceUpdateRef.Location = new System.Drawing.Point(334, 61);
            this.button_DeviceUpdateRef.Margin = new System.Windows.Forms.Padding(4);
            this.button_DeviceUpdateRef.Name = "button_DeviceUpdateRef";
            this.button_DeviceUpdateRef.Size = new System.Drawing.Size(94, 29);
            this.button_DeviceUpdateRef.TabIndex = 2;
            this.button_DeviceUpdateRef.Text = "Update";
            this.button_DeviceUpdateRef.UseVisualStyleBackColor = true;
            this.button_DeviceUpdateRef.Click += new System.EventHandler(this.button_DeviceUpdateRef_Click);
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(8, 66);
            this.label119.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(142, 17);
            this.label119.TabIndex = 2;
            this.label119.Text = "Update Reference Data";
            // 
            // button_DeviceResetSys
            // 
            this.button_DeviceResetSys.Location = new System.Drawing.Point(334, 26);
            this.button_DeviceResetSys.Margin = new System.Windows.Forms.Padding(4);
            this.button_DeviceResetSys.Name = "button_DeviceResetSys";
            this.button_DeviceResetSys.Size = new System.Drawing.Size(94, 29);
            this.button_DeviceResetSys.TabIndex = 1;
            this.button_DeviceResetSys.Text = "Reset";
            this.button_DeviceResetSys.UseVisualStyleBackColor = true;
            this.button_DeviceResetSys.Click += new System.EventHandler(this.button_DeviceResetSys_Click);
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(8, 31);
            this.label118.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(83, 17);
            this.label118.TabIndex = 0;
            this.label118.Text = "Reset System";
            // 
            // groupBox_ActivationKey
            // 
            this.groupBox_ActivationKey.Controls.Add(this.label_ActivateStatus);
            this.groupBox_ActivationKey.Controls.Add(this.Status);
            this.groupBox_ActivationKey.Controls.Add(this.button_KeySet);
            this.groupBox_ActivationKey.Controls.Add(this.TextBox_Key);
            this.groupBox_ActivationKey.Controls.Add(this.label117);
            this.groupBox_ActivationKey.Location = new System.Drawing.Point(1104, 370);
            this.groupBox_ActivationKey.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_ActivationKey.Name = "groupBox_ActivationKey";
            this.groupBox_ActivationKey.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_ActivationKey.Size = new System.Drawing.Size(435, 104);
            this.groupBox_ActivationKey.TabIndex = 11;
            this.groupBox_ActivationKey.TabStop = false;
            this.groupBox_ActivationKey.Text = "Activation Key";
            // 
            // label_ActivateStatus
            // 
            this.label_ActivateStatus.AutoSize = true;
            this.label_ActivateStatus.Location = new System.Drawing.Point(88, 69);
            this.label_ActivateStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ActivateStatus.Name = "label_ActivateStatus";
            this.label_ActivateStatus.Size = new System.Drawing.Size(90, 17);
            this.label_ActivateStatus.TabIndex = 4;
            this.label_ActivateStatus.Text = "Not activated!";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(28, 69);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(50, 17);
            this.Status.TabIndex = 3;
            this.Status.Text = "Status :";
            // 
            // button_KeySet
            // 
            this.button_KeySet.Location = new System.Drawing.Point(334, 25);
            this.button_KeySet.Margin = new System.Windows.Forms.Padding(4);
            this.button_KeySet.Name = "button_KeySet";
            this.button_KeySet.Size = new System.Drawing.Size(94, 29);
            this.button_KeySet.TabIndex = 2;
            this.button_KeySet.Text = "Set Key";
            this.button_KeySet.UseVisualStyleBackColor = true;
            this.button_KeySet.Click += new System.EventHandler(this.button_KeySet_Click);
            // 
            // TextBox_Key
            // 
            this.TextBox_Key.Location = new System.Drawing.Point(91, 25);
            this.TextBox_Key.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Key.Name = "TextBox_Key";
            this.TextBox_Key.Size = new System.Drawing.Size(215, 24);
            this.TextBox_Key.TabIndex = 1;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(8, 29);
            this.label117.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(68, 17);
            this.label117.TabIndex = 0;
            this.label117.Text = "Input Key :";
            // 
            // groupBox_DevInfo
            // 
            this.groupBox_DevInfo.Controls.Add(this.Label_BleNameValue);
            this.groupBox_DevInfo.Controls.Add(this.Label_Blename);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoLampUsageValue);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoLampUsage);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoUUID);
            this.groupBox_DevInfo.Controls.Add(this.label114);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoManfacSerNum);
            this.groupBox_DevInfo.Controls.Add(this.label_MFC_Seri_Num);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoDevSerNum);
            this.groupBox_DevInfo.Controls.Add(this.label104);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoModelName);
            this.groupBox_DevInfo.Controls.Add(this.label106);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoDetectorBoardVer);
            this.groupBox_DevInfo.Controls.Add(this.label108);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoMainBoardVer);
            this.groupBox_DevInfo.Controls.Add(this.label110);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoDLPCVer);
            this.groupBox_DevInfo.Controls.Add(this.label102);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoTivaSWVer);
            this.groupBox_DevInfo.Controls.Add(this.label98);
            this.groupBox_DevInfo.Controls.Add(this.label_DevInfoGUIVer);
            this.groupBox_DevInfo.Controls.Add(this.label95);
            this.groupBox_DevInfo.Location = new System.Drawing.Point(1104, 8);
            this.groupBox_DevInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_DevInfo.Name = "groupBox_DevInfo";
            this.groupBox_DevInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_DevInfo.Size = new System.Drawing.Size(435, 355);
            this.groupBox_DevInfo.TabIndex = 10;
            this.groupBox_DevInfo.TabStop = false;
            this.groupBox_DevInfo.Text = "Device Information";
            // 
            // Label_Blename
            // 
            this.Label_Blename.AutoSize = true;
            this.Label_Blename.Enabled = false;
            this.Label_Blename.Location = new System.Drawing.Point(8, 311);
            this.Label_Blename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Blename.Name = "Label_Blename";
            this.Label_Blename.Size = new System.Drawing.Size(132, 17);
            this.Label_Blename.TabIndex = 22;
            this.Label_Blename.Text = "BLE Advertising Name";
            // 
            // label_DevInfoLampUsage
            // 
            this.label_DevInfoLampUsage.AutoSize = true;
            this.label_DevInfoLampUsage.Location = new System.Drawing.Point(8, 282);
            this.label_DevInfoLampUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DevInfoLampUsage.Name = "label_DevInfoLampUsage";
            this.label_DevInfoLampUsage.Size = new System.Drawing.Size(77, 17);
            this.label_DevInfoLampUsage.TabIndex = 20;
            this.label_DevInfoLampUsage.Text = "Lamp Usage";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(8, 254);
            this.label114.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(80, 17);
            this.label114.TabIndex = 18;
            this.label114.Text = "Device UUID";
            // 
            // label_MFC_Seri_Num
            // 
            this.label_MFC_Seri_Num.AutoSize = true;
            this.label_MFC_Seri_Num.Location = new System.Drawing.Point(8, 225);
            this.label_MFC_Seri_Num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MFC_Seri_Num.Name = "label_MFC_Seri_Num";
            this.label_MFC_Seri_Num.Size = new System.Drawing.Size(175, 17);
            this.label_MFC_Seri_Num.TabIndex = 16;
            this.label_MFC_Seri_Num.Text = "Manufacturing Serial Number";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(8, 196);
            this.label104.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(129, 17);
            this.label104.TabIndex = 14;
            this.label104.Text = "Device Serial Number";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(8, 166);
            this.label106.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(81, 17);
            this.label106.TabIndex = 12;
            this.label106.Text = "Model Name";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(8, 138);
            this.label108.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(140, 17);
            this.label108.TabIndex = 10;
            this.label108.Text = "Detector Board Version";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(8, 110);
            this.label110.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(118, 17);
            this.label110.TabIndex = 8;
            this.label110.Text = "Main Board Version";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(8, 81);
            this.label102.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(112, 17);
            this.label102.TabIndex = 4;
            this.label102.Text = "DLPC Flash Version";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(8, 52);
            this.label98.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(96, 17);
            this.label98.TabIndex = 2;
            this.label98.Text = "Tiva SW Version";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(8, 24);
            this.label95.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(74, 17);
            this.label95.TabIndex = 0;
            this.label95.Text = "GUI Version";
            // 
            // GroupBox_CalibCoeffs
            // 
            this.GroupBox_CalibCoeffs.Controls.Add(this.Button_Cal_WriteCoeffs);
            this.GroupBox_CalibCoeffs.Controls.Add(this.Button_Cal_ReadCoeffs);
            this.GroupBox_CalibCoeffs.Controls.Add(this.Button_Cal_RestoreDefaultCoeffs);
            this.GroupBox_CalibCoeffs.Controls.Add(this.Button_Cal_WriteGenCoeffs);
            this.GroupBox_CalibCoeffs.Controls.Add(this.CheckBox_Cal_WriteEnable);
            this.GroupBox_CalibCoeffs.Controls.Add(this.TextBox_ShiftVectCoeff2);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label28);
            this.GroupBox_CalibCoeffs.Controls.Add(this.TextBox_ShiftVectCoeff1);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label31);
            this.GroupBox_CalibCoeffs.Controls.Add(this.TextBox_ShiftVectCoeff0);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label22);
            this.GroupBox_CalibCoeffs.Controls.Add(this.TextBox_P2WCoeff2);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label25);
            this.GroupBox_CalibCoeffs.Controls.Add(this.Label_ScanCfgVer);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label27);
            this.GroupBox_CalibCoeffs.Controls.Add(this.TextBox_P2WCoeff1);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label19);
            this.GroupBox_CalibCoeffs.Controls.Add(this.Label_RefCalVer);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label21);
            this.GroupBox_CalibCoeffs.Controls.Add(this.TextBox_P2WCoeff0);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label23);
            this.GroupBox_CalibCoeffs.Controls.Add(this.Label_CalCoeffVer);
            this.GroupBox_CalibCoeffs.Controls.Add(this.label29);
            this.GroupBox_CalibCoeffs.Location = new System.Drawing.Point(458, 228);
            this.GroupBox_CalibCoeffs.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_CalibCoeffs.Name = "GroupBox_CalibCoeffs";
            this.GroupBox_CalibCoeffs.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_CalibCoeffs.Size = new System.Drawing.Size(639, 356);
            this.GroupBox_CalibCoeffs.TabIndex = 9;
            this.GroupBox_CalibCoeffs.TabStop = false;
            this.GroupBox_CalibCoeffs.Text = "Calibration Coefficients";
            // 
            // Button_Cal_WriteCoeffs
            // 
            this.Button_Cal_WriteCoeffs.Enabled = false;
            this.Button_Cal_WriteCoeffs.Location = new System.Drawing.Point(482, 316);
            this.Button_Cal_WriteCoeffs.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Cal_WriteCoeffs.Name = "Button_Cal_WriteCoeffs";
            this.Button_Cal_WriteCoeffs.Size = new System.Drawing.Size(144, 29);
            this.Button_Cal_WriteCoeffs.TabIndex = 10;
            this.Button_Cal_WriteCoeffs.Text = "Write Coeffs";
            this.Button_Cal_WriteCoeffs.UseVisualStyleBackColor = true;
            this.Button_Cal_WriteCoeffs.Click += new System.EventHandler(this.Button_Cal_WriteCoeffs_Click);
            // 
            // Button_Cal_ReadCoeffs
            // 
            this.Button_Cal_ReadCoeffs.Location = new System.Drawing.Point(331, 316);
            this.Button_Cal_ReadCoeffs.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Cal_ReadCoeffs.Name = "Button_Cal_ReadCoeffs";
            this.Button_Cal_ReadCoeffs.Size = new System.Drawing.Size(144, 29);
            this.Button_Cal_ReadCoeffs.TabIndex = 9;
            this.Button_Cal_ReadCoeffs.Text = "Read Coeffs";
            this.Button_Cal_ReadCoeffs.UseVisualStyleBackColor = true;
            this.Button_Cal_ReadCoeffs.Click += new System.EventHandler(this.Button_Cal_ReadCoeffs_Click);
            // 
            // Button_Cal_RestoreDefaultCoeffs
            // 
            this.Button_Cal_RestoreDefaultCoeffs.Enabled = false;
            this.Button_Cal_RestoreDefaultCoeffs.Location = new System.Drawing.Point(8, 316);
            this.Button_Cal_RestoreDefaultCoeffs.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Cal_RestoreDefaultCoeffs.Name = "Button_Cal_RestoreDefaultCoeffs";
            this.Button_Cal_RestoreDefaultCoeffs.Size = new System.Drawing.Size(239, 29);
            this.Button_Cal_RestoreDefaultCoeffs.TabIndex = 8;
            this.Button_Cal_RestoreDefaultCoeffs.Text = "Restore Factory Calibration Data";
            this.Button_Cal_RestoreDefaultCoeffs.UseVisualStyleBackColor = true;
            this.Button_Cal_RestoreDefaultCoeffs.Click += new System.EventHandler(this.Button_Cal_RestoreDefaultCoeffs_Click);
            // 
            // Button_Cal_WriteGenCoeffs
            // 
            this.Button_Cal_WriteGenCoeffs.Enabled = false;
            this.Button_Cal_WriteGenCoeffs.Location = new System.Drawing.Point(8, 272);
            this.Button_Cal_WriteGenCoeffs.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Cal_WriteGenCoeffs.Name = "Button_Cal_WriteGenCoeffs";
            this.Button_Cal_WriteGenCoeffs.Size = new System.Drawing.Size(150, 29);
            this.Button_Cal_WriteGenCoeffs.TabIndex = 7;
            this.Button_Cal_WriteGenCoeffs.Text = "Write Generic Data";
            this.Button_Cal_WriteGenCoeffs.UseVisualStyleBackColor = true;
            this.Button_Cal_WriteGenCoeffs.Visible = false;
            this.Button_Cal_WriteGenCoeffs.Click += new System.EventHandler(this.Button_Cal_WriteGenCoeffs_Click);
            // 
            // CheckBox_Cal_WriteEnable
            // 
            this.CheckBox_Cal_WriteEnable.AutoSize = true;
            this.CheckBox_Cal_WriteEnable.Location = new System.Drawing.Point(11, 176);
            this.CheckBox_Cal_WriteEnable.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_Cal_WriteEnable.Name = "CheckBox_Cal_WriteEnable";
            this.CheckBox_Cal_WriteEnable.Size = new System.Drawing.Size(103, 21);
            this.CheckBox_Cal_WriteEnable.TabIndex = 6;
            this.CheckBox_Cal_WriteEnable.Text = "Write Enable";
            this.CheckBox_Cal_WriteEnable.UseVisualStyleBackColor = true;
            this.CheckBox_Cal_WriteEnable.CheckedChanged += new System.EventHandler(this.CheckBox_Cal_WriteEnable_CheckedChanged);
            // 
            // TextBox_ShiftVectCoeff2
            // 
            this.TextBox_ShiftVectCoeff2.Location = new System.Drawing.Point(331, 271);
            this.TextBox_ShiftVectCoeff2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ShiftVectCoeff2.Name = "TextBox_ShiftVectCoeff2";
            this.TextBox_ShiftVectCoeff2.Size = new System.Drawing.Size(158, 24);
            this.TextBox_ShiftVectCoeff2.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(170, 278);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(103, 17);
            this.label28.TabIndex = 22;
            this.label28.Text = "Shift Vect Coeff 2";
            // 
            // TextBox_ShiftVectCoeff1
            // 
            this.TextBox_ShiftVectCoeff1.Location = new System.Drawing.Point(331, 221);
            this.TextBox_ShiftVectCoeff1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ShiftVectCoeff1.Name = "TextBox_ShiftVectCoeff1";
            this.TextBox_ShiftVectCoeff1.Size = new System.Drawing.Size(158, 24);
            this.TextBox_ShiftVectCoeff1.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(170, 228);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 17);
            this.label31.TabIndex = 18;
            this.label31.Text = "Shift Vect Coeff 1";
            // 
            // TextBox_ShiftVectCoeff0
            // 
            this.TextBox_ShiftVectCoeff0.Location = new System.Drawing.Point(331, 171);
            this.TextBox_ShiftVectCoeff0.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ShiftVectCoeff0.Name = "TextBox_ShiftVectCoeff0";
            this.TextBox_ShiftVectCoeff0.Size = new System.Drawing.Size(158, 24);
            this.TextBox_ShiftVectCoeff0.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(170, 178);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 17);
            this.label22.TabIndex = 14;
            this.label22.Text = "Shift Vect Coeff 0";
            // 
            // TextBox_P2WCoeff2
            // 
            this.TextBox_P2WCoeff2.Location = new System.Drawing.Point(331, 121);
            this.TextBox_P2WCoeff2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_P2WCoeff2.Name = "TextBox_P2WCoeff2";
            this.TextBox_P2WCoeff2.Size = new System.Drawing.Size(158, 24);
            this.TextBox_P2WCoeff2.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(170, 128);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 17);
            this.label25.TabIndex = 10;
            this.label25.Text = "Pix-Wave Coeff 2";
            // 
            // Label_ScanCfgVer
            // 
            this.Label_ScanCfgVer.AutoSize = true;
            this.Label_ScanCfgVer.Location = new System.Drawing.Point(130, 128);
            this.Label_ScanCfgVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ScanCfgVer.Name = "Label_ScanCfgVer";
            this.Label_ScanCfgVer.Size = new System.Drawing.Size(15, 17);
            this.Label_ScanCfgVer.TabIndex = 9;
            this.Label_ScanCfgVer.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 128);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 17);
            this.label27.TabIndex = 8;
            this.label27.Text = "Scan Cfg Ver :";
            // 
            // TextBox_P2WCoeff1
            // 
            this.TextBox_P2WCoeff1.Location = new System.Drawing.Point(331, 71);
            this.TextBox_P2WCoeff1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_P2WCoeff1.Name = "TextBox_P2WCoeff1";
            this.TextBox_P2WCoeff1.Size = new System.Drawing.Size(158, 24);
            this.TextBox_P2WCoeff1.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(170, 78);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 17);
            this.label19.TabIndex = 6;
            this.label19.Text = "Pix-Wave Coeff 1";
            // 
            // Label_RefCalVer
            // 
            this.Label_RefCalVer.AutoSize = true;
            this.Label_RefCalVer.Location = new System.Drawing.Point(130, 78);
            this.Label_RefCalVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_RefCalVer.Name = "Label_RefCalVer";
            this.Label_RefCalVer.Size = new System.Drawing.Size(15, 17);
            this.Label_RefCalVer.TabIndex = 5;
            this.Label_RefCalVer.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 78);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 17);
            this.label21.TabIndex = 4;
            this.label21.Text = "Ref Cal Ver :";
            // 
            // TextBox_P2WCoeff0
            // 
            this.TextBox_P2WCoeff0.Location = new System.Drawing.Point(331, 21);
            this.TextBox_P2WCoeff0.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_P2WCoeff0.Name = "TextBox_P2WCoeff0";
            this.TextBox_P2WCoeff0.Size = new System.Drawing.Size(158, 24);
            this.TextBox_P2WCoeff0.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(170, 28);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 17);
            this.label23.TabIndex = 2;
            this.label23.Text = "Pix-Wave Coeff 0";
            // 
            // Label_CalCoeffVer
            // 
            this.Label_CalCoeffVer.AutoSize = true;
            this.Label_CalCoeffVer.Location = new System.Drawing.Point(130, 28);
            this.Label_CalCoeffVer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_CalCoeffVer.Name = "Label_CalCoeffVer";
            this.Label_CalCoeffVer.Size = new System.Drawing.Size(15, 17);
            this.Label_CalCoeffVer.TabIndex = 1;
            this.Label_CalCoeffVer.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 28);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 17);
            this.label29.TabIndex = 0;
            this.label29.Text = "Cal Coeff Ver :";
            // 
            // GroupBox_Sensors
            // 
            this.GroupBox_Sensors.Controls.Add(this.Button_SensorRead);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorLampCM2Value);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorLampCM1Value);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorLampVM2Value);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorLampVM1Value);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorTivaTemp);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorSysTemp);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorHumidity);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorBattCapacity);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorBattStatus);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorLampCM2);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorLampCM1);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorLampVM2);
            this.GroupBox_Sensors.Controls.Add(this.Label_SensorLampVM1);
            this.GroupBox_Sensors.Controls.Add(this.label8);
            this.GroupBox_Sensors.Controls.Add(this.label5);
            this.GroupBox_Sensors.Controls.Add(this.label_sys_humidity);
            this.GroupBox_Sensors.Controls.Add(this.lb_BattCapTitle);
            this.GroupBox_Sensors.Controls.Add(this.lb_BattChargerStatusTitle);
            this.GroupBox_Sensors.Location = new System.Drawing.Point(10, 228);
            this.GroupBox_Sensors.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_Sensors.Name = "GroupBox_Sensors";
            this.GroupBox_Sensors.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_Sensors.Size = new System.Drawing.Size(440, 356);
            this.GroupBox_Sensors.TabIndex = 5;
            this.GroupBox_Sensors.TabStop = false;
            this.GroupBox_Sensors.Text = "Sensors";
            // 
            // Button_SensorRead
            // 
            this.Button_SensorRead.Location = new System.Drawing.Point(339, 316);
            this.Button_SensorRead.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SensorRead.Name = "Button_SensorRead";
            this.Button_SensorRead.Size = new System.Drawing.Size(94, 29);
            this.Button_SensorRead.TabIndex = 0;
            this.Button_SensorRead.Text = "Read";
            this.Button_SensorRead.UseVisualStyleBackColor = true;
            this.Button_SensorRead.Click += new System.EventHandler(this.Button_SensorRead_Click);
            // 
            // Label_SensorLampCM2
            // 
            this.Label_SensorLampCM2.AutoSize = true;
            this.Label_SensorLampCM2.Location = new System.Drawing.Point(8, 272);
            this.Label_SensorLampCM2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorLampCM2.Name = "Label_SensorLampCM2";
            this.Label_SensorLampCM2.Size = new System.Drawing.Size(68, 17);
            this.Label_SensorLampCM2.TabIndex = 16;
            this.Label_SensorLampCM2.Text = "Lamp CM2";
            // 
            // Label_SensorLampCM1
            // 
            this.Label_SensorLampCM1.AutoSize = true;
            this.Label_SensorLampCM1.Location = new System.Drawing.Point(8, 210);
            this.Label_SensorLampCM1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorLampCM1.Name = "Label_SensorLampCM1";
            this.Label_SensorLampCM1.Size = new System.Drawing.Size(68, 17);
            this.Label_SensorLampCM1.TabIndex = 15;
            this.Label_SensorLampCM1.Text = "Lamp CM1";
            // 
            // Label_SensorLampVM2
            // 
            this.Label_SensorLampVM2.AutoSize = true;
            this.Label_SensorLampVM2.Location = new System.Drawing.Point(8, 241);
            this.Label_SensorLampVM2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorLampVM2.Name = "Label_SensorLampVM2";
            this.Label_SensorLampVM2.Size = new System.Drawing.Size(69, 17);
            this.Label_SensorLampVM2.TabIndex = 14;
            this.Label_SensorLampVM2.Text = "Lamp VM2";
            // 
            // Label_SensorLampVM1
            // 
            this.Label_SensorLampVM1.AutoSize = true;
            this.Label_SensorLampVM1.Location = new System.Drawing.Point(8, 179);
            this.Label_SensorLampVM1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SensorLampVM1.Name = "Label_SensorLampVM1";
            this.Label_SensorLampVM1.Size = new System.Drawing.Size(69, 17);
            this.Label_SensorLampVM1.TabIndex = 5;
            this.Label_SensorLampVM1.Text = "Lamp VM1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tiva Temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "System Temp";
            // 
            // label_sys_humidity
            // 
            this.label_sys_humidity.AutoSize = true;
            this.label_sys_humidity.Location = new System.Drawing.Point(8, 85);
            this.label_sys_humidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sys_humidity.Name = "label_sys_humidity";
            this.label_sys_humidity.Size = new System.Drawing.Size(102, 17);
            this.label_sys_humidity.TabIndex = 2;
            this.label_sys_humidity.Text = "System Humidity";
            // 
            // lb_BattCapTitle
            // 
            this.lb_BattCapTitle.AutoSize = true;
            this.lb_BattCapTitle.Location = new System.Drawing.Point(8, 54);
            this.lb_BattCapTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BattCapTitle.Name = "lb_BattCapTitle";
            this.lb_BattCapTitle.Size = new System.Drawing.Size(101, 17);
            this.lb_BattCapTitle.TabIndex = 1;
            this.lb_BattCapTitle.Text = "Battery Capacity";
            // 
            // lb_BattChargerStatusTitle
            // 
            this.lb_BattChargerStatusTitle.AutoSize = true;
            this.lb_BattChargerStatusTitle.Location = new System.Drawing.Point(8, 22);
            this.lb_BattChargerStatusTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_BattChargerStatusTitle.Name = "lb_BattChargerStatusTitle";
            this.lb_BattChargerStatusTitle.Size = new System.Drawing.Size(136, 17);
            this.lb_BattChargerStatusTitle.TabIndex = 0;
            this.lb_BattChargerStatusTitle.Text = "Battery Charger Status";
            // 
            // GroupBox_DateTime
            // 
            this.GroupBox_DateTime.Controls.Add(this.Button_DateTimeGet);
            this.GroupBox_DateTime.Controls.Add(this.Button_DateTimeSync);
            this.GroupBox_DateTime.Controls.Add(this.TextBox_DateTime);
            this.GroupBox_DateTime.Location = new System.Drawing.Point(10, 118);
            this.GroupBox_DateTime.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_DateTime.Name = "GroupBox_DateTime";
            this.GroupBox_DateTime.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_DateTime.Size = new System.Drawing.Size(216, 102);
            this.GroupBox_DateTime.TabIndex = 9;
            this.GroupBox_DateTime.TabStop = false;
            this.GroupBox_DateTime.Text = "Date and Time";
            // 
            // Button_DateTimeGet
            // 
            this.Button_DateTimeGet.Location = new System.Drawing.Point(110, 64);
            this.Button_DateTimeGet.Margin = new System.Windows.Forms.Padding(4);
            this.Button_DateTimeGet.Name = "Button_DateTimeGet";
            this.Button_DateTimeGet.Size = new System.Drawing.Size(94, 29);
            this.Button_DateTimeGet.TabIndex = 2;
            this.Button_DateTimeGet.Text = "Get";
            this.Button_DateTimeGet.UseVisualStyleBackColor = true;
            this.Button_DateTimeGet.Click += new System.EventHandler(this.Button_DateTimeGet_Click);
            // 
            // Button_DateTimeSync
            // 
            this.Button_DateTimeSync.Location = new System.Drawing.Point(9, 64);
            this.Button_DateTimeSync.Margin = new System.Windows.Forms.Padding(4);
            this.Button_DateTimeSync.Name = "Button_DateTimeSync";
            this.Button_DateTimeSync.Size = new System.Drawing.Size(94, 29);
            this.Button_DateTimeSync.TabIndex = 1;
            this.Button_DateTimeSync.Text = "Sync";
            this.Button_DateTimeSync.UseVisualStyleBackColor = true;
            this.Button_DateTimeSync.Click += new System.EventHandler(this.Button_DateTimeSync_Click);
            // 
            // TextBox_DateTime
            // 
            this.TextBox_DateTime.Location = new System.Drawing.Point(9, 28);
            this.TextBox_DateTime.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_DateTime.Name = "TextBox_DateTime";
            this.TextBox_DateTime.Size = new System.Drawing.Size(194, 24);
            this.TextBox_DateTime.TabIndex = 0;
            // 
            // GroupBox_LampUsage
            // 
            this.GroupBox_LampUsage.Controls.Add(this.label4);
            this.GroupBox_LampUsage.Controls.Add(this.Button_LampUsageGet);
            this.GroupBox_LampUsage.Controls.Add(this.Button_LampUsageSet);
            this.GroupBox_LampUsage.Controls.Add(this.TextBox_LampUsage);
            this.GroupBox_LampUsage.Location = new System.Drawing.Point(234, 118);
            this.GroupBox_LampUsage.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_LampUsage.Name = "GroupBox_LampUsage";
            this.GroupBox_LampUsage.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_LampUsage.Size = new System.Drawing.Size(216, 102);
            this.GroupBox_LampUsage.TabIndex = 4;
            this.GroupBox_LampUsage.TabStop = false;
            this.GroupBox_LampUsage.Text = "Lamp Usage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "(hours)";
            // 
            // Button_LampUsageGet
            // 
            this.Button_LampUsageGet.Location = new System.Drawing.Point(110, 64);
            this.Button_LampUsageGet.Margin = new System.Windows.Forms.Padding(4);
            this.Button_LampUsageGet.Name = "Button_LampUsageGet";
            this.Button_LampUsageGet.Size = new System.Drawing.Size(94, 29);
            this.Button_LampUsageGet.TabIndex = 2;
            this.Button_LampUsageGet.Text = "Get";
            this.Button_LampUsageGet.UseVisualStyleBackColor = true;
            this.Button_LampUsageGet.Click += new System.EventHandler(this.Button_LampUsageGet_Click);
            // 
            // Button_LampUsageSet
            // 
            this.Button_LampUsageSet.Location = new System.Drawing.Point(9, 64);
            this.Button_LampUsageSet.Margin = new System.Windows.Forms.Padding(4);
            this.Button_LampUsageSet.Name = "Button_LampUsageSet";
            this.Button_LampUsageSet.Size = new System.Drawing.Size(94, 29);
            this.Button_LampUsageSet.TabIndex = 1;
            this.Button_LampUsageSet.Text = "Set";
            this.Button_LampUsageSet.UseVisualStyleBackColor = true;
            this.Button_LampUsageSet.Click += new System.EventHandler(this.Button_LampUsageSet_Click);
            // 
            // TextBox_LampUsage
            // 
            this.TextBox_LampUsage.Location = new System.Drawing.Point(9, 28);
            this.TextBox_LampUsage.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_LampUsage.Name = "TextBox_LampUsage";
            this.TextBox_LampUsage.Size = new System.Drawing.Size(129, 24);
            this.TextBox_LampUsage.TabIndex = 0;
            // 
            // GroupBox_DLPC150FWUpdate
            // 
            this.GroupBox_DLPC150FWUpdate.Controls.Add(this.Button_DLPC150FWUpdate);
            this.GroupBox_DLPC150FWUpdate.Controls.Add(this.ProgressBar_DLPC150FWUpdateStatus);
            this.GroupBox_DLPC150FWUpdate.Controls.Add(this.Button_DLPC150FWBrowse);
            this.GroupBox_DLPC150FWUpdate.Controls.Add(this.TextBox_DLPC150FWPath);
            this.GroupBox_DLPC150FWUpdate.Controls.Add(this.label9);
            this.GroupBox_DLPC150FWUpdate.Location = new System.Drawing.Point(458, 118);
            this.GroupBox_DLPC150FWUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_DLPC150FWUpdate.Name = "GroupBox_DLPC150FWUpdate";
            this.GroupBox_DLPC150FWUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_DLPC150FWUpdate.Size = new System.Drawing.Size(639, 102);
            this.GroupBox_DLPC150FWUpdate.TabIndex = 8;
            this.GroupBox_DLPC150FWUpdate.TabStop = false;
            this.GroupBox_DLPC150FWUpdate.Text = "DLPC150 Firmware Update";
            // 
            // Button_DLPC150FWUpdate
            // 
            this.Button_DLPC150FWUpdate.Location = new System.Drawing.Point(531, 64);
            this.Button_DLPC150FWUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.Button_DLPC150FWUpdate.Name = "Button_DLPC150FWUpdate";
            this.Button_DLPC150FWUpdate.Size = new System.Drawing.Size(94, 29);
            this.Button_DLPC150FWUpdate.TabIndex = 3;
            this.Button_DLPC150FWUpdate.Text = "Update";
            this.Button_DLPC150FWUpdate.UseVisualStyleBackColor = true;
            this.Button_DLPC150FWUpdate.Click += new System.EventHandler(this.Button_DLPC150FWUpdate_Click);
            // 
            // ProgressBar_DLPC150FWUpdateStatus
            // 
            this.ProgressBar_DLPC150FWUpdateStatus.Location = new System.Drawing.Point(8, 64);
            this.ProgressBar_DLPC150FWUpdateStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar_DLPC150FWUpdateStatus.Name = "ProgressBar_DLPC150FWUpdateStatus";
            this.ProgressBar_DLPC150FWUpdateStatus.Size = new System.Drawing.Size(516, 29);
            this.ProgressBar_DLPC150FWUpdateStatus.TabIndex = 4;
            // 
            // Button_DLPC150FWBrowse
            // 
            this.Button_DLPC150FWBrowse.Location = new System.Drawing.Point(531, 20);
            this.Button_DLPC150FWBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.Button_DLPC150FWBrowse.Name = "Button_DLPC150FWBrowse";
            this.Button_DLPC150FWBrowse.Size = new System.Drawing.Size(94, 29);
            this.Button_DLPC150FWBrowse.TabIndex = 2;
            this.Button_DLPC150FWBrowse.Text = "Browse";
            this.Button_DLPC150FWBrowse.UseVisualStyleBackColor = true;
            this.Button_DLPC150FWBrowse.Click += new System.EventHandler(this.Button_DLPC150FWBrowse_Click);
            // 
            // TextBox_DLPC150FWPath
            // 
            this.TextBox_DLPC150FWPath.Location = new System.Drawing.Point(95, 24);
            this.TextBox_DLPC150FWPath.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_DLPC150FWPath.Name = "TextBox_DLPC150FWPath";
            this.TextBox_DLPC150FWPath.Size = new System.Drawing.Size(428, 24);
            this.TextBox_DLPC150FWPath.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "File Name";
            // 
            // GroupBox_TivaFWUpdate
            // 
            this.GroupBox_TivaFWUpdate.Controls.Add(this.Button_TivaFWUpdate);
            this.GroupBox_TivaFWUpdate.Controls.Add(this.ProgressBar_TivaFWUpdateStatus);
            this.GroupBox_TivaFWUpdate.Controls.Add(this.Button_TivaFWBrowse);
            this.GroupBox_TivaFWUpdate.Controls.Add(this.TextBox_TivaFWPath);
            this.GroupBox_TivaFWUpdate.Controls.Add(this.Label_TivaFWName);
            this.GroupBox_TivaFWUpdate.Location = new System.Drawing.Point(458, 8);
            this.GroupBox_TivaFWUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_TivaFWUpdate.Name = "GroupBox_TivaFWUpdate";
            this.GroupBox_TivaFWUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_TivaFWUpdate.Size = new System.Drawing.Size(639, 102);
            this.GroupBox_TivaFWUpdate.TabIndex = 7;
            this.GroupBox_TivaFWUpdate.TabStop = false;
            this.GroupBox_TivaFWUpdate.Text = "TIVA Firmware Update";
            // 
            // Button_TivaFWUpdate
            // 
            this.Button_TivaFWUpdate.Location = new System.Drawing.Point(531, 64);
            this.Button_TivaFWUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.Button_TivaFWUpdate.Name = "Button_TivaFWUpdate";
            this.Button_TivaFWUpdate.Size = new System.Drawing.Size(94, 29);
            this.Button_TivaFWUpdate.TabIndex = 3;
            this.Button_TivaFWUpdate.Text = "Update";
            this.Button_TivaFWUpdate.UseVisualStyleBackColor = true;
            this.Button_TivaFWUpdate.Click += new System.EventHandler(this.Button_TivaFWUpdate_Click);
            // 
            // ProgressBar_TivaFWUpdateStatus
            // 
            this.ProgressBar_TivaFWUpdateStatus.Location = new System.Drawing.Point(8, 64);
            this.ProgressBar_TivaFWUpdateStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar_TivaFWUpdateStatus.Name = "ProgressBar_TivaFWUpdateStatus";
            this.ProgressBar_TivaFWUpdateStatus.Size = new System.Drawing.Size(516, 29);
            this.ProgressBar_TivaFWUpdateStatus.TabIndex = 4;
            // 
            // Button_TivaFWBrowse
            // 
            this.Button_TivaFWBrowse.Location = new System.Drawing.Point(531, 22);
            this.Button_TivaFWBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.Button_TivaFWBrowse.Name = "Button_TivaFWBrowse";
            this.Button_TivaFWBrowse.Size = new System.Drawing.Size(94, 29);
            this.Button_TivaFWBrowse.TabIndex = 2;
            this.Button_TivaFWBrowse.Text = "Browse";
            this.Button_TivaFWBrowse.UseVisualStyleBackColor = true;
            this.Button_TivaFWBrowse.Click += new System.EventHandler(this.Button_TivaFWBrowse_Click);
            // 
            // TextBox_TivaFWPath
            // 
            this.TextBox_TivaFWPath.Location = new System.Drawing.Point(95, 24);
            this.TextBox_TivaFWPath.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_TivaFWPath.Name = "TextBox_TivaFWPath";
            this.TextBox_TivaFWPath.Size = new System.Drawing.Size(428, 24);
            this.TextBox_TivaFWPath.TabIndex = 1;
            // 
            // Label_TivaFWName
            // 
            this.Label_TivaFWName.AutoSize = true;
            this.Label_TivaFWName.Location = new System.Drawing.Point(9, 28);
            this.Label_TivaFWName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TivaFWName.Name = "Label_TivaFWName";
            this.Label_TivaFWName.Size = new System.Drawing.Size(64, 17);
            this.Label_TivaFWName.TabIndex = 0;
            this.Label_TivaFWName.Text = "File Name";
            // 
            // GroupBox_SerialNumber
            // 
            this.GroupBox_SerialNumber.Controls.Add(this.Button_SerialNumberGet);
            this.GroupBox_SerialNumber.Controls.Add(this.Button_SerialNumberSet);
            this.GroupBox_SerialNumber.Controls.Add(this.TextBox_SerialNumber);
            this.GroupBox_SerialNumber.Location = new System.Drawing.Point(234, 8);
            this.GroupBox_SerialNumber.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_SerialNumber.Name = "GroupBox_SerialNumber";
            this.GroupBox_SerialNumber.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_SerialNumber.Size = new System.Drawing.Size(216, 102);
            this.GroupBox_SerialNumber.TabIndex = 2;
            this.GroupBox_SerialNumber.TabStop = false;
            this.GroupBox_SerialNumber.Text = "Serial Number";
            // 
            // Button_SerialNumberGet
            // 
            this.Button_SerialNumberGet.Location = new System.Drawing.Point(110, 64);
            this.Button_SerialNumberGet.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SerialNumberGet.Name = "Button_SerialNumberGet";
            this.Button_SerialNumberGet.Size = new System.Drawing.Size(94, 29);
            this.Button_SerialNumberGet.TabIndex = 2;
            this.Button_SerialNumberGet.Text = "Get";
            this.Button_SerialNumberGet.UseVisualStyleBackColor = true;
            this.Button_SerialNumberGet.Click += new System.EventHandler(this.Button_SerialNumberGet_Click);
            this.Button_SerialNumberGet.MouseLeave += new System.EventHandler(this.Button_SerialNumberGet_MouseLeave);
            // 
            // Button_SerialNumberSet
            // 
            this.Button_SerialNumberSet.Location = new System.Drawing.Point(9, 64);
            this.Button_SerialNumberSet.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SerialNumberSet.Name = "Button_SerialNumberSet";
            this.Button_SerialNumberSet.Size = new System.Drawing.Size(94, 29);
            this.Button_SerialNumberSet.TabIndex = 1;
            this.Button_SerialNumberSet.Text = "Set";
            this.Button_SerialNumberSet.UseVisualStyleBackColor = true;
            this.Button_SerialNumberSet.Visible = false;
            this.Button_SerialNumberSet.Click += new System.EventHandler(this.Button_SerialNumberSet_Click);
            // 
            // TextBox_SerialNumber
            // 
            this.TextBox_SerialNumber.Location = new System.Drawing.Point(9, 28);
            this.TextBox_SerialNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_SerialNumber.Name = "TextBox_SerialNumber";
            this.TextBox_SerialNumber.Size = new System.Drawing.Size(194, 24);
            this.TextBox_SerialNumber.TabIndex = 0;
            this.TextBox_SerialNumber.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox_SerialNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.TextBox_SerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // GroupBox_ModelName
            // 
            this.GroupBox_ModelName.Controls.Add(this.Button_ModelNameGet);
            this.GroupBox_ModelName.Controls.Add(this.Button_ModelNameSet);
            this.GroupBox_ModelName.Controls.Add(this.TextBox_ModelName);
            this.GroupBox_ModelName.Location = new System.Drawing.Point(10, 8);
            this.GroupBox_ModelName.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_ModelName.Name = "GroupBox_ModelName";
            this.GroupBox_ModelName.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_ModelName.Size = new System.Drawing.Size(216, 102);
            this.GroupBox_ModelName.TabIndex = 1;
            this.GroupBox_ModelName.TabStop = false;
            this.GroupBox_ModelName.Text = "Model Name";
            // 
            // Button_ModelNameGet
            // 
            this.Button_ModelNameGet.Location = new System.Drawing.Point(110, 64);
            this.Button_ModelNameGet.Margin = new System.Windows.Forms.Padding(4);
            this.Button_ModelNameGet.Name = "Button_ModelNameGet";
            this.Button_ModelNameGet.Size = new System.Drawing.Size(94, 29);
            this.Button_ModelNameGet.TabIndex = 2;
            this.Button_ModelNameGet.Text = "Get";
            this.Button_ModelNameGet.UseVisualStyleBackColor = true;
            this.Button_ModelNameGet.Click += new System.EventHandler(this.Button_ModelNameGet_Click);
            this.Button_ModelNameGet.MouseLeave += new System.EventHandler(this.Button_ModelNameGet_MouseLeave);
            // 
            // Button_ModelNameSet
            // 
            this.Button_ModelNameSet.Location = new System.Drawing.Point(9, 64);
            this.Button_ModelNameSet.Margin = new System.Windows.Forms.Padding(4);
            this.Button_ModelNameSet.Name = "Button_ModelNameSet";
            this.Button_ModelNameSet.Size = new System.Drawing.Size(94, 29);
            this.Button_ModelNameSet.TabIndex = 1;
            this.Button_ModelNameSet.Text = "Set";
            this.Button_ModelNameSet.UseVisualStyleBackColor = true;
            this.Button_ModelNameSet.Visible = false;
            this.Button_ModelNameSet.Click += new System.EventHandler(this.Button_ModelNameSet_Click);
            // 
            // TextBox_ModelName
            // 
            this.TextBox_ModelName.Location = new System.Drawing.Point(9, 28);
            this.TextBox_ModelName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_ModelName.Name = "TextBox_ModelName";
            this.TextBox_ModelName.Size = new System.Drawing.Size(194, 24);
            this.TextBox_ModelName.TabIndex = 0;
            this.TextBox_ModelName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox_ModelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.TextBox_ModelName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // tabPage_Scan
            // 
            this.tabPage_Scan.Controls.Add(this.splitContainer1);
            this.tabPage_Scan.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Scan.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Scan.Name = "tabPage_Scan";
            this.tabPage_Scan.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Scan.Size = new System.Drawing.Size(1570, 795);
            this.tabPage_Scan.TabIndex = 0;
            this.tabPage_Scan.Text = "Scan";
            this.tabPage_Scan.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_ClearPlots);
            this.splitContainer1.Panel1.Controls.Add(this.Button_ClearAllErrors);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.Check_Overlay);
            this.splitContainer1.Panel1.Controls.Add(this.RadioButton_Reference);
            this.splitContainer1.Panel1.Controls.Add(this.RadioButton_Intensity);
            this.splitContainer1.Panel1.Controls.Add(this.RadioButton_Absorbance);
            this.splitContainer1.Panel1.Controls.Add(this.RadioButton_Reflectance);
            this.splitContainer1.Panel1.Controls.Add(this.Label_EstimatedScanTime);
            this.splitContainer1.Panel1.Controls.Add(this.Label_CurrentConfig);
            this.splitContainer1.Panel1.Controls.Add(this.Label_ScanStatus);
            this.splitContainer1.Panel1MinSize = 840;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabScanPositions);
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(1562, 798);
            this.splitContainer1.SplitterDistance = 1049;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_ClearPlots
            // 
            this.button_ClearPlots.Location = new System.Drawing.Point(761, 754);
            this.button_ClearPlots.Name = "button_ClearPlots";
            this.button_ClearPlots.Size = new System.Drawing.Size(87, 29);
            this.button_ClearPlots.TabIndex = 13;
            this.button_ClearPlots.Text = "Clear Plots";
            this.button_ClearPlots.UseVisualStyleBackColor = true;
            // 
            // Button_ClearAllErrors
            // 
            this.Button_ClearAllErrors.Location = new System.Drawing.Point(867, 754);
            this.Button_ClearAllErrors.Margin = new System.Windows.Forms.Padding(4);
            this.Button_ClearAllErrors.Name = "Button_ClearAllErrors";
            this.Button_ClearAllErrors.Size = new System.Drawing.Size(159, 29);
            this.Button_ClearAllErrors.TabIndex = 12;
            this.Button_ClearAllErrors.Text = "Clear Device Errors";
            this.Button_ClearAllErrors.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.MyChart);
            this.panel1.Location = new System.Drawing.Point(4, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 650);
            this.panel1.TabIndex = 16;
            // 
            // MyChart
            // 
            this.MyChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyChart.Location = new System.Drawing.Point(0, 0);
            this.MyChart.Margin = new System.Windows.Forms.Padding(4);
            this.MyChart.Name = "MyChart";
            this.MyChart.Size = new System.Drawing.Size(1044, 650);
            this.MyChart.TabIndex = 0;
            this.MyChart.Text = "cartesianChart1";
            // 
            // Check_Overlay
            // 
            this.Check_Overlay.AutoSize = true;
            this.Check_Overlay.Location = new System.Drawing.Point(539, 732);
            this.Check_Overlay.Margin = new System.Windows.Forms.Padding(4);
            this.Check_Overlay.Name = "Check_Overlay";
            this.Check_Overlay.Size = new System.Drawing.Size(73, 21);
            this.Check_Overlay.TabIndex = 9;
            this.Check_Overlay.TabStop = false;
            this.Check_Overlay.Text = "Overlay";
            this.Check_Overlay.UseVisualStyleBackColor = true;
            this.Check_Overlay.CheckedChanged += new System.EventHandler(this.Check_Overlay_CheckedChanged);
            // 
            // RadioButton_Reference
            // 
            this.RadioButton_Reference.AutoSize = true;
            this.RadioButton_Reference.Location = new System.Drawing.Point(422, 731);
            this.RadioButton_Reference.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Reference.Name = "RadioButton_Reference";
            this.RadioButton_Reference.Size = new System.Drawing.Size(87, 21);
            this.RadioButton_Reference.TabIndex = 7;
            this.RadioButton_Reference.Text = "Reference";
            this.RadioButton_Reference.UseVisualStyleBackColor = true;
            this.RadioButton_Reference.CheckedChanged += new System.EventHandler(this.RadioButton_SpectrumData_CheckedChanged);
            // 
            // RadioButton_Intensity
            // 
            this.RadioButton_Intensity.AutoSize = true;
            this.RadioButton_Intensity.Location = new System.Drawing.Point(305, 731);
            this.RadioButton_Intensity.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Intensity.Name = "RadioButton_Intensity";
            this.RadioButton_Intensity.Size = new System.Drawing.Size(78, 21);
            this.RadioButton_Intensity.TabIndex = 6;
            this.RadioButton_Intensity.Text = "Intensity";
            this.RadioButton_Intensity.UseVisualStyleBackColor = true;
            this.RadioButton_Intensity.CheckedChanged += new System.EventHandler(this.RadioButton_SpectrumData_CheckedChanged);
            // 
            // RadioButton_Absorbance
            // 
            this.RadioButton_Absorbance.AutoSize = true;
            this.RadioButton_Absorbance.Location = new System.Drawing.Point(170, 731);
            this.RadioButton_Absorbance.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Absorbance.Name = "RadioButton_Absorbance";
            this.RadioButton_Absorbance.Size = new System.Drawing.Size(95, 21);
            this.RadioButton_Absorbance.TabIndex = 5;
            this.RadioButton_Absorbance.Text = "Absorbance";
            this.RadioButton_Absorbance.UseVisualStyleBackColor = true;
            this.RadioButton_Absorbance.CheckedChanged += new System.EventHandler(this.RadioButton_SpectrumData_CheckedChanged);
            // 
            // RadioButton_Reflectance
            // 
            this.RadioButton_Reflectance.AutoSize = true;
            this.RadioButton_Reflectance.Location = new System.Drawing.Point(34, 731);
            this.RadioButton_Reflectance.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_Reflectance.Name = "RadioButton_Reflectance";
            this.RadioButton_Reflectance.Size = new System.Drawing.Size(96, 21);
            this.RadioButton_Reflectance.TabIndex = 4;
            this.RadioButton_Reflectance.Text = "Reflectance";
            this.RadioButton_Reflectance.UseVisualStyleBackColor = true;
            this.RadioButton_Reflectance.CheckedChanged += new System.EventHandler(this.RadioButton_SpectrumData_CheckedChanged);
            // 
            // Label_EstimatedScanTime
            // 
            this.Label_EstimatedScanTime.Location = new System.Drawing.Point(734, 49);
            this.Label_EstimatedScanTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_EstimatedScanTime.Name = "Label_EstimatedScanTime";
            this.Label_EstimatedScanTime.Size = new System.Drawing.Size(292, 34);
            this.Label_EstimatedScanTime.TabIndex = 3;
            // 
            // Label_ScanStatus
            // 
            this.Label_ScanStatus.Location = new System.Drawing.Point(25, 18);
            this.Label_ScanStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ScanStatus.Name = "Label_ScanStatus";
            this.Label_ScanStatus.Size = new System.Drawing.Size(331, 34);
            this.Label_ScanStatus.TabIndex = 1;
            // 
            // tabScanPositions
            // 
            this.tabScanPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabScanPositions.Controls.Add(this.tabPage_SavePositions);
            this.tabScanPositions.Controls.Add(this.tabPage_ScanConfig);
            this.tabScanPositions.Controls.Add(this.tabPage_SaveScans);
            this.tabScanPositions.Controls.Add(this.tabPage_PickTable);
            this.tabScanPositions.Controls.Add(this.tabPage_ChemicalImage);
            this.tabScanPositions.Location = new System.Drawing.Point(-4, 0);
            this.tabScanPositions.Margin = new System.Windows.Forms.Padding(4);
            this.tabScanPositions.Name = "tabScanPositions";
            this.tabScanPositions.SelectedIndex = 0;
            this.tabScanPositions.Size = new System.Drawing.Size(496, 794);
            this.tabScanPositions.TabIndex = 0;
            this.tabScanPositions.SelectedIndexChanged += new System.EventHandler(this.tabScanPage_SelectedIndexChanged);
            this.tabScanPositions.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabPage_Selecting);
            this.tabScanPositions.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabPage_Deselecting);
            // 
            // tabPage_SavePositions
            // 
            this.tabPage_SavePositions.Controls.Add(this.label3);
            this.tabPage_SavePositions.Controls.Add(this.GroupBox_GainControl);
            this.tabPage_SavePositions.Controls.Add(this.GroupBox_SaveScan);
            this.tabPage_SavePositions.Controls.Add(this.GroupBox_ScanAvg);
            this.tabPage_SavePositions.Controls.Add(this.GroupBox_LampControl);
            this.tabPage_SavePositions.Controls.Add(this.button_Undo);
            this.tabPage_SavePositions.Controls.Add(this.button_Save);
            this.tabPage_SavePositions.Controls.Add(this.comboBox_COMport);
            this.tabPage_SavePositions.Controls.Add(this.label_usb);
            this.tabPage_SavePositions.Controls.Add(this.groupBox_Display);
            this.tabPage_SavePositions.Location = new System.Drawing.Point(4, 24);
            this.tabPage_SavePositions.Name = "tabPage_SavePositions";
            this.tabPage_SavePositions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SavePositions.Size = new System.Drawing.Size(488, 766);
            this.tabPage_SavePositions.TabIndex = 3;
            this.tabPage_SavePositions.Text = "Scan Positions";
            this.tabPage_SavePositions.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Scan Setting :";
            // 
            // GroupBox_GainControl
            // 
            this.GroupBox_GainControl.Controls.Add(this.CheckBox_AutoGain);
            this.GroupBox_GainControl.Controls.Add(this.ComboBox_PGAGain);
            this.GroupBox_GainControl.Controls.Add(this.label1);
            this.GroupBox_GainControl.Location = new System.Drawing.Point(6, 352);
            this.GroupBox_GainControl.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_GainControl.Name = "GroupBox_GainControl";
            this.GroupBox_GainControl.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_GainControl.Size = new System.Drawing.Size(480, 69);
            this.GroupBox_GainControl.TabIndex = 8;
            this.GroupBox_GainControl.TabStop = false;
            this.GroupBox_GainControl.Text = "Gain Control";
            // 
            // CheckBox_AutoGain
            // 
            this.CheckBox_AutoGain.AutoSize = true;
            this.CheckBox_AutoGain.Checked = true;
            this.CheckBox_AutoGain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_AutoGain.Location = new System.Drawing.Point(201, 32);
            this.CheckBox_AutoGain.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_AutoGain.Name = "CheckBox_AutoGain";
            this.CheckBox_AutoGain.Size = new System.Drawing.Size(57, 21);
            this.CheckBox_AutoGain.TabIndex = 2;
            this.CheckBox_AutoGain.TabStop = false;
            this.CheckBox_AutoGain.Text = "Auto";
            this.CheckBox_AutoGain.UseVisualStyleBackColor = true;
            // 
            // ComboBox_PGAGain
            // 
            this.ComboBox_PGAGain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_PGAGain.FormattingEnabled = true;
            this.ComboBox_PGAGain.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.ComboBox_PGAGain.Location = new System.Drawing.Point(95, 28);
            this.ComboBox_PGAGain.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_PGAGain.Name = "ComboBox_PGAGain";
            this.ComboBox_PGAGain.Size = new System.Drawing.Size(89, 25);
            this.ComboBox_PGAGain.TabIndex = 1;
            this.ComboBox_PGAGain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PGA Gain";
            // 
            // GroupBox_SaveScan
            // 
            this.GroupBox_SaveScan.Controls.Add(this.label6);
            this.GroupBox_SaveScan.Controls.Add(this.CheckBox_AverageCSV);
            this.GroupBox_SaveScan.Controls.Add(this.label11);
            this.GroupBox_SaveScan.Controls.Add(this.label10);
            this.GroupBox_SaveScan.Controls.Add(this.TextBox_FileNamePrefix3);
            this.GroupBox_SaveScan.Controls.Add(this.TextBox_FileNamePrefix2);
            this.GroupBox_SaveScan.Controls.Add(this.CheckBox_SaveOneCSV);
            this.GroupBox_SaveScan.Controls.Add(this.TextBox_FileNamePrefix1);
            this.GroupBox_SaveScan.Controls.Add(this.CheckBox_FileNamePrefix);
            this.GroupBox_SaveScan.Controls.Add(this.TextBox_SaveDirPath);
            this.GroupBox_SaveScan.Controls.Add(this.Button_SaveDirChange);
            this.GroupBox_SaveScan.Controls.Add(this.CheckBox_SaveRCSV);
            this.GroupBox_SaveScan.Controls.Add(this.CheckBox_SaveACSV);
            this.GroupBox_SaveScan.Controls.Add(this.CheckBox_SaveICSV);
            this.GroupBox_SaveScan.Controls.Add(this.CheckBox_SaveCombCSV);
            this.GroupBox_SaveScan.Location = new System.Drawing.Point(6, 503);
            this.GroupBox_SaveScan.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_SaveScan.Name = "GroupBox_SaveScan";
            this.GroupBox_SaveScan.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_SaveScan.Size = new System.Drawing.Size(480, 179);
            this.GroupBox_SaveScan.TabIndex = 10;
            this.GroupBox_SaveScan.TabStop = false;
            this.GroupBox_SaveScan.Text = "Save Scan As";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(24, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(412, 2);
            this.label6.TabIndex = 24;
            // 
            // CheckBox_AverageCSV
            // 
            this.CheckBox_AverageCSV.AutoSize = true;
            this.CheckBox_AverageCSV.Location = new System.Drawing.Point(243, 63);
            this.CheckBox_AverageCSV.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_AverageCSV.Name = "CheckBox_AverageCSV";
            this.CheckBox_AverageCSV.Size = new System.Drawing.Size(101, 21);
            this.CheckBox_AverageCSV.TabIndex = 21;
            this.CheckBox_AverageCSV.Text = "-average.csv";
            this.CheckBox_AverageCSV.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "_";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "_";
            // 
            // TextBox_FileNamePrefix3
            // 
            this.TextBox_FileNamePrefix3.Location = new System.Drawing.Point(361, 93);
            this.TextBox_FileNamePrefix3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_FileNamePrefix3.Name = "TextBox_FileNamePrefix3";
            this.TextBox_FileNamePrefix3.Size = new System.Drawing.Size(74, 24);
            this.TextBox_FileNamePrefix3.TabIndex = 14;
            // 
            // TextBox_FileNamePrefix2
            // 
            this.TextBox_FileNamePrefix2.Location = new System.Drawing.Point(256, 92);
            this.TextBox_FileNamePrefix2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_FileNamePrefix2.Name = "TextBox_FileNamePrefix2";
            this.TextBox_FileNamePrefix2.Size = new System.Drawing.Size(74, 24);
            this.TextBox_FileNamePrefix2.TabIndex = 13;
            // 
            // CheckBox_SaveOneCSV
            // 
            this.CheckBox_SaveOneCSV.AutoSize = true;
            this.CheckBox_SaveOneCSV.Location = new System.Drawing.Point(109, 63);
            this.CheckBox_SaveOneCSV.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_SaveOneCSV.Name = "CheckBox_SaveOneCSV";
            this.CheckBox_SaveOneCSV.Size = new System.Drawing.Size(110, 21);
            this.CheckBox_SaveOneCSV.TabIndex = 2;
            this.CheckBox_SaveOneCSV.TabStop = false;
            this.CheckBox_SaveOneCSV.Text = "-combined.csv";
            this.CheckBox_SaveOneCSV.UseVisualStyleBackColor = true;
            // 
            // TextBox_FileNamePrefix1
            // 
            this.TextBox_FileNamePrefix1.Location = new System.Drawing.Point(166, 93);
            this.TextBox_FileNamePrefix1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_FileNamePrefix1.Name = "TextBox_FileNamePrefix1";
            this.TextBox_FileNamePrefix1.Size = new System.Drawing.Size(74, 24);
            this.TextBox_FileNamePrefix1.TabIndex = 12;
            // 
            // CheckBox_FileNamePrefix
            // 
            this.CheckBox_FileNamePrefix.AutoSize = true;
            this.CheckBox_FileNamePrefix.Location = new System.Drawing.Point(24, 93);
            this.CheckBox_FileNamePrefix.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_FileNamePrefix.Name = "CheckBox_FileNamePrefix";
            this.CheckBox_FileNamePrefix.Size = new System.Drawing.Size(121, 21);
            this.CheckBox_FileNamePrefix.TabIndex = 11;
            this.CheckBox_FileNamePrefix.TabStop = false;
            this.CheckBox_FileNamePrefix.Text = "File Name Prefix";
            this.CheckBox_FileNamePrefix.UseVisualStyleBackColor = true;
            // 
            // TextBox_SaveDirPath
            // 
            this.TextBox_SaveDirPath.Location = new System.Drawing.Point(24, 134);
            this.TextBox_SaveDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_SaveDirPath.Name = "TextBox_SaveDirPath";
            this.TextBox_SaveDirPath.ReadOnly = true;
            this.TextBox_SaveDirPath.Size = new System.Drawing.Size(313, 24);
            this.TextBox_SaveDirPath.TabIndex = 9;
            this.TextBox_SaveDirPath.TabStop = false;
            // 
            // Button_SaveDirChange
            // 
            this.Button_SaveDirChange.Location = new System.Drawing.Point(346, 134);
            this.Button_SaveDirChange.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SaveDirChange.Name = "Button_SaveDirChange";
            this.Button_SaveDirChange.Size = new System.Drawing.Size(90, 29);
            this.Button_SaveDirChange.TabIndex = 10;
            this.Button_SaveDirChange.Text = "Directory";
            this.Button_SaveDirChange.UseVisualStyleBackColor = true;
            // 
            // CheckBox_SaveRCSV
            // 
            this.CheckBox_SaveRCSV.AutoSize = true;
            this.CheckBox_SaveRCSV.Location = new System.Drawing.Point(334, 35);
            this.CheckBox_SaveRCSV.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_SaveRCSV.Name = "CheckBox_SaveRCSV";
            this.CheckBox_SaveRCSV.Size = new System.Drawing.Size(98, 21);
            this.CheckBox_SaveRCSV.TabIndex = 5;
            this.CheckBox_SaveRCSV.TabStop = false;
            this.CheckBox_SaveRCSV.Text = "-reflectance";
            this.CheckBox_SaveRCSV.UseVisualStyleBackColor = true;
            // 
            // CheckBox_SaveACSV
            // 
            this.CheckBox_SaveACSV.AutoSize = true;
            this.CheckBox_SaveACSV.Location = new System.Drawing.Point(213, 35);
            this.CheckBox_SaveACSV.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_SaveACSV.Name = "CheckBox_SaveACSV";
            this.CheckBox_SaveACSV.Size = new System.Drawing.Size(99, 21);
            this.CheckBox_SaveACSV.TabIndex = 4;
            this.CheckBox_SaveACSV.TabStop = false;
            this.CheckBox_SaveACSV.Text = "-absorbance";
            this.CheckBox_SaveACSV.UseVisualStyleBackColor = true;
            // 
            // CheckBox_SaveICSV
            // 
            this.CheckBox_SaveICSV.AutoSize = true;
            this.CheckBox_SaveICSV.Location = new System.Drawing.Point(109, 35);
            this.CheckBox_SaveICSV.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_SaveICSV.Name = "CheckBox_SaveICSV";
            this.CheckBox_SaveICSV.Size = new System.Drawing.Size(82, 21);
            this.CheckBox_SaveICSV.TabIndex = 3;
            this.CheckBox_SaveICSV.TabStop = false;
            this.CheckBox_SaveICSV.Text = "-intensity";
            this.CheckBox_SaveICSV.UseVisualStyleBackColor = true;
            // 
            // GroupBox_LampControl
            // 
            this.GroupBox_LampControl.Controls.Add(this.TextBox_LampStableTime);
            this.GroupBox_LampControl.Controls.Add(this.RadioButton_LampStableTime);
            this.GroupBox_LampControl.Location = new System.Drawing.Point(6, 286);
            this.GroupBox_LampControl.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_LampControl.Name = "GroupBox_LampControl";
            this.GroupBox_LampControl.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_LampControl.Size = new System.Drawing.Size(480, 58);
            this.GroupBox_LampControl.TabIndex = 7;
            this.GroupBox_LampControl.TabStop = false;
            this.GroupBox_LampControl.Text = "Lamp Control";
            // 
            // TextBox_LampStableTime
            // 
            this.TextBox_LampStableTime.Location = new System.Drawing.Point(330, 22);
            this.TextBox_LampStableTime.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_LampStableTime.Name = "TextBox_LampStableTime";
            this.TextBox_LampStableTime.Size = new System.Drawing.Size(142, 24);
            this.TextBox_LampStableTime.TabIndex = 3;
            this.TextBox_LampStableTime.Text = "625";
            this.TextBox_LampStableTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RadioButton_LampStableTime
            // 
            this.RadioButton_LampStableTime.AutoSize = true;
            this.RadioButton_LampStableTime.Checked = true;
            this.RadioButton_LampStableTime.Location = new System.Drawing.Point(8, 25);
            this.RadioButton_LampStableTime.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_LampStableTime.Name = "RadioButton_LampStableTime";
            this.RadioButton_LampStableTime.Size = new System.Drawing.Size(267, 21);
            this.RadioButton_LampStableTime.TabIndex = 2;
            this.RadioButton_LampStableTime.TabStop = true;
            this.RadioButton_LampStableTime.Text = "Lamp Stable Time  (Unit: ms, Default: 625)";
            this.RadioButton_LampStableTime.UseVisualStyleBackColor = true;
            // 
            // button_Undo
            // 
            this.button_Undo.Location = new System.Drawing.Point(256, 211);
            this.button_Undo.Name = "button_Undo";
            this.button_Undo.Size = new System.Drawing.Size(101, 35);
            this.button_Undo.TabIndex = 4;
            this.button_Undo.Text = "Undo";
            this.button_Undo.UseVisualStyleBackColor = true;
            this.button_Undo.Click += new System.EventHandler(this.button_Undo_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(137, 211);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(101, 35);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_COMport
            // 
            this.comboBox_COMport.FormattingEnabled = true;
            this.comboBox_COMport.Location = new System.Drawing.Point(278, 165);
            this.comboBox_COMport.Name = "comboBox_COMport";
            this.comboBox_COMport.Size = new System.Drawing.Size(143, 23);
            this.comboBox_COMport.TabIndex = 2;
            // 
            // label_usb
            // 
            this.label_usb.AutoSize = true;
            this.label_usb.Location = new System.Drawing.Point(76, 168);
            this.label_usb.Name = "label_usb";
            this.label_usb.Size = new System.Drawing.Size(189, 17);
            this.label_usb.TabIndex = 1;
            this.label_usb.Text = "Please choose a USB to connect:";
            // 
            // groupBox_Display
            // 
            this.groupBox_Display.Controls.Add(this.groupBox_plate4);
            this.groupBox_Display.Controls.Add(this.groupBox_plate3);
            this.groupBox_Display.Controls.Add(this.groupBox_plate2);
            this.groupBox_Display.Controls.Add(this.groupBox_plate1);
            this.groupBox_Display.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Display.Name = "groupBox_Display";
            this.groupBox_Display.Size = new System.Drawing.Size(479, 150);
            this.groupBox_Display.TabIndex = 0;
            this.groupBox_Display.TabStop = false;
            this.groupBox_Display.Text = "Display";
            // 
            // groupBox_plate4
            // 
            this.groupBox_plate4.Controls.Add(this.checkBox_Pos24);
            this.groupBox_plate4.Controls.Add(this.checkBox_Pos22);
            this.groupBox_plate4.Controls.Add(this.checkBox_Pos23);
            this.groupBox_plate4.Controls.Add(this.checkBox_Pos21);
            this.groupBox_plate4.Controls.Add(this.checkBox_Pos19);
            this.groupBox_plate4.Controls.Add(this.checkBox_Pos20);
            this.groupBox_plate4.Location = new System.Drawing.Point(363, 23);
            this.groupBox_plate4.Name = "groupBox_plate4";
            this.groupBox_plate4.Size = new System.Drawing.Size(110, 112);
            this.groupBox_plate4.TabIndex = 7;
            this.groupBox_plate4.TabStop = false;
            this.groupBox_plate4.Text = "Plate 4";
            // 
            // checkBox_Pos24
            // 
            this.checkBox_Pos24.AccessibleName = "Pos24";
            this.checkBox_Pos24.AutoSize = true;
            this.checkBox_Pos24.Location = new System.Drawing.Point(67, 77);
            this.checkBox_Pos24.Name = "checkBox_Pos24";
            this.checkBox_Pos24.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos24.TabIndex = 5;
            this.checkBox_Pos24.Text = "6";
            this.checkBox_Pos24.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos22
            // 
            this.checkBox_Pos22.AccessibleName = "Pos22";
            this.checkBox_Pos22.AutoSize = true;
            this.checkBox_Pos22.Location = new System.Drawing.Point(67, 50);
            this.checkBox_Pos22.Name = "checkBox_Pos22";
            this.checkBox_Pos22.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos22.TabIndex = 4;
            this.checkBox_Pos22.Text = "4";
            this.checkBox_Pos22.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos23
            // 
            this.checkBox_Pos23.AccessibleName = "Pos23";
            this.checkBox_Pos23.AutoSize = true;
            this.checkBox_Pos23.Location = new System.Drawing.Point(15, 77);
            this.checkBox_Pos23.Name = "checkBox_Pos23";
            this.checkBox_Pos23.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos23.TabIndex = 3;
            this.checkBox_Pos23.Text = "5";
            this.checkBox_Pos23.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos21
            // 
            this.checkBox_Pos21.AccessibleName = "Pos21";
            this.checkBox_Pos21.AutoSize = true;
            this.checkBox_Pos21.Location = new System.Drawing.Point(15, 50);
            this.checkBox_Pos21.Name = "checkBox_Pos21";
            this.checkBox_Pos21.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos21.TabIndex = 2;
            this.checkBox_Pos21.Text = "3";
            this.checkBox_Pos21.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos19
            // 
            this.checkBox_Pos19.AccessibleName = "Pos19";
            this.checkBox_Pos19.AutoSize = true;
            this.checkBox_Pos19.Location = new System.Drawing.Point(15, 23);
            this.checkBox_Pos19.Name = "checkBox_Pos19";
            this.checkBox_Pos19.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos19.TabIndex = 1;
            this.checkBox_Pos19.Text = "1";
            this.checkBox_Pos19.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos20
            // 
            this.checkBox_Pos20.AccessibleName = "Pos20";
            this.checkBox_Pos20.AutoSize = true;
            this.checkBox_Pos20.Location = new System.Drawing.Point(67, 23);
            this.checkBox_Pos20.Name = "checkBox_Pos20";
            this.checkBox_Pos20.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos20.TabIndex = 0;
            this.checkBox_Pos20.Text = "2";
            this.checkBox_Pos20.UseVisualStyleBackColor = true;
            // 
            // groupBox_plate3
            // 
            this.groupBox_plate3.Controls.Add(this.checkBox_Pos18);
            this.groupBox_plate3.Controls.Add(this.checkBox_Pos16);
            this.groupBox_plate3.Controls.Add(this.checkBox_Pos17);
            this.groupBox_plate3.Controls.Add(this.checkBox_Pos15);
            this.groupBox_plate3.Controls.Add(this.checkBox_Pos13);
            this.groupBox_plate3.Controls.Add(this.checkBox_Pos14);
            this.groupBox_plate3.Location = new System.Drawing.Point(247, 23);
            this.groupBox_plate3.Name = "groupBox_plate3";
            this.groupBox_plate3.Size = new System.Drawing.Size(110, 112);
            this.groupBox_plate3.TabIndex = 6;
            this.groupBox_plate3.TabStop = false;
            this.groupBox_plate3.Text = "Plate 3";
            // 
            // checkBox_Pos18
            // 
            this.checkBox_Pos18.AccessibleName = "Pos18";
            this.checkBox_Pos18.AutoSize = true;
            this.checkBox_Pos18.Location = new System.Drawing.Point(67, 77);
            this.checkBox_Pos18.Name = "checkBox_Pos18";
            this.checkBox_Pos18.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos18.TabIndex = 5;
            this.checkBox_Pos18.Text = "6";
            this.checkBox_Pos18.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos16
            // 
            this.checkBox_Pos16.AccessibleName = "Pos16";
            this.checkBox_Pos16.AutoSize = true;
            this.checkBox_Pos16.Location = new System.Drawing.Point(67, 50);
            this.checkBox_Pos16.Name = "checkBox_Pos16";
            this.checkBox_Pos16.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos16.TabIndex = 4;
            this.checkBox_Pos16.Text = "4";
            this.checkBox_Pos16.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos17
            // 
            this.checkBox_Pos17.AccessibleName = "Pos17";
            this.checkBox_Pos17.AutoSize = true;
            this.checkBox_Pos17.Location = new System.Drawing.Point(15, 77);
            this.checkBox_Pos17.Name = "checkBox_Pos17";
            this.checkBox_Pos17.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos17.TabIndex = 3;
            this.checkBox_Pos17.Text = "5";
            this.checkBox_Pos17.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos15
            // 
            this.checkBox_Pos15.AccessibleName = "Pos15";
            this.checkBox_Pos15.AutoSize = true;
            this.checkBox_Pos15.Location = new System.Drawing.Point(15, 50);
            this.checkBox_Pos15.Name = "checkBox_Pos15";
            this.checkBox_Pos15.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos15.TabIndex = 2;
            this.checkBox_Pos15.Text = "3";
            this.checkBox_Pos15.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos13
            // 
            this.checkBox_Pos13.AccessibleName = "Pos13";
            this.checkBox_Pos13.AutoSize = true;
            this.checkBox_Pos13.Location = new System.Drawing.Point(15, 23);
            this.checkBox_Pos13.Name = "checkBox_Pos13";
            this.checkBox_Pos13.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos13.TabIndex = 1;
            this.checkBox_Pos13.Text = "1";
            this.checkBox_Pos13.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos14
            // 
            this.checkBox_Pos14.AccessibleName = "Pos14";
            this.checkBox_Pos14.AutoSize = true;
            this.checkBox_Pos14.Location = new System.Drawing.Point(67, 23);
            this.checkBox_Pos14.Name = "checkBox_Pos14";
            this.checkBox_Pos14.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos14.TabIndex = 0;
            this.checkBox_Pos14.Text = "2";
            this.checkBox_Pos14.UseVisualStyleBackColor = true;
            // 
            // groupBox_plate2
            // 
            this.groupBox_plate2.Controls.Add(this.checkBox_Pos12);
            this.groupBox_plate2.Controls.Add(this.checkBox_Pos10);
            this.groupBox_plate2.Controls.Add(this.checkBox_Pos11);
            this.groupBox_plate2.Controls.Add(this.checkBox_Pos9);
            this.groupBox_plate2.Controls.Add(this.checkBox_Pos7);
            this.groupBox_plate2.Controls.Add(this.checkBox_Pos8);
            this.groupBox_plate2.Location = new System.Drawing.Point(122, 23);
            this.groupBox_plate2.Name = "groupBox_plate2";
            this.groupBox_plate2.Size = new System.Drawing.Size(110, 112);
            this.groupBox_plate2.TabIndex = 3;
            this.groupBox_plate2.TabStop = false;
            this.groupBox_plate2.Text = "Plate 2";
            // 
            // checkBox_Pos12
            // 
            this.checkBox_Pos12.AccessibleName = "Pos12";
            this.checkBox_Pos12.AutoSize = true;
            this.checkBox_Pos12.Location = new System.Drawing.Point(67, 77);
            this.checkBox_Pos12.Name = "checkBox_Pos12";
            this.checkBox_Pos12.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos12.TabIndex = 5;
            this.checkBox_Pos12.Text = "6";
            this.checkBox_Pos12.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos10
            // 
            this.checkBox_Pos10.AccessibleName = "Pos10";
            this.checkBox_Pos10.AutoSize = true;
            this.checkBox_Pos10.Location = new System.Drawing.Point(67, 50);
            this.checkBox_Pos10.Name = "checkBox_Pos10";
            this.checkBox_Pos10.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos10.TabIndex = 4;
            this.checkBox_Pos10.Text = "4";
            this.checkBox_Pos10.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos11
            // 
            this.checkBox_Pos11.AccessibleName = "Pos11";
            this.checkBox_Pos11.AutoSize = true;
            this.checkBox_Pos11.Location = new System.Drawing.Point(15, 77);
            this.checkBox_Pos11.Name = "checkBox_Pos11";
            this.checkBox_Pos11.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos11.TabIndex = 3;
            this.checkBox_Pos11.Text = "5";
            this.checkBox_Pos11.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos9
            // 
            this.checkBox_Pos9.AccessibleName = "Pos9";
            this.checkBox_Pos9.AutoSize = true;
            this.checkBox_Pos9.Location = new System.Drawing.Point(15, 50);
            this.checkBox_Pos9.Name = "checkBox_Pos9";
            this.checkBox_Pos9.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos9.TabIndex = 2;
            this.checkBox_Pos9.Text = "3";
            this.checkBox_Pos9.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos7
            // 
            this.checkBox_Pos7.AccessibleName = "Pos7";
            this.checkBox_Pos7.AutoSize = true;
            this.checkBox_Pos7.Location = new System.Drawing.Point(15, 23);
            this.checkBox_Pos7.Name = "checkBox_Pos7";
            this.checkBox_Pos7.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos7.TabIndex = 1;
            this.checkBox_Pos7.Text = "1";
            this.checkBox_Pos7.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos8
            // 
            this.checkBox_Pos8.AccessibleName = "Pos8";
            this.checkBox_Pos8.AutoSize = true;
            this.checkBox_Pos8.Location = new System.Drawing.Point(67, 23);
            this.checkBox_Pos8.Name = "checkBox_Pos8";
            this.checkBox_Pos8.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos8.TabIndex = 0;
            this.checkBox_Pos8.Text = "2";
            this.checkBox_Pos8.UseVisualStyleBackColor = true;
            // 
            // groupBox_plate1
            // 
            this.groupBox_plate1.Controls.Add(this.checkBox_Pos6);
            this.groupBox_plate1.Controls.Add(this.checkBox_Pos4);
            this.groupBox_plate1.Controls.Add(this.checkBox_Pos5);
            this.groupBox_plate1.Controls.Add(this.checkBox_Pos3);
            this.groupBox_plate1.Controls.Add(this.checkBox_Pos1);
            this.groupBox_plate1.Controls.Add(this.checkBox_Pos2);
            this.groupBox_plate1.Location = new System.Drawing.Point(6, 23);
            this.groupBox_plate1.Name = "groupBox_plate1";
            this.groupBox_plate1.Size = new System.Drawing.Size(110, 112);
            this.groupBox_plate1.TabIndex = 2;
            this.groupBox_plate1.TabStop = false;
            this.groupBox_plate1.Text = "Plate 1";
            // 
            // checkBox_Pos6
            // 
            this.checkBox_Pos6.AccessibleName = "Pos6";
            this.checkBox_Pos6.AutoSize = true;
            this.checkBox_Pos6.Location = new System.Drawing.Point(67, 77);
            this.checkBox_Pos6.Name = "checkBox_Pos6";
            this.checkBox_Pos6.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos6.TabIndex = 5;
            this.checkBox_Pos6.Text = "6";
            this.checkBox_Pos6.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos4
            // 
            this.checkBox_Pos4.AccessibleName = "Pos4";
            this.checkBox_Pos4.AutoSize = true;
            this.checkBox_Pos4.Location = new System.Drawing.Point(67, 50);
            this.checkBox_Pos4.Name = "checkBox_Pos4";
            this.checkBox_Pos4.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos4.TabIndex = 4;
            this.checkBox_Pos4.Text = "4";
            this.checkBox_Pos4.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos5
            // 
            this.checkBox_Pos5.AccessibleName = "Pos5";
            this.checkBox_Pos5.AutoSize = true;
            this.checkBox_Pos5.Location = new System.Drawing.Point(15, 77);
            this.checkBox_Pos5.Name = "checkBox_Pos5";
            this.checkBox_Pos5.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos5.TabIndex = 3;
            this.checkBox_Pos5.Text = "5";
            this.checkBox_Pos5.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos3
            // 
            this.checkBox_Pos3.AccessibleName = "Pos3";
            this.checkBox_Pos3.AutoSize = true;
            this.checkBox_Pos3.Location = new System.Drawing.Point(15, 50);
            this.checkBox_Pos3.Name = "checkBox_Pos3";
            this.checkBox_Pos3.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos3.TabIndex = 2;
            this.checkBox_Pos3.Text = "3";
            this.checkBox_Pos3.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos1
            // 
            this.checkBox_Pos1.AccessibleName = "Pos1";
            this.checkBox_Pos1.AutoSize = true;
            this.checkBox_Pos1.Location = new System.Drawing.Point(15, 23);
            this.checkBox_Pos1.Name = "checkBox_Pos1";
            this.checkBox_Pos1.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos1.TabIndex = 1;
            this.checkBox_Pos1.Text = "1";
            this.checkBox_Pos1.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pos2
            // 
            this.checkBox_Pos2.AccessibleName = "Pos2";
            this.checkBox_Pos2.AutoSize = true;
            this.checkBox_Pos2.Location = new System.Drawing.Point(67, 23);
            this.checkBox_Pos2.Name = "checkBox_Pos2";
            this.checkBox_Pos2.Size = new System.Drawing.Size(37, 21);
            this.checkBox_Pos2.TabIndex = 0;
            this.checkBox_Pos2.Text = "2";
            this.checkBox_Pos2.UseVisualStyleBackColor = true;
            // 
            // tabPage_ScanConfig
            // 
            this.tabPage_ScanConfig.Controls.Add(this.label16);
            this.tabPage_ScanConfig.Controls.Add(this.label15);
            this.tabPage_ScanConfig.Controls.Add(this.Button_MoveCfgT2L);
            this.tabPage_ScanConfig.Controls.Add(this.Button_MoveCfgL2T);
            this.tabPage_ScanConfig.Controls.Add(this.Button_CopyCfgT2L);
            this.tabPage_ScanConfig.Controls.Add(this.Button_CopyCfgL2T);
            this.tabPage_ScanConfig.Controls.Add(this.ListBox_LocalCfgs);
            this.tabPage_ScanConfig.Controls.Add(this.label_ActiveConfig);
            this.tabPage_ScanConfig.Controls.Add(this.ListBox_TargetCfgs);
            this.tabPage_ScanConfig.Controls.Add(this.Button_SetActive);
            this.tabPage_ScanConfig.Controls.Add(this.label94);
            this.tabPage_ScanConfig.Controls.Add(this.Button_CfgCancel);
            this.tabPage_ScanConfig.Controls.Add(this.Button_CfgSave);
            this.tabPage_ScanConfig.Controls.Add(this.Button_CfgDelete);
            this.tabPage_ScanConfig.Controls.Add(this.Button_CfgEdit);
            this.tabPage_ScanConfig.Controls.Add(this.Button_CfgNew);
            this.tabPage_ScanConfig.Controls.Add(this.GroupBox_CfgDetails);
            this.tabPage_ScanConfig.Location = new System.Drawing.Point(4, 24);
            this.tabPage_ScanConfig.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_ScanConfig.Name = "tabPage_ScanConfig";
            this.tabPage_ScanConfig.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_ScanConfig.Size = new System.Drawing.Size(488, 766);
            this.tabPage_ScanConfig.TabIndex = 1;
            this.tabPage_ScanConfig.Text = "Scan Config";
            this.tabPage_ScanConfig.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(279, 48);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(201, 18);
            this.label16.TabIndex = 47;
            this.label16.Text = "Device configurations";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(8, 48);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(201, 18);
            this.label15.TabIndex = 46;
            this.label15.Text = "Local configurations";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_SetActive
            // 
            this.Button_SetActive.Location = new System.Drawing.Point(279, 346);
            this.Button_SetActive.Margin = new System.Windows.Forms.Padding(4);
            this.Button_SetActive.Name = "Button_SetActive";
            this.Button_SetActive.Size = new System.Drawing.Size(201, 29);
            this.Button_SetActive.TabIndex = 6;
            this.Button_SetActive.Text = "Set Device Default Config";
            this.Button_SetActive.UseVisualStyleBackColor = true;
            this.Button_SetActive.Click += new System.EventHandler(this.Button_SetActive_Click);
            // 
            // Button_CfgCancel
            // 
            this.Button_CfgCancel.Location = new System.Drawing.Point(392, 700);
            this.Button_CfgCancel.Margin = new System.Windows.Forms.Padding(4);
            this.Button_CfgCancel.Name = "Button_CfgCancel";
            this.Button_CfgCancel.Size = new System.Drawing.Size(88, 31);
            this.Button_CfgCancel.TabIndex = 4;
            this.Button_CfgCancel.Text = "Cancel";
            this.Button_CfgCancel.UseVisualStyleBackColor = true;
            this.Button_CfgCancel.Click += new System.EventHandler(this.Button_CfgCancel_Click);
            // 
            // Button_CfgSave
            // 
            this.Button_CfgSave.Location = new System.Drawing.Point(296, 700);
            this.Button_CfgSave.Margin = new System.Windows.Forms.Padding(4);
            this.Button_CfgSave.Name = "Button_CfgSave";
            this.Button_CfgSave.Size = new System.Drawing.Size(88, 31);
            this.Button_CfgSave.TabIndex = 3;
            this.Button_CfgSave.Text = "Save";
            this.Button_CfgSave.UseVisualStyleBackColor = true;
            this.Button_CfgSave.Click += new System.EventHandler(this.Button_CfgSave_Click);
            // 
            // Button_CfgDelete
            // 
            this.Button_CfgDelete.Location = new System.Drawing.Point(200, 700);
            this.Button_CfgDelete.Margin = new System.Windows.Forms.Padding(4);
            this.Button_CfgDelete.Name = "Button_CfgDelete";
            this.Button_CfgDelete.Size = new System.Drawing.Size(88, 31);
            this.Button_CfgDelete.TabIndex = 2;
            this.Button_CfgDelete.Text = "Delete";
            this.Button_CfgDelete.UseVisualStyleBackColor = true;
            this.Button_CfgDelete.Click += new System.EventHandler(this.Button_CfgDelete_Click);
            // 
            // Button_CfgEdit
            // 
            this.Button_CfgEdit.Location = new System.Drawing.Point(104, 700);
            this.Button_CfgEdit.Margin = new System.Windows.Forms.Padding(4);
            this.Button_CfgEdit.Name = "Button_CfgEdit";
            this.Button_CfgEdit.Size = new System.Drawing.Size(88, 31);
            this.Button_CfgEdit.TabIndex = 1;
            this.Button_CfgEdit.Text = "Edit";
            this.Button_CfgEdit.UseVisualStyleBackColor = true;
            this.Button_CfgEdit.Click += new System.EventHandler(this.Button_CfgEdit_Click);
            // 
            // Button_CfgNew
            // 
            this.Button_CfgNew.Location = new System.Drawing.Point(8, 700);
            this.Button_CfgNew.Margin = new System.Windows.Forms.Padding(4);
            this.Button_CfgNew.Name = "Button_CfgNew";
            this.Button_CfgNew.Size = new System.Drawing.Size(88, 31);
            this.Button_CfgNew.TabIndex = 0;
            this.Button_CfgNew.Text = "New";
            this.Button_CfgNew.UseVisualStyleBackColor = true;
            this.Button_CfgNew.Click += new System.EventHandler(this.Button_CfgNew_Click);
            // 
            // GroupBox_CfgDetails
            // 
            this.GroupBox_CfgDetails.Controls.Add(this.label_overSampleRate5);
            this.GroupBox_CfgDetails.Controls.Add(this.label_overSampleRate4);
            this.GroupBox_CfgDetails.Controls.Add(this.label_overSampleRate3);
            this.GroupBox_CfgDetails.Controls.Add(this.label_overSampleRate2);
            this.GroupBox_CfgDetails.Controls.Add(this.label_overSampleRate1);
            this.GroupBox_CfgDetails.Controls.Add(this.label14);
            this.GroupBox_CfgDetails.Controls.Add(this.comboBox_cfgNumSec);
            this.GroupBox_CfgDetails.Controls.Add(this.label93);
            this.GroupBox_CfgDetails.Controls.Add(this.label92);
            this.GroupBox_CfgDetails.Controls.Add(this.label91);
            this.GroupBox_CfgDetails.Controls.Add(this.label90);
            this.GroupBox_CfgDetails.Controls.Add(this.label89);
            this.GroupBox_CfgDetails.Controls.Add(this.label88);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgDigRes1);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgDigRes2);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgDigRes3);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgDigRes4);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgDigRes5);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgExposure1);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgExposure2);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgExposure3);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgExposure4);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgExposure5);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgWidth1);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgWidth2);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgWidth3);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgWidth4);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgWidth5);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeEnd1);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeEnd2);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeEnd3);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeEnd4);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeEnd5);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeStart1);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeStart2);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeStart3);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeStart4);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgScanType1);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgScanType2);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgScanType3);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgScanType4);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgRangeStart5);
            this.GroupBox_CfgDetails.Controls.Add(this.ComboBox_CfgScanType5);
            this.GroupBox_CfgDetails.Controls.Add(this.label87);
            this.GroupBox_CfgDetails.Controls.Add(this.label86);
            this.GroupBox_CfgDetails.Controls.Add(this.label85);
            this.GroupBox_CfgDetails.Controls.Add(this.label84);
            this.GroupBox_CfgDetails.Controls.Add(this.label83);
            this.GroupBox_CfgDetails.Controls.Add(this.label82);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgAvg);
            this.GroupBox_CfgDetails.Controls.Add(this.label81);
            this.GroupBox_CfgDetails.Controls.Add(this.TextBox_CfgName);
            this.GroupBox_CfgDetails.Controls.Add(this.label80);
            this.GroupBox_CfgDetails.Location = new System.Drawing.Point(8, 385);
            this.GroupBox_CfgDetails.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_CfgDetails.Name = "GroupBox_CfgDetails";
            this.GroupBox_CfgDetails.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_CfgDetails.Size = new System.Drawing.Size(476, 294);
            this.GroupBox_CfgDetails.TabIndex = 0;
            this.GroupBox_CfgDetails.TabStop = false;
            this.GroupBox_CfgDetails.Text = "Details";
            // 
            // label_overSampleRate5
            // 
            this.label_overSampleRate5.Location = new System.Drawing.Point(411, 266);
            this.label_overSampleRate5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_overSampleRate5.Name = "label_overSampleRate5";
            this.label_overSampleRate5.Size = new System.Drawing.Size(52, 18);
            this.label_overSampleRate5.TabIndex = 64;
            this.label_overSampleRate5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_overSampleRate4
            // 
            this.label_overSampleRate4.Location = new System.Drawing.Point(351, 266);
            this.label_overSampleRate4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_overSampleRate4.Name = "label_overSampleRate4";
            this.label_overSampleRate4.Size = new System.Drawing.Size(52, 18);
            this.label_overSampleRate4.TabIndex = 63;
            this.label_overSampleRate4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_overSampleRate3
            // 
            this.label_overSampleRate3.Location = new System.Drawing.Point(290, 266);
            this.label_overSampleRate3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_overSampleRate3.Name = "label_overSampleRate3";
            this.label_overSampleRate3.Size = new System.Drawing.Size(52, 18);
            this.label_overSampleRate3.TabIndex = 62;
            this.label_overSampleRate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_overSampleRate2
            // 
            this.label_overSampleRate2.Location = new System.Drawing.Point(228, 266);
            this.label_overSampleRate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_overSampleRate2.Name = "label_overSampleRate2";
            this.label_overSampleRate2.Size = new System.Drawing.Size(52, 18);
            this.label_overSampleRate2.TabIndex = 61;
            this.label_overSampleRate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_overSampleRate1
            // 
            this.label_overSampleRate1.Location = new System.Drawing.Point(168, 266);
            this.label_overSampleRate1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_overSampleRate1.Name = "label_overSampleRate1";
            this.label_overSampleRate1.Size = new System.Drawing.Size(52, 18);
            this.label_overSampleRate1.TabIndex = 60;
            this.label_overSampleRate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_cfgNumSec
            // 
            this.comboBox_cfgNumSec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_cfgNumSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cfgNumSec.FormattingEnabled = true;
            this.comboBox_cfgNumSec.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_cfgNumSec.Location = new System.Drawing.Point(115, 61);
            this.comboBox_cfgNumSec.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_cfgNumSec.Name = "comboBox_cfgNumSec";
            this.comboBox_cfgNumSec.Size = new System.Drawing.Size(52, 25);
            this.comboBox_cfgNumSec.TabIndex = 9;
            this.comboBox_cfgNumSec.SelectedIndexChanged += new System.EventHandler(this.CfgSection_SelectionChanged);
            this.comboBox_cfgNumSec.Enter += new System.EventHandler(this.CfgField_Enter);
            this.comboBox_cfgNumSec.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // label93
            // 
            this.label93.Location = new System.Drawing.Point(10, 238);
            this.label93.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(148, 16);
            this.label93.TabIndex = 46;
            this.label93.Text = "Digital Resolution";
            this.label93.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label92
            // 
            this.label92.Location = new System.Drawing.Point(10, 210);
            this.label92.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(148, 16);
            this.label92.TabIndex = 45;
            this.label92.Text = "Exposure Time (ms)";
            this.label92.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label91
            // 
            this.label91.Location = new System.Drawing.Point(10, 182);
            this.label91.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(148, 16);
            this.label91.TabIndex = 44;
            this.label91.Text = "Width (nm)";
            this.label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label90
            // 
            this.label90.Location = new System.Drawing.Point(10, 155);
            this.label90.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(148, 16);
            this.label90.TabIndex = 43;
            this.label90.Text = "Spectral Range End";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label89
            // 
            this.label89.Location = new System.Drawing.Point(10, 128);
            this.label89.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(148, 16);
            this.label89.TabIndex = 42;
            this.label89.Text = "Spectral Range Start";
            this.label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label88
            // 
            this.label88.Location = new System.Drawing.Point(10, 100);
            this.label88.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(148, 16);
            this.label88.TabIndex = 41;
            this.label88.Text = "Scan Type";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox_CfgDigRes1
            // 
            this.TextBox_CfgDigRes1.Location = new System.Drawing.Point(164, 234);
            this.TextBox_CfgDigRes1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgDigRes1.Name = "TextBox_CfgDigRes1";
            this.TextBox_CfgDigRes1.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgDigRes1.TabIndex = 15;
            this.TextBox_CfgDigRes1.Text = "3";
            this.TextBox_CfgDigRes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgDigRes1.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgDigRes1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgDigRes1.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgDigRes1.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgDigRes2
            // 
            this.TextBox_CfgDigRes2.Location = new System.Drawing.Point(225, 234);
            this.TextBox_CfgDigRes2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgDigRes2.Name = "TextBox_CfgDigRes2";
            this.TextBox_CfgDigRes2.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgDigRes2.TabIndex = 21;
            this.TextBox_CfgDigRes2.Text = "3";
            this.TextBox_CfgDigRes2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgDigRes2.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgDigRes2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgDigRes2.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgDigRes2.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgDigRes3
            // 
            this.TextBox_CfgDigRes3.Location = new System.Drawing.Point(286, 234);
            this.TextBox_CfgDigRes3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgDigRes3.Name = "TextBox_CfgDigRes3";
            this.TextBox_CfgDigRes3.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgDigRes3.TabIndex = 27;
            this.TextBox_CfgDigRes3.Text = "3";
            this.TextBox_CfgDigRes3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgDigRes3.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgDigRes3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgDigRes3.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgDigRes3.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgDigRes4
            // 
            this.TextBox_CfgDigRes4.Location = new System.Drawing.Point(348, 234);
            this.TextBox_CfgDigRes4.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgDigRes4.Name = "TextBox_CfgDigRes4";
            this.TextBox_CfgDigRes4.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgDigRes4.TabIndex = 33;
            this.TextBox_CfgDigRes4.Text = "3";
            this.TextBox_CfgDigRes4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgDigRes4.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgDigRes4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgDigRes4.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgDigRes4.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgDigRes5
            // 
            this.TextBox_CfgDigRes5.Location = new System.Drawing.Point(409, 234);
            this.TextBox_CfgDigRes5.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgDigRes5.Name = "TextBox_CfgDigRes5";
            this.TextBox_CfgDigRes5.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgDigRes5.TabIndex = 39;
            this.TextBox_CfgDigRes5.Text = "3";
            this.TextBox_CfgDigRes5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgDigRes5.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgDigRes5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgDigRes5.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgDigRes5.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // ComboBox_CfgExposure1
            // 
            this.ComboBox_CfgExposure1.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.ComboBox_CfgExposure1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgExposure1.FormattingEnabled = true;
            this.ComboBox_CfgExposure1.Location = new System.Drawing.Point(164, 206);
            this.ComboBox_CfgExposure1.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox_CfgExposure1.Name = "ComboBox_CfgExposure1";
            this.ComboBox_CfgExposure1.Size = new System.Drawing.Size(62, 23);
            this.ComboBox_CfgExposure1.TabIndex = 14;
            this.ComboBox_CfgExposure1.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgExposure1.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgExposure1.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgExposure2
            // 
            this.ComboBox_CfgExposure2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgExposure2.FormattingEnabled = true;
            this.ComboBox_CfgExposure2.Location = new System.Drawing.Point(225, 206);
            this.ComboBox_CfgExposure2.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgExposure2.Name = "ComboBox_CfgExposure2";
            this.ComboBox_CfgExposure2.Size = new System.Drawing.Size(62, 23);
            this.ComboBox_CfgExposure2.TabIndex = 20;
            this.ComboBox_CfgExposure2.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgExposure2.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgExposure2.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgExposure3
            // 
            this.ComboBox_CfgExposure3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgExposure3.FormattingEnabled = true;
            this.ComboBox_CfgExposure3.Location = new System.Drawing.Point(286, 206);
            this.ComboBox_CfgExposure3.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgExposure3.Name = "ComboBox_CfgExposure3";
            this.ComboBox_CfgExposure3.Size = new System.Drawing.Size(62, 23);
            this.ComboBox_CfgExposure3.TabIndex = 26;
            this.ComboBox_CfgExposure3.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgExposure3.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgExposure3.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgExposure4
            // 
            this.ComboBox_CfgExposure4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgExposure4.FormattingEnabled = true;
            this.ComboBox_CfgExposure4.Location = new System.Drawing.Point(348, 206);
            this.ComboBox_CfgExposure4.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgExposure4.Name = "ComboBox_CfgExposure4";
            this.ComboBox_CfgExposure4.Size = new System.Drawing.Size(62, 23);
            this.ComboBox_CfgExposure4.TabIndex = 32;
            this.ComboBox_CfgExposure4.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgExposure4.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgExposure4.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgExposure5
            // 
            this.ComboBox_CfgExposure5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgExposure5.FormattingEnabled = true;
            this.ComboBox_CfgExposure5.Location = new System.Drawing.Point(409, 206);
            this.ComboBox_CfgExposure5.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgExposure5.Name = "ComboBox_CfgExposure5";
            this.ComboBox_CfgExposure5.Size = new System.Drawing.Size(62, 23);
            this.ComboBox_CfgExposure5.TabIndex = 38;
            this.ComboBox_CfgExposure5.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgExposure5.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgExposure5.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgWidth1
            // 
            this.ComboBox_CfgWidth1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgWidth1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgWidth1.FormattingEnabled = true;
            this.ComboBox_CfgWidth1.Location = new System.Drawing.Point(164, 179);
            this.ComboBox_CfgWidth1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgWidth1.Name = "ComboBox_CfgWidth1";
            this.ComboBox_CfgWidth1.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgWidth1.TabIndex = 13;
            this.ComboBox_CfgWidth1.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgWidth1.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgWidth1.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgWidth2
            // 
            this.ComboBox_CfgWidth2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgWidth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgWidth2.FormattingEnabled = true;
            this.ComboBox_CfgWidth2.Location = new System.Drawing.Point(225, 179);
            this.ComboBox_CfgWidth2.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgWidth2.Name = "ComboBox_CfgWidth2";
            this.ComboBox_CfgWidth2.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgWidth2.TabIndex = 19;
            this.ComboBox_CfgWidth2.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgWidth2.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgWidth2.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgWidth3
            // 
            this.ComboBox_CfgWidth3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgWidth3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgWidth3.FormattingEnabled = true;
            this.ComboBox_CfgWidth3.Location = new System.Drawing.Point(286, 179);
            this.ComboBox_CfgWidth3.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgWidth3.Name = "ComboBox_CfgWidth3";
            this.ComboBox_CfgWidth3.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgWidth3.TabIndex = 25;
            this.ComboBox_CfgWidth3.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgWidth3.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgWidth3.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgWidth4
            // 
            this.ComboBox_CfgWidth4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgWidth4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgWidth4.FormattingEnabled = true;
            this.ComboBox_CfgWidth4.Location = new System.Drawing.Point(348, 179);
            this.ComboBox_CfgWidth4.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgWidth4.Name = "ComboBox_CfgWidth4";
            this.ComboBox_CfgWidth4.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgWidth4.TabIndex = 31;
            this.ComboBox_CfgWidth4.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgWidth4.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgWidth4.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgWidth5
            // 
            this.ComboBox_CfgWidth5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgWidth5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgWidth5.FormattingEnabled = true;
            this.ComboBox_CfgWidth5.Location = new System.Drawing.Point(409, 179);
            this.ComboBox_CfgWidth5.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgWidth5.Name = "ComboBox_CfgWidth5";
            this.ComboBox_CfgWidth5.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgWidth5.TabIndex = 37;
            this.ComboBox_CfgWidth5.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgWidth5.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgWidth5.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // TextBox_CfgRangeEnd1
            // 
            this.TextBox_CfgRangeEnd1.Location = new System.Drawing.Point(164, 151);
            this.TextBox_CfgRangeEnd1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeEnd1.Name = "TextBox_CfgRangeEnd1";
            this.TextBox_CfgRangeEnd1.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeEnd1.TabIndex = 12;
            this.TextBox_CfgRangeEnd1.Text = "1700";
            this.TextBox_CfgRangeEnd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeEnd1.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeEnd1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeEnd1.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeEnd1.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgRangeEnd2
            // 
            this.TextBox_CfgRangeEnd2.Location = new System.Drawing.Point(225, 151);
            this.TextBox_CfgRangeEnd2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeEnd2.Name = "TextBox_CfgRangeEnd2";
            this.TextBox_CfgRangeEnd2.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeEnd2.TabIndex = 18;
            this.TextBox_CfgRangeEnd2.Text = "1700";
            this.TextBox_CfgRangeEnd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeEnd2.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeEnd2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeEnd2.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeEnd2.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgRangeEnd3
            // 
            this.TextBox_CfgRangeEnd3.Location = new System.Drawing.Point(286, 151);
            this.TextBox_CfgRangeEnd3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeEnd3.Name = "TextBox_CfgRangeEnd3";
            this.TextBox_CfgRangeEnd3.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeEnd3.TabIndex = 24;
            this.TextBox_CfgRangeEnd3.Text = "1700";
            this.TextBox_CfgRangeEnd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeEnd3.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeEnd3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeEnd3.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeEnd3.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgRangeEnd4
            // 
            this.TextBox_CfgRangeEnd4.Location = new System.Drawing.Point(348, 151);
            this.TextBox_CfgRangeEnd4.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeEnd4.Name = "TextBox_CfgRangeEnd4";
            this.TextBox_CfgRangeEnd4.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeEnd4.TabIndex = 30;
            this.TextBox_CfgRangeEnd4.Text = "1700";
            this.TextBox_CfgRangeEnd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeEnd4.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeEnd4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeEnd4.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeEnd4.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgRangeEnd5
            // 
            this.TextBox_CfgRangeEnd5.Location = new System.Drawing.Point(409, 151);
            this.TextBox_CfgRangeEnd5.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeEnd5.Name = "TextBox_CfgRangeEnd5";
            this.TextBox_CfgRangeEnd5.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeEnd5.TabIndex = 36;
            this.TextBox_CfgRangeEnd5.Text = "1700";
            this.TextBox_CfgRangeEnd5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeEnd5.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeEnd5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeEnd5.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeEnd5.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgRangeStart1
            // 
            this.TextBox_CfgRangeStart1.Location = new System.Drawing.Point(164, 124);
            this.TextBox_CfgRangeStart1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeStart1.Name = "TextBox_CfgRangeStart1";
            this.TextBox_CfgRangeStart1.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeStart1.TabIndex = 11;
            this.TextBox_CfgRangeStart1.Text = "900";
            this.TextBox_CfgRangeStart1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeStart1.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeStart1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeStart1.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeStart1.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgRangeStart2
            // 
            this.TextBox_CfgRangeStart2.Location = new System.Drawing.Point(225, 124);
            this.TextBox_CfgRangeStart2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeStart2.Name = "TextBox_CfgRangeStart2";
            this.TextBox_CfgRangeStart2.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeStart2.TabIndex = 17;
            this.TextBox_CfgRangeStart2.Text = "900";
            this.TextBox_CfgRangeStart2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeStart2.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeStart2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeStart2.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeStart2.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgRangeStart3
            // 
            this.TextBox_CfgRangeStart3.Location = new System.Drawing.Point(286, 124);
            this.TextBox_CfgRangeStart3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeStart3.Name = "TextBox_CfgRangeStart3";
            this.TextBox_CfgRangeStart3.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeStart3.TabIndex = 23;
            this.TextBox_CfgRangeStart3.Text = "900";
            this.TextBox_CfgRangeStart3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeStart3.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeStart3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeStart3.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeStart3.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // TextBox_CfgRangeStart4
            // 
            this.TextBox_CfgRangeStart4.Location = new System.Drawing.Point(348, 124);
            this.TextBox_CfgRangeStart4.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeStart4.Name = "TextBox_CfgRangeStart4";
            this.TextBox_CfgRangeStart4.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeStart4.TabIndex = 29;
            this.TextBox_CfgRangeStart4.Text = "900";
            this.TextBox_CfgRangeStart4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeStart4.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeStart4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeStart4.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeStart4.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // ComboBox_CfgScanType1
            // 
            this.ComboBox_CfgScanType1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgScanType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgScanType1.FormattingEnabled = true;
            this.ComboBox_CfgScanType1.Location = new System.Drawing.Point(164, 96);
            this.ComboBox_CfgScanType1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgScanType1.Name = "ComboBox_CfgScanType1";
            this.ComboBox_CfgScanType1.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgScanType1.TabIndex = 10;
            this.ComboBox_CfgScanType1.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgScanType1.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgScanType1.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgScanType2
            // 
            this.ComboBox_CfgScanType2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgScanType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgScanType2.FormattingEnabled = true;
            this.ComboBox_CfgScanType2.Location = new System.Drawing.Point(225, 96);
            this.ComboBox_CfgScanType2.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgScanType2.Name = "ComboBox_CfgScanType2";
            this.ComboBox_CfgScanType2.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgScanType2.TabIndex = 16;
            this.ComboBox_CfgScanType2.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgScanType2.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgScanType2.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgScanType3
            // 
            this.ComboBox_CfgScanType3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgScanType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgScanType3.FormattingEnabled = true;
            this.ComboBox_CfgScanType3.Location = new System.Drawing.Point(286, 96);
            this.ComboBox_CfgScanType3.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgScanType3.Name = "ComboBox_CfgScanType3";
            this.ComboBox_CfgScanType3.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgScanType3.TabIndex = 22;
            this.ComboBox_CfgScanType3.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgScanType3.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgScanType3.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // ComboBox_CfgScanType4
            // 
            this.ComboBox_CfgScanType4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgScanType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgScanType4.FormattingEnabled = true;
            this.ComboBox_CfgScanType4.Location = new System.Drawing.Point(348, 96);
            this.ComboBox_CfgScanType4.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgScanType4.Name = "ComboBox_CfgScanType4";
            this.ComboBox_CfgScanType4.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgScanType4.TabIndex = 28;
            this.ComboBox_CfgScanType4.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgScanType4.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgScanType4.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // TextBox_CfgRangeStart5
            // 
            this.TextBox_CfgRangeStart5.Location = new System.Drawing.Point(409, 124);
            this.TextBox_CfgRangeStart5.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgRangeStart5.Name = "TextBox_CfgRangeStart5";
            this.TextBox_CfgRangeStart5.Size = new System.Drawing.Size(62, 24);
            this.TextBox_CfgRangeStart5.TabIndex = 35;
            this.TextBox_CfgRangeStart5.Text = "900";
            this.TextBox_CfgRangeStart5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgRangeStart5.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgRangeStart5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CfgDetails_KeyPressed);
            this.TextBox_CfgRangeStart5.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgRangeStart5.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // ComboBox_CfgScanType5
            // 
            this.ComboBox_CfgScanType5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_CfgScanType5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_CfgScanType5.FormattingEnabled = true;
            this.ComboBox_CfgScanType5.Location = new System.Drawing.Point(409, 96);
            this.ComboBox_CfgScanType5.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_CfgScanType5.Name = "ComboBox_CfgScanType5";
            this.ComboBox_CfgScanType5.Size = new System.Drawing.Size(62, 25);
            this.ComboBox_CfgScanType5.TabIndex = 34;
            this.ComboBox_CfgScanType5.SelectedIndexChanged += new System.EventHandler(this.CfgDetails_Validated);
            this.ComboBox_CfgScanType5.Enter += new System.EventHandler(this.CfgField_Enter);
            this.ComboBox_CfgScanType5.Leave += new System.EventHandler(this.CfgField_LostFocus);
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(8, 65);
            this.label87.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(84, 17);
            this.label87.TabIndex = 9;
            this.label87.Text = "Num Sections";
            // 
            // label86
            // 
            this.label86.Location = new System.Drawing.Point(171, 65);
            this.label86.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(49, 15);
            this.label86.TabIndex = 8;
            this.label86.Text = "1";
            this.label86.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label85
            // 
            this.label85.Location = new System.Drawing.Point(229, 65);
            this.label85.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(49, 15);
            this.label85.TabIndex = 7;
            this.label85.Text = "2";
            this.label85.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label84
            // 
            this.label84.Location = new System.Drawing.Point(290, 65);
            this.label84.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(49, 15);
            this.label84.TabIndex = 6;
            this.label84.Text = "3";
            this.label84.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label83
            // 
            this.label83.Location = new System.Drawing.Point(354, 65);
            this.label83.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(49, 15);
            this.label83.TabIndex = 5;
            this.label83.Text = "4";
            this.label83.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label82
            // 
            this.label82.Location = new System.Drawing.Point(414, 65);
            this.label82.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(49, 15);
            this.label82.TabIndex = 4;
            this.label82.Text = "5";
            this.label82.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox_CfgAvg
            // 
            this.TextBox_CfgAvg.Location = new System.Drawing.Point(409, 19);
            this.TextBox_CfgAvg.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgAvg.Name = "TextBox_CfgAvg";
            this.TextBox_CfgAvg.Size = new System.Drawing.Size(59, 24);
            this.TextBox_CfgAvg.TabIndex = 8;
            this.TextBox_CfgAvg.Text = "6";
            this.TextBox_CfgAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_CfgAvg.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgAvg.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgAvg.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(278, 22);
            this.label81.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(112, 17);
            this.label81.TabIndex = 2;
            this.label81.Text = "Num Scans to Avg.";
            // 
            // TextBox_CfgName
            // 
            this.TextBox_CfgName.Location = new System.Drawing.Point(64, 19);
            this.TextBox_CfgName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_CfgName.Name = "TextBox_CfgName";
            this.TextBox_CfgName.Size = new System.Drawing.Size(160, 24);
            this.TextBox_CfgName.TabIndex = 7;
            this.TextBox_CfgName.Text = "Config1";
            this.TextBox_CfgName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox_CfgName.Enter += new System.EventHandler(this.CfgField_Enter);
            this.TextBox_CfgName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TextBox_CfgName.Leave += new System.EventHandler(this.CfgField_LostFocus);
            this.TextBox_CfgName.Validated += new System.EventHandler(this.CfgDetails_Validated);
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(8, 22);
            this.label80.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(42, 17);
            this.label80.TabIndex = 0;
            this.label80.Text = "Name";
            // 
            // tabPage_SaveScans
            // 
            this.tabPage_SaveScans.Controls.Add(this.panel_Saved_Scan);
            this.tabPage_SaveScans.Location = new System.Drawing.Point(4, 24);
            this.tabPage_SaveScans.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_SaveScans.Name = "tabPage_SaveScans";
            this.tabPage_SaveScans.Size = new System.Drawing.Size(488, 766);
            this.tabPage_SaveScans.TabIndex = 2;
            this.tabPage_SaveScans.Text = "Saved Scans";
            this.tabPage_SaveScans.UseVisualStyleBackColor = true;
            // 
            // panel_Saved_Scan
            // 
            this.panel_Saved_Scan.Controls.Add(this.label2);
            this.panel_Saved_Scan.Controls.Add(this.btn_FileListRefresh);
            this.panel_Saved_Scan.Controls.Add(this.RadioButton_SavedScanSelDat);
            this.panel_Saved_Scan.Controls.Add(this.RadioButton_SavedScanSelCsv);
            this.panel_Saved_Scan.Controls.Add(this.totalScan);
            this.panel_Saved_Scan.Controls.Add(this.button_clear);
            this.panel_Saved_Scan.Controls.Add(this.textBox_filter);
            this.panel_Saved_Scan.Controls.Add(this.label13);
            this.panel_Saved_Scan.Controls.Add(this.dataGridView_savescan);
            this.panel_Saved_Scan.Controls.Add(this.label33);
            this.panel_Saved_Scan.Controls.Add(this.label30);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedAvg);
            this.panel_Saved_Scan.Controls.Add(this.label77);
            this.panel_Saved_Scan.Controls.Add(this.label76);
            this.panel_Saved_Scan.Controls.Add(this.label75);
            this.panel_Saved_Scan.Controls.Add(this.label74);
            this.panel_Saved_Scan.Controls.Add(this.label73);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedExposure1);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedExposure2);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedExposure3);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedExposure4);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedExposure5);
            this.panel_Saved_Scan.Controls.Add(this.label67);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedDigRes1);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedDigRes2);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedDigRes3);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedDigRes4);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedDigRes5);
            this.panel_Saved_Scan.Controls.Add(this.label61);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedWidth1);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedWidth2);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedWidth3);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedWidth4);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedWidth5);
            this.panel_Saved_Scan.Controls.Add(this.label55);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeEnd1);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeEnd2);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeEnd3);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeEnd4);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeEnd5);
            this.panel_Saved_Scan.Controls.Add(this.label49);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeStart1);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeStart2);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeStart3);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeStart4);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedRangeStart5);
            this.panel_Saved_Scan.Controls.Add(this.label43);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedScanType1);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedScanType2);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedScanType3);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedScanType4);
            this.panel_Saved_Scan.Controls.Add(this.Label_SavedScanType5);
            this.panel_Saved_Scan.Controls.Add(this.label37);
            this.panel_Saved_Scan.Controls.Add(this.label36);
            this.panel_Saved_Scan.Controls.Add(this.label35);
            this.panel_Saved_Scan.Controls.Add(this.Button_DisplayDirChange);
            this.panel_Saved_Scan.Controls.Add(this.TextBox_SavedFileDirPath);
            this.panel_Saved_Scan.Controls.Add(this.label79);
            this.panel_Saved_Scan.Location = new System.Drawing.Point(1, 1);
            this.panel_Saved_Scan.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Saved_Scan.Name = "panel_Saved_Scan";
            this.panel_Saved_Scan.Size = new System.Drawing.Size(490, 730);
            this.panel_Saved_Scan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "Folder :";
            // 
            // btn_FileListRefresh
            // 
            this.btn_FileListRefresh.Location = new System.Drawing.Point(421, 20);
            this.btn_FileListRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FileListRefresh.Name = "btn_FileListRefresh";
            this.btn_FileListRefresh.Size = new System.Drawing.Size(65, 29);
            this.btn_FileListRefresh.TabIndex = 112;
            this.btn_FileListRefresh.Text = "Refresh";
            this.btn_FileListRefresh.UseVisualStyleBackColor = true;
            this.btn_FileListRefresh.Click += new System.EventHandler(this.btn_FileListRefresh_Click);
            // 
            // RadioButton_SavedScanSelDat
            // 
            this.RadioButton_SavedScanSelDat.AutoSize = true;
            this.RadioButton_SavedScanSelDat.Location = new System.Drawing.Point(74, 445);
            this.RadioButton_SavedScanSelDat.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_SavedScanSelDat.Name = "RadioButton_SavedScanSelDat";
            this.RadioButton_SavedScanSelDat.Size = new System.Drawing.Size(59, 21);
            this.RadioButton_SavedScanSelDat.TabIndex = 111;
            this.RadioButton_SavedScanSelDat.TabStop = true;
            this.RadioButton_SavedScanSelDat.Text = "*.dat";
            this.RadioButton_SavedScanSelDat.UseVisualStyleBackColor = true;
            this.RadioButton_SavedScanSelDat.CheckedChanged += new System.EventHandler(this.RadioButton_SavedScanSelDat_CheckedChanged);
            // 
            // RadioButton_SavedScanSelCsv
            // 
            this.RadioButton_SavedScanSelCsv.AutoSize = true;
            this.RadioButton_SavedScanSelCsv.Location = new System.Drawing.Point(4, 445);
            this.RadioButton_SavedScanSelCsv.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButton_SavedScanSelCsv.Name = "RadioButton_SavedScanSelCsv";
            this.RadioButton_SavedScanSelCsv.Size = new System.Drawing.Size(57, 21);
            this.RadioButton_SavedScanSelCsv.TabIndex = 110;
            this.RadioButton_SavedScanSelCsv.TabStop = true;
            this.RadioButton_SavedScanSelCsv.Text = "*.csv";
            this.RadioButton_SavedScanSelCsv.UseVisualStyleBackColor = true;
            this.RadioButton_SavedScanSelCsv.CheckedChanged += new System.EventHandler(this.RadioButton_SavedScanSelCsv_CheckedChanged);
            // 
            // totalScan
            // 
            this.totalScan.Location = new System.Drawing.Point(364, 445);
            this.totalScan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalScan.Name = "totalScan";
            this.totalScan.Size = new System.Drawing.Size(122, 22);
            this.totalScan.TabIndex = 107;
            this.totalScan.Text = "Total: ";
            this.totalScan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(349, 54);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(65, 29);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_filter
            // 
            this.textBox_filter.Location = new System.Drawing.Point(60, 55);
            this.textBox_filter.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_filter.Name = "textBox_filter";
            this.textBox_filter.Size = new System.Drawing.Size(280, 24);
            this.textBox_filter.TabIndex = 3;
            this.textBox_filter.TextChanged += new System.EventHandler(this.textBox_filter_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 61);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 104;
            this.label13.Text = "Filter : ";
            // 
            // dataGridView_savescan
            // 
            this.dataGridView_savescan.AllowUserToAddRows = false;
            this.dataGridView_savescan.AllowUserToDeleteRows = false;
            this.dataGridView_savescan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_savescan.ColumnHeadersHeight = 29;
            this.dataGridView_savescan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_savescan.Location = new System.Drawing.Point(4, 90);
            this.dataGridView_savescan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_savescan.MultiSelect = false;
            this.dataGridView_savescan.Name = "dataGridView_savescan";
            this.dataGridView_savescan.ReadOnly = true;
            this.dataGridView_savescan.RowHeadersWidth = 25;
            this.dataGridView_savescan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_savescan.RowTemplate.Height = 24;
            this.dataGridView_savescan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_savescan.Size = new System.Drawing.Size(482, 348);
            this.dataGridView_savescan.TabIndex = 6;
            this.dataGridView_savescan.VirtualMode = true;
            this.dataGridView_savescan.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_savescan_ColumnHeaderMouseClick);
            this.dataGridView_savescan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_savescan_KeyDown);
            this.dataGridView_savescan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_savescan_MouseClick);
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(428, 484);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(49, 15);
            this.label33.TabIndex = 101;
            this.label33.Text = "5";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(360, 484);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 15);
            this.label30.TabIndex = 100;
            this.label30.Text = "4";
            this.label30.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedAvg
            // 
            this.Label_SavedAvg.Location = new System.Drawing.Point(158, 694);
            this.Label_SavedAvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedAvg.Name = "Label_SavedAvg";
            this.Label_SavedAvg.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedAvg.TabIndex = 98;
            this.Label_SavedAvg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label77
            // 
            this.label77.Location = new System.Drawing.Point(225, 694);
            this.label77.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(49, 15);
            this.label77.TabIndex = 97;
            this.label77.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label76
            // 
            this.label76.Location = new System.Drawing.Point(292, 692);
            this.label76.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(49, 15);
            this.label76.TabIndex = 96;
            this.label76.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label75
            // 
            this.label75.Location = new System.Drawing.Point(360, 692);
            this.label75.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(49, 15);
            this.label75.TabIndex = 95;
            this.label75.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label74
            // 
            this.label74.Location = new System.Drawing.Point(428, 692);
            this.label74.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(49, 15);
            this.label74.TabIndex = 94;
            this.label74.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(8, 662);
            this.label73.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(117, 17);
            this.label73.TabIndex = 93;
            this.label73.Text = "Exposure Time (ms)";
            // 
            // Label_SavedExposure1
            // 
            this.Label_SavedExposure1.Location = new System.Drawing.Point(158, 662);
            this.Label_SavedExposure1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedExposure1.Name = "Label_SavedExposure1";
            this.Label_SavedExposure1.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedExposure1.TabIndex = 92;
            this.Label_SavedExposure1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedExposure2
            // 
            this.Label_SavedExposure2.Location = new System.Drawing.Point(225, 662);
            this.Label_SavedExposure2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedExposure2.Name = "Label_SavedExposure2";
            this.Label_SavedExposure2.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedExposure2.TabIndex = 91;
            this.Label_SavedExposure2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedExposure3
            // 
            this.Label_SavedExposure3.Location = new System.Drawing.Point(292, 662);
            this.Label_SavedExposure3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedExposure3.Name = "Label_SavedExposure3";
            this.Label_SavedExposure3.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedExposure3.TabIndex = 90;
            this.Label_SavedExposure3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedExposure4
            // 
            this.Label_SavedExposure4.Location = new System.Drawing.Point(360, 662);
            this.Label_SavedExposure4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedExposure4.Name = "Label_SavedExposure4";
            this.Label_SavedExposure4.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedExposure4.TabIndex = 89;
            this.Label_SavedExposure4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedExposure5
            // 
            this.Label_SavedExposure5.Location = new System.Drawing.Point(428, 662);
            this.Label_SavedExposure5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedExposure5.Name = "Label_SavedExposure5";
            this.Label_SavedExposure5.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedExposure5.TabIndex = 88;
            this.Label_SavedExposure5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(8, 632);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(107, 17);
            this.label67.TabIndex = 87;
            this.label67.Text = "Digital Resolution";
            // 
            // Label_SavedDigRes1
            // 
            this.Label_SavedDigRes1.Location = new System.Drawing.Point(158, 632);
            this.Label_SavedDigRes1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedDigRes1.Name = "Label_SavedDigRes1";
            this.Label_SavedDigRes1.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedDigRes1.TabIndex = 86;
            this.Label_SavedDigRes1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedDigRes2
            // 
            this.Label_SavedDigRes2.Location = new System.Drawing.Point(225, 632);
            this.Label_SavedDigRes2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedDigRes2.Name = "Label_SavedDigRes2";
            this.Label_SavedDigRes2.Size = new System.Drawing.Size(49, 18);
            this.Label_SavedDigRes2.TabIndex = 85;
            this.Label_SavedDigRes2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedDigRes3
            // 
            this.Label_SavedDigRes3.Location = new System.Drawing.Point(292, 632);
            this.Label_SavedDigRes3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedDigRes3.Name = "Label_SavedDigRes3";
            this.Label_SavedDigRes3.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedDigRes3.TabIndex = 84;
            this.Label_SavedDigRes3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedDigRes4
            // 
            this.Label_SavedDigRes4.Location = new System.Drawing.Point(360, 632);
            this.Label_SavedDigRes4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedDigRes4.Name = "Label_SavedDigRes4";
            this.Label_SavedDigRes4.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedDigRes4.TabIndex = 83;
            this.Label_SavedDigRes4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedDigRes5
            // 
            this.Label_SavedDigRes5.Location = new System.Drawing.Point(428, 632);
            this.Label_SavedDigRes5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedDigRes5.Name = "Label_SavedDigRes5";
            this.Label_SavedDigRes5.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedDigRes5.TabIndex = 82;
            this.Label_SavedDigRes5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(8, 602);
            this.label61.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(71, 17);
            this.label61.TabIndex = 81;
            this.label61.Text = "Width (nm)";
            // 
            // Label_SavedWidth1
            // 
            this.Label_SavedWidth1.Location = new System.Drawing.Point(158, 602);
            this.Label_SavedWidth1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedWidth1.Name = "Label_SavedWidth1";
            this.Label_SavedWidth1.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedWidth1.TabIndex = 80;
            this.Label_SavedWidth1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedWidth2
            // 
            this.Label_SavedWidth2.Location = new System.Drawing.Point(225, 602);
            this.Label_SavedWidth2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedWidth2.Name = "Label_SavedWidth2";
            this.Label_SavedWidth2.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedWidth2.TabIndex = 79;
            this.Label_SavedWidth2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedWidth3
            // 
            this.Label_SavedWidth3.Location = new System.Drawing.Point(292, 602);
            this.Label_SavedWidth3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedWidth3.Name = "Label_SavedWidth3";
            this.Label_SavedWidth3.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedWidth3.TabIndex = 78;
            this.Label_SavedWidth3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedWidth4
            // 
            this.Label_SavedWidth4.Location = new System.Drawing.Point(360, 602);
            this.Label_SavedWidth4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedWidth4.Name = "Label_SavedWidth4";
            this.Label_SavedWidth4.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedWidth4.TabIndex = 77;
            this.Label_SavedWidth4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedWidth5
            // 
            this.Label_SavedWidth5.Location = new System.Drawing.Point(428, 602);
            this.Label_SavedWidth5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedWidth5.Name = "Label_SavedWidth5";
            this.Label_SavedWidth5.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedWidth5.TabIndex = 76;
            this.Label_SavedWidth5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(8, 572);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(117, 17);
            this.label55.TabIndex = 75;
            this.label55.Text = "Spectral Range End";
            // 
            // Label_SavedRangeEnd1
            // 
            this.Label_SavedRangeEnd1.Location = new System.Drawing.Point(158, 572);
            this.Label_SavedRangeEnd1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeEnd1.Name = "Label_SavedRangeEnd1";
            this.Label_SavedRangeEnd1.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeEnd1.TabIndex = 74;
            this.Label_SavedRangeEnd1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedRangeEnd2
            // 
            this.Label_SavedRangeEnd2.Location = new System.Drawing.Point(225, 572);
            this.Label_SavedRangeEnd2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeEnd2.Name = "Label_SavedRangeEnd2";
            this.Label_SavedRangeEnd2.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeEnd2.TabIndex = 73;
            this.Label_SavedRangeEnd2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedRangeEnd3
            // 
            this.Label_SavedRangeEnd3.Location = new System.Drawing.Point(292, 572);
            this.Label_SavedRangeEnd3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeEnd3.Name = "Label_SavedRangeEnd3";
            this.Label_SavedRangeEnd3.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeEnd3.TabIndex = 72;
            this.Label_SavedRangeEnd3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedRangeEnd4
            // 
            this.Label_SavedRangeEnd4.Location = new System.Drawing.Point(360, 572);
            this.Label_SavedRangeEnd4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeEnd4.Name = "Label_SavedRangeEnd4";
            this.Label_SavedRangeEnd4.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeEnd4.TabIndex = 71;
            this.Label_SavedRangeEnd4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedRangeEnd5
            // 
            this.Label_SavedRangeEnd5.Location = new System.Drawing.Point(428, 572);
            this.Label_SavedRangeEnd5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeEnd5.Name = "Label_SavedRangeEnd5";
            this.Label_SavedRangeEnd5.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeEnd5.TabIndex = 70;
            this.Label_SavedRangeEnd5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(8, 542);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(124, 17);
            this.label49.TabIndex = 69;
            this.label49.Text = "Spectral Range Start";
            // 
            // Label_SavedRangeStart1
            // 
            this.Label_SavedRangeStart1.Location = new System.Drawing.Point(158, 542);
            this.Label_SavedRangeStart1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeStart1.Name = "Label_SavedRangeStart1";
            this.Label_SavedRangeStart1.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeStart1.TabIndex = 68;
            this.Label_SavedRangeStart1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedRangeStart2
            // 
            this.Label_SavedRangeStart2.Location = new System.Drawing.Point(225, 542);
            this.Label_SavedRangeStart2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeStart2.Name = "Label_SavedRangeStart2";
            this.Label_SavedRangeStart2.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeStart2.TabIndex = 67;
            this.Label_SavedRangeStart2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedRangeStart3
            // 
            this.Label_SavedRangeStart3.Location = new System.Drawing.Point(292, 542);
            this.Label_SavedRangeStart3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeStart3.Name = "Label_SavedRangeStart3";
            this.Label_SavedRangeStart3.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeStart3.TabIndex = 66;
            this.Label_SavedRangeStart3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedRangeStart4
            // 
            this.Label_SavedRangeStart4.Location = new System.Drawing.Point(360, 542);
            this.Label_SavedRangeStart4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeStart4.Name = "Label_SavedRangeStart4";
            this.Label_SavedRangeStart4.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeStart4.TabIndex = 65;
            this.Label_SavedRangeStart4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedRangeStart5
            // 
            this.Label_SavedRangeStart5.Location = new System.Drawing.Point(428, 542);
            this.Label_SavedRangeStart5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedRangeStart5.Name = "Label_SavedRangeStart5";
            this.Label_SavedRangeStart5.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedRangeStart5.TabIndex = 64;
            this.Label_SavedRangeStart5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(8, 512);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(63, 17);
            this.label43.TabIndex = 63;
            this.label43.Text = "Scan Type";
            // 
            // Label_SavedScanType1
            // 
            this.Label_SavedScanType1.Location = new System.Drawing.Point(158, 512);
            this.Label_SavedScanType1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedScanType1.Name = "Label_SavedScanType1";
            this.Label_SavedScanType1.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedScanType1.TabIndex = 62;
            this.Label_SavedScanType1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedScanType2
            // 
            this.Label_SavedScanType2.Location = new System.Drawing.Point(225, 512);
            this.Label_SavedScanType2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedScanType2.Name = "Label_SavedScanType2";
            this.Label_SavedScanType2.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedScanType2.TabIndex = 61;
            this.Label_SavedScanType2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedScanType3
            // 
            this.Label_SavedScanType3.Location = new System.Drawing.Point(292, 512);
            this.Label_SavedScanType3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedScanType3.Name = "Label_SavedScanType3";
            this.Label_SavedScanType3.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedScanType3.TabIndex = 60;
            this.Label_SavedScanType3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedScanType4
            // 
            this.Label_SavedScanType4.Location = new System.Drawing.Point(360, 512);
            this.Label_SavedScanType4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedScanType4.Name = "Label_SavedScanType4";
            this.Label_SavedScanType4.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedScanType4.TabIndex = 59;
            this.Label_SavedScanType4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_SavedScanType5
            // 
            this.Label_SavedScanType5.Location = new System.Drawing.Point(428, 512);
            this.Label_SavedScanType5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_SavedScanType5.Name = "Label_SavedScanType5";
            this.Label_SavedScanType5.Size = new System.Drawing.Size(49, 15);
            this.Label_SavedScanType5.TabIndex = 58;
            this.Label_SavedScanType5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(158, 484);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(49, 15);
            this.label37.TabIndex = 57;
            this.label37.Text = "1";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(225, 484);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(49, 15);
            this.label36.TabIndex = 56;
            this.label36.Text = "2";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(292, 484);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 15);
            this.label35.TabIndex = 55;
            this.label35.Text = "3";
            this.label35.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button_DisplayDirChange
            // 
            this.Button_DisplayDirChange.Location = new System.Drawing.Point(348, 21);
            this.Button_DisplayDirChange.Margin = new System.Windows.Forms.Padding(4);
            this.Button_DisplayDirChange.Name = "Button_DisplayDirChange";
            this.Button_DisplayDirChange.Size = new System.Drawing.Size(66, 29);
            this.Button_DisplayDirChange.TabIndex = 2;
            this.Button_DisplayDirChange.Text = "Browse";
            this.Button_DisplayDirChange.UseVisualStyleBackColor = true;
            this.Button_DisplayDirChange.Click += new System.EventHandler(this.Button_DisplayDirChange_Click);
            // 
            // TextBox_SavedFileDirPath
            // 
            this.TextBox_SavedFileDirPath.Location = new System.Drawing.Point(60, 21);
            this.TextBox_SavedFileDirPath.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_SavedFileDirPath.Name = "TextBox_SavedFileDirPath";
            this.TextBox_SavedFileDirPath.ReadOnly = true;
            this.TextBox_SavedFileDirPath.Size = new System.Drawing.Size(279, 24);
            this.TextBox_SavedFileDirPath.TabIndex = 1;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(8, 694);
            this.label79.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(112, 17);
            this.label79.TabIndex = 99;
            this.label79.Text = "Num Scans to Avg.";
            // 
            // tabPage_PickTable
            // 
            this.tabPage_PickTable.Controls.Add(this.button_Home);
            this.tabPage_PickTable.Controls.Add(this.button_TestSequence);
            this.tabPage_PickTable.Controls.Add(this.dataGridView_Table);
            this.tabPage_PickTable.Location = new System.Drawing.Point(4, 24);
            this.tabPage_PickTable.Name = "tabPage_PickTable";
            this.tabPage_PickTable.Size = new System.Drawing.Size(488, 766);
            this.tabPage_PickTable.TabIndex = 4;
            this.tabPage_PickTable.Text = "Table";
            this.tabPage_PickTable.UseVisualStyleBackColor = true;
            // 
            // button_Home
            // 
            this.button_Home.Location = new System.Drawing.Point(22, 703);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(114, 49);
            this.button_Home.TabIndex = 2;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // button_TestSequence
            // 
            this.button_TestSequence.Location = new System.Drawing.Point(213, 586);
            this.button_TestSequence.Name = "button_TestSequence";
            this.button_TestSequence.Size = new System.Drawing.Size(83, 33);
            this.button_TestSequence.TabIndex = 1;
            this.button_TestSequence.Text = "Run";
            this.button_TestSequence.UseVisualStyleBackColor = true;
            this.button_TestSequence.Click += new System.EventHandler(this.button_TestSequence_Click);
            // 
            // dataGridView_Table
            // 
            this.dataGridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Table.Location = new System.Drawing.Point(22, 12);
            this.dataGridView_Table.Name = "dataGridView_Table";
            this.dataGridView_Table.RowHeadersWidth = 51;
            this.dataGridView_Table.RowTemplate.Height = 24;
            this.dataGridView_Table.Size = new System.Drawing.Size(450, 568);
            this.dataGridView_Table.TabIndex = 0;
            // 
            // tabPage_ChemicalImage
            // 
            this.tabPage_ChemicalImage.Controls.Add(this.label_CI);
            this.tabPage_ChemicalImage.Controls.Add(this.pictureBox_heatMap);
            this.tabPage_ChemicalImage.Location = new System.Drawing.Point(4, 24);
            this.tabPage_ChemicalImage.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_ChemicalImage.Name = "tabPage_ChemicalImage";
            this.tabPage_ChemicalImage.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_ChemicalImage.Size = new System.Drawing.Size(488, 766);
            this.tabPage_ChemicalImage.TabIndex = 0;
            this.tabPage_ChemicalImage.Text = "Chemical Image";
            this.tabPage_ChemicalImage.UseVisualStyleBackColor = true;
            // 
            // label_CI
            // 
            this.label_CI.AutoSize = true;
            this.label_CI.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CI.Location = new System.Drawing.Point(190, 20);
            this.label_CI.Name = "label_CI";
            this.label_CI.Size = new System.Drawing.Size(131, 23);
            this.label_CI.TabIndex = 10;
            this.label_CI.Text = "Chemical Image";
            // 
            // pictureBox_heatMap
            // 
            this.pictureBox_heatMap.Location = new System.Drawing.Point(7, 50);
            this.pictureBox_heatMap.Name = "pictureBox_heatMap";
            this.pictureBox_heatMap.Size = new System.Drawing.Size(478, 307);
            this.pictureBox_heatMap.TabIndex = 9;
            this.pictureBox_heatMap.TabStop = false;
            // 
            // checkBox_tooltip
            // 
            this.checkBox_tooltip.Location = new System.Drawing.Point(0, 0);
            this.checkBox_tooltip.Name = "checkBox_tooltip";
            this.checkBox_tooltip.Size = new System.Drawing.Size(104, 24);
            this.checkBox_tooltip.TabIndex = 0;
            // 
            // tabControl_MainFunctions
            // 
            this.tabControl_MainFunctions.Controls.Add(this.tabPage_Scan);
            this.tabControl_MainFunctions.Controls.Add(this.tabPage_PosData);
            this.tabControl_MainFunctions.Controls.Add(this.tabPage_Utility);
            this.tabControl_MainFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_MainFunctions.Location = new System.Drawing.Point(0, 0);
            this.tabControl_MainFunctions.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_MainFunctions.Name = "tabControl_MainFunctions";
            this.tabControl_MainFunctions.SelectedIndex = 0;
            this.tabControl_MainFunctions.Size = new System.Drawing.Size(1578, 808);
            this.tabControl_MainFunctions.TabIndex = 2;
            this.tabControl_MainFunctions.SelectedIndexChanged += new System.EventHandler(this.tabControl_MainFunctions_SelectedIndexChanged);
            this.tabControl_MainFunctions.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabPage_Selecting);
            this.tabControl_MainFunctions.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabPage_Deselecting);
            // 
            // tabPage_PosData
            // 
            this.tabPage_PosData.Controls.Add(this.splitContainer2);
            this.tabPage_PosData.Location = new System.Drawing.Point(4, 24);
            this.tabPage_PosData.Name = "tabPage_PosData";
            this.tabPage_PosData.Size = new System.Drawing.Size(1570, 780);
            this.tabPage_PosData.TabIndex = 2;
            this.tabPage_PosData.Text = "Processed Data";
            this.tabPage_PosData.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox_BestModel);
            this.splitContainer2.Panel1.Controls.Add(this.btnTrain);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_Subtype);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_Material);
            this.splitContainer2.Panel1.Controls.Add(this.labelModelingMaterial);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelPredictions);
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_Predicitons);
            this.splitContainer2.Size = new System.Drawing.Size(1570, 780);
            this.splitContainer2.SplitterDistance = 818;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox_Subtype
            // 
            this.textBox_Subtype.Location = new System.Drawing.Point(132, 82);
            this.textBox_Subtype.Name = "textBox_Subtype";
            this.textBox_Subtype.Size = new System.Drawing.Size(168, 24);
            this.textBox_Subtype.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Subtype :";
            // 
            // textBox_Material
            // 
            this.textBox_Material.Location = new System.Drawing.Point(132, 39);
            this.textBox_Material.Name = "textBox_Material";
            this.textBox_Material.Size = new System.Drawing.Size(168, 24);
            this.textBox_Material.TabIndex = 3;
            // 
            // labelModelingMaterial
            // 
            this.labelModelingMaterial.AutoSize = true;
            this.labelModelingMaterial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelingMaterial.Location = new System.Drawing.Point(32, 38);
            this.labelModelingMaterial.Name = "labelModelingMaterial";
            this.labelModelingMaterial.Size = new System.Drawing.Size(91, 24);
            this.labelModelingMaterial.TabIndex = 2;
            this.labelModelingMaterial.Text = "Material :";
            // 
            // labelPredictions
            // 
            this.labelPredictions.AutoSize = true;
            this.labelPredictions.Location = new System.Drawing.Point(321, 42);
            this.labelPredictions.Name = "labelPredictions";
            this.labelPredictions.Size = new System.Drawing.Size(70, 17);
            this.labelPredictions.TabIndex = 3;
            this.labelPredictions.Text = "Predictions";
            // 
            // dataGridView_Predicitons
            // 
            this.dataGridView_Predicitons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Predicitons.Location = new System.Drawing.Point(243, 93);
            this.dataGridView_Predicitons.Name = "dataGridView_Predicitons";
            this.dataGridView_Predicitons.RowHeadersWidth = 51;
            this.dataGridView_Predicitons.RowTemplate.Height = 24;
            this.dataGridView_Predicitons.Size = new System.Drawing.Size(240, 568);
            this.dataGridView_Predicitons.TabIndex = 0;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(432, 42);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(149, 67);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Train Model";
            this.btnTrain.UseVisualStyleBackColor = true;
            // 
            // pictureBox_BestModel
            // 
            this.pictureBox_BestModel.Location = new System.Drawing.Point(36, 144);
            this.pictureBox_BestModel.Name = "pictureBox_BestModel";
            this.pictureBox_BestModel.Size = new System.Drawing.Size(764, 499);
            this.pictureBox_BestModel.TabIndex = 7;
            this.pictureBox_BestModel.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1262, 679);
            this.Controls.Add(this.label_ErrorStatus);
            this.Controls.Add(this.tabControl_MainFunctions);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1596, 896);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.GroupBox_ScanAvg.ResumeLayout(false);
            this.GroupBox_ScanAvg.PerformLayout();
            this.tabPage_Utility.ResumeLayout(false);
            this.GroupBox_LogFile.ResumeLayout(false);
            this.GroupBox_LogFile.PerformLayout();
            this.GroupBox_BleName.ResumeLayout(false);
            this.GroupBox_BleName.PerformLayout();
            this.groupBox_Device.ResumeLayout(false);
            this.groupBox_Device.PerformLayout();
            this.groupBox_ActivationKey.ResumeLayout(false);
            this.groupBox_ActivationKey.PerformLayout();
            this.groupBox_DevInfo.ResumeLayout(false);
            this.groupBox_DevInfo.PerformLayout();
            this.GroupBox_CalibCoeffs.ResumeLayout(false);
            this.GroupBox_CalibCoeffs.PerformLayout();
            this.GroupBox_Sensors.ResumeLayout(false);
            this.GroupBox_Sensors.PerformLayout();
            this.GroupBox_DateTime.ResumeLayout(false);
            this.GroupBox_DateTime.PerformLayout();
            this.GroupBox_LampUsage.ResumeLayout(false);
            this.GroupBox_LampUsage.PerformLayout();
            this.GroupBox_DLPC150FWUpdate.ResumeLayout(false);
            this.GroupBox_DLPC150FWUpdate.PerformLayout();
            this.GroupBox_TivaFWUpdate.ResumeLayout(false);
            this.GroupBox_TivaFWUpdate.PerformLayout();
            this.GroupBox_SerialNumber.ResumeLayout(false);
            this.GroupBox_SerialNumber.PerformLayout();
            this.GroupBox_ModelName.ResumeLayout(false);
            this.GroupBox_ModelName.PerformLayout();
            this.tabPage_Scan.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabScanPositions.ResumeLayout(false);
            this.tabPage_SavePositions.ResumeLayout(false);
            this.tabPage_SavePositions.PerformLayout();
            this.GroupBox_GainControl.ResumeLayout(false);
            this.GroupBox_GainControl.PerformLayout();
            this.GroupBox_SaveScan.ResumeLayout(false);
            this.GroupBox_SaveScan.PerformLayout();
            this.GroupBox_LampControl.ResumeLayout(false);
            this.GroupBox_LampControl.PerformLayout();
            this.groupBox_Display.ResumeLayout(false);
            this.groupBox_plate4.ResumeLayout(false);
            this.groupBox_plate4.PerformLayout();
            this.groupBox_plate3.ResumeLayout(false);
            this.groupBox_plate3.PerformLayout();
            this.groupBox_plate2.ResumeLayout(false);
            this.groupBox_plate2.PerformLayout();
            this.groupBox_plate1.ResumeLayout(false);
            this.groupBox_plate1.PerformLayout();
            this.tabPage_ScanConfig.ResumeLayout(false);
            this.tabPage_ScanConfig.PerformLayout();
            this.GroupBox_CfgDetails.ResumeLayout(false);
            this.GroupBox_CfgDetails.PerformLayout();
            this.tabPage_SaveScans.ResumeLayout(false);
            this.panel_Saved_Scan.ResumeLayout(false);
            this.panel_Saved_Scan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_savescan)).EndInit();
            this.tabPage_PickTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).EndInit();
            this.tabPage_ChemicalImage.ResumeLayout(false);
            this.tabPage_ChemicalImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_heatMap)).EndInit();
            this.tabControl_MainFunctions.ResumeLayout(false);
            this.tabPage_PosData.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Predicitons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BestModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_DeviceStatus;
        private Label label_ErrorStatus;
        private ToolTip toolTip1;
        private Timer timer_AutoClickScanButton;
        private TabPage tabPage_Utility;
        private GroupBox GroupBox_LogFile;
        private Button Button_DisableLog;
        private Button Button_EnableLog;
        private Label Label_LogStatus;
        private GroupBox GroupBox_BleName;
        private Button Button_Get_BLE_Display_Name;
        private Button Button_Set_BLE_Display_Name;
        private Button Button_Clear_BLE_Display_Name;
        private TextBox TextBox_BLE_Display_Name;
        private GroupBox groupBox_Device;
        private Button button_SwitchDevice;
        private TextBox textBox_FanOffTime;
        private Button Button_GetFanDelayOffTime;
        private Button Button_SetFanDelayOffTime;
        private Label label_FanOffTimeSetting;
        private Button button_restore_fac_ref_warning;
        private Button Button_LockButton;
        private Label Label_ButtonStatus;
        private Button Button_UnlockButton;
        private Button button_DeviceRestoreFacRef;
        private Label label_RestoreFacRef;
        private Button button_DeviceUpdateRef;
        private Label label119;
        private Button button_DeviceResetSys;
        private Label label118;
        private GroupBox groupBox_ActivationKey;
        private Label label_ActivateStatus;
        private Label Status;
        private Button button_KeySet;
        private TextBox TextBox_Key;
        private Label label117;
        private GroupBox groupBox_DevInfo;
        private Label Label_BleNameValue;
        private Label Label_Blename;
        private Label label_DevInfoLampUsageValue;
        private Label label_DevInfoLampUsage;
        private Label label_DevInfoUUID;
        private Label label114;
        private Label label_DevInfoManfacSerNum;
        private Label label_MFC_Seri_Num;
        private Label label_DevInfoDevSerNum;
        private Label label104;
        private Label label_DevInfoModelName;
        private Label label106;
        private Label label_DevInfoDetectorBoardVer;
        private Label label108;
        private Label label_DevInfoMainBoardVer;
        private Label label110;
        private Label label_DevInfoDLPCVer;
        private Label label102;
        private Label label_DevInfoTivaSWVer;
        private Label label98;
        private Label label_DevInfoGUIVer;
        private Label label95;
        private GroupBox GroupBox_CalibCoeffs;
        private Button Button_Cal_WriteCoeffs;
        private Button Button_Cal_ReadCoeffs;
        private Button Button_Cal_RestoreDefaultCoeffs;
        private Button Button_Cal_WriteGenCoeffs;
        private CheckBox CheckBox_Cal_WriteEnable;
        private TextBox TextBox_ShiftVectCoeff2;
        private Label label28;
        private TextBox TextBox_ShiftVectCoeff1;
        private Label label31;
        private TextBox TextBox_ShiftVectCoeff0;
        private Label label22;
        private TextBox TextBox_P2WCoeff2;
        private Label label25;
        private Label Label_ScanCfgVer;
        private Label label27;
        private TextBox TextBox_P2WCoeff1;
        private Label label19;
        private Label Label_RefCalVer;
        private Label label21;
        private TextBox TextBox_P2WCoeff0;
        private Label label23;
        private Label Label_CalCoeffVer;
        private Label label29;
        private GroupBox GroupBox_Sensors;
        private Button Button_SensorRead;
        private Label Label_SensorLampCM2Value;
        private Label Label_SensorLampCM1Value;
        private Label Label_SensorLampVM2Value;
        private Label Label_SensorLampVM1Value;
        private Label Label_SensorTivaTemp;
        private Label Label_SensorSysTemp;
        private Label Label_SensorHumidity;
        private Label Label_SensorBattCapacity;
        private Label Label_SensorBattStatus;
        private Label Label_SensorLampCM2;
        private Label Label_SensorLampCM1;
        private Label Label_SensorLampVM2;
        private Label Label_SensorLampVM1;
        private Label label8;
        private Label label5;
        private Label label_sys_humidity;
        private Label lb_BattCapTitle;
        private Label lb_BattChargerStatusTitle;
        private GroupBox GroupBox_DateTime;
        private Button Button_DateTimeGet;
        private Button Button_DateTimeSync;
        private TextBox TextBox_DateTime;
        private GroupBox GroupBox_LampUsage;
        private Label label4;
        private Button Button_LampUsageGet;
        private Button Button_LampUsageSet;
        private TextBox TextBox_LampUsage;
        private GroupBox GroupBox_DLPC150FWUpdate;
        private Button Button_DLPC150FWUpdate;
        private System.Windows.Forms.ProgressBar ProgressBar_DLPC150FWUpdateStatus;
        private Button Button_DLPC150FWBrowse;
        private TextBox TextBox_DLPC150FWPath;
        private Label label9;
        private GroupBox GroupBox_TivaFWUpdate;
        private Button Button_TivaFWUpdate;
        private System.Windows.Forms.ProgressBar ProgressBar_TivaFWUpdateStatus;
        private Button Button_TivaFWBrowse;
        private TextBox TextBox_TivaFWPath;
        private Label Label_TivaFWName;
        private GroupBox GroupBox_SerialNumber;
        private Button Button_SerialNumberGet;
        private Button Button_SerialNumberSet;
        private TextBox TextBox_SerialNumber;
        private GroupBox GroupBox_ModelName;
        private Button Button_ModelNameGet;
        private Button Button_ModelNameSet;
        private TextBox TextBox_ModelName;
        private TabPage tabPage_Scan;
        private TabControl tabScanPositions;
        private TabPage tabPage_SavePositions;
        private Button button_Undo;
        private Button button_Save;
        private ComboBox comboBox_COMport;
        private Label label_usb;
        private GroupBox groupBox_Display;
        private GroupBox groupBox_plate4;
        private CheckBox checkBox_Pos24;
        private CheckBox checkBox_Pos22;
        private CheckBox checkBox_Pos23;
        private CheckBox checkBox_Pos21;
        private CheckBox checkBox_Pos19;
        private CheckBox checkBox_Pos20;
        private GroupBox groupBox_plate3;
        private CheckBox checkBox_Pos18;
        private CheckBox checkBox_Pos16;
        private CheckBox checkBox_Pos17;
        private CheckBox checkBox_Pos15;
        private CheckBox checkBox_Pos13;
        private CheckBox checkBox_Pos14;
        private GroupBox groupBox_plate2;
        private CheckBox checkBox_Pos12;
        private CheckBox checkBox_Pos10;
        private CheckBox checkBox_Pos11;
        private CheckBox checkBox_Pos9;
        private CheckBox checkBox_Pos7;
        private CheckBox checkBox_Pos8;
        private GroupBox groupBox_plate1;
        private CheckBox checkBox_Pos6;
        private CheckBox checkBox_Pos4;
        private CheckBox checkBox_Pos5;
        private CheckBox checkBox_Pos3;
        private CheckBox checkBox_Pos1;
        private CheckBox checkBox_Pos2;
        private TabPage tabPage_ChemicalImage;
        private TabPage tabPage_ScanConfig;
        private Label label16;
        private Label label15;
        private Button Button_MoveCfgT2L;
        private Button Button_MoveCfgL2T;
        private Button Button_CopyCfgT2L;
        private Button Button_CopyCfgL2T;
        private ListBox ListBox_LocalCfgs;
        private Label label_ActiveConfig;
        private ListBox ListBox_TargetCfgs;
        private Button Button_SetActive;
        private Label label94;
        private Button Button_CfgCancel;
        private Button Button_CfgSave;
        private Button Button_CfgDelete;
        private Button Button_CfgEdit;
        private Button Button_CfgNew;
        private GroupBox GroupBox_CfgDetails;
        private Label label_overSampleRate5;
        private Label label_overSampleRate4;
        private Label label_overSampleRate3;
        private Label label_overSampleRate2;
        private Label label_overSampleRate1;
        private Label label14;
        private MyComboBox comboBox_cfgNumSec;
        private Label label93;
        private Label label92;
        private Label label91;
        private Label label90;
        private Label label89;
        private Label label88;
        private TextBox TextBox_CfgDigRes1;
        private TextBox TextBox_CfgDigRes2;
        private TextBox TextBox_CfgDigRes3;
        private TextBox TextBox_CfgDigRes4;
        private TextBox TextBox_CfgDigRes5;
        private ComboBox ComboBox_CfgExposure1;
        private ComboBox ComboBox_CfgExposure2;
        private ComboBox ComboBox_CfgExposure3;
        private ComboBox ComboBox_CfgExposure4;
        private ComboBox ComboBox_CfgExposure5;
        private MyComboBox ComboBox_CfgWidth1;
        private MyComboBox ComboBox_CfgWidth2;
        private MyComboBox ComboBox_CfgWidth3;
        private MyComboBox ComboBox_CfgWidth4;
        private MyComboBox ComboBox_CfgWidth5;
        private TextBox TextBox_CfgRangeEnd1;
        private TextBox TextBox_CfgRangeEnd2;
        private TextBox TextBox_CfgRangeEnd3;
        private TextBox TextBox_CfgRangeEnd4;
        private TextBox TextBox_CfgRangeEnd5;
        private TextBox TextBox_CfgRangeStart1;
        private TextBox TextBox_CfgRangeStart2;
        private TextBox TextBox_CfgRangeStart3;
        private TextBox TextBox_CfgRangeStart4;
        private MyComboBox ComboBox_CfgScanType1;
        private MyComboBox ComboBox_CfgScanType2;
        private MyComboBox ComboBox_CfgScanType3;
        private MyComboBox ComboBox_CfgScanType4;
        private TextBox TextBox_CfgRangeStart5;
        private MyComboBox ComboBox_CfgScanType5;
        private Label label87;
        private Label label86;
        private Label label85;
        private Label label84;
        private Label label83;
        private Label label82;
        private TextBox TextBox_CfgAvg;
        private Label label81;
        private TextBox TextBox_CfgName;
        private Label label80;
        private TabPage tabPage_SaveScans;
        private Panel panel_Saved_Scan;
        private Label label2;
        private Button btn_FileListRefresh;
        private RadioButton RadioButton_SavedScanSelDat;
        private RadioButton RadioButton_SavedScanSelCsv;
        private Label totalScan;
        private Button button_clear;
        private TextBox textBox_filter;
        private Label label13;
        private DataGridView dataGridView_savescan;
        private Label label33;
        private Label label30;
        private Label Label_SavedAvg;
        private Label label77;
        private Label label76;
        private Label label75;
        private Label label74;
        private Label label73;
        private Label Label_SavedExposure1;
        private Label Label_SavedExposure2;
        private Label Label_SavedExposure3;
        private Label Label_SavedExposure4;
        private Label Label_SavedExposure5;
        private Label label67;
        private Label Label_SavedDigRes1;
        private Label Label_SavedDigRes2;
        private Label Label_SavedDigRes3;
        private Label Label_SavedDigRes4;
        private Label Label_SavedDigRes5;
        private Label label61;
        private Label Label_SavedWidth1;
        private Label Label_SavedWidth2;
        private Label Label_SavedWidth3;
        private Label Label_SavedWidth4;
        private Label Label_SavedWidth5;
        private Label label55;
        private Label Label_SavedRangeEnd1;
        private Label Label_SavedRangeEnd2;
        private Label Label_SavedRangeEnd3;
        private Label Label_SavedRangeEnd4;
        private Label Label_SavedRangeEnd5;
        private Label label49;
        private Label Label_SavedRangeStart1;
        private Label Label_SavedRangeStart2;
        private Label Label_SavedRangeStart3;
        private Label Label_SavedRangeStart4;
        private Label Label_SavedRangeStart5;
        private Label label43;
        private Label Label_SavedScanType1;
        private Label Label_SavedScanType2;
        private Label Label_SavedScanType3;
        private Label Label_SavedScanType4;
        private Label Label_SavedScanType5;
        private Label label37;
        private Label label36;
        private Label label35;
        private Button Button_DisplayDirChange;
        private TextBox TextBox_SavedFileDirPath;
        private Label label79;
        private TabPage tabPage_PickTable;
        private DataGridView dataGridView_Table;
        private SplitContainer splitContainer1;
        private RadioButton rb_tooltip4multi;
        private RadioButton rb_tooltip4single;
        private CheckBox checkBox_tooltip;
        private Panel panel1;
        private CartesianChart MyChart;
        private CheckBox Check_Overlay;
        private RadioButton RadioButton_Reference;
        private RadioButton RadioButton_Intensity;
        private RadioButton RadioButton_Absorbance;
        private RadioButton RadioButton_Reflectance;
        private Label Label_EstimatedScanTime;
        private Label Label_CurrentConfig;
        private Label Label_ScanStatus;
        private TabControl tabControl_MainFunctions;
        private Button button_TestSequence;
        private Button button_Home;
        private TabPage tabPage_PosData;
        private SplitContainer splitContainer2;
        private Label labelModelingMaterial;
        private Label labelPredictions;
        private DataGridView dataGridView_Predicitons;
        private Label label3;
        private GroupBox GroupBox_GainControl;
        private CheckBox CheckBox_AutoGain;
        private MyComboBox ComboBox_PGAGain;
        private Label label1;
        private GroupBox GroupBox_SaveScan;
        private Label label6;
        private CheckBox CheckBox_AverageCSV;
        private Label label11;
        private Label label10;
        private TextBox TextBox_FileNamePrefix3;
        private TextBox TextBox_FileNamePrefix2;
        private CheckBox CheckBox_SaveOneCSV;
        private TextBox TextBox_FileNamePrefix1;
        private CheckBox CheckBox_FileNamePrefix;
        private TextBox TextBox_SaveDirPath;
        private Button Button_SaveDirChange;
        private CheckBox CheckBox_SaveRCSV;
        private CheckBox CheckBox_SaveACSV;
        private CheckBox CheckBox_SaveICSV;
        private CheckBox CheckBox_SaveCombCSV;
        private GroupBox GroupBox_ScanAvg;
        private Button Button_SaveNumAvgToConfig;
        private TextBox textBox_ScanAvg;
        private Label label34;
        private GroupBox GroupBox_LampControl;
        private TextBox TextBox_LampStableTime;
        private RadioButton RadioButton_LampStableTime;
        private PictureBox pictureBox_heatMap;
        private Button button_ClearPlots;
        private Button Button_ClearAllErrors;
        private Label label_CI;
        private TextBox textBox_Material;
        private TextBox textBox_Subtype;
        private Label label7;
        private Button btnTrain;
        private PictureBox pictureBox_BestModel;
    }
}

