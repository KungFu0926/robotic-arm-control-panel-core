namespace MainForm
{
    /// <summary>
    /// 可調整之設定。
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 手臂連線IP位置。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public virtual string ArmIp => "127.0.0.1";

        /// <summary>
        /// 手臂連線Port。<br/>
        /// 設定錯誤將會無法連線。<br/>
        /// 上銀手臂無需設定該項。
        /// </summary>
        public virtual int ArmPort => 3000;

        /// <summary>
        /// 啓用手臂。
        /// </summary>
        public virtual bool ArmEnable => true;

        /// <summary>
        /// 夾爪連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public virtual string GripperComPort => "COM1";

        /// <summary>
        /// 啓用夾爪。
        /// </summary>
        public virtual bool GripperEnable => false;

        /// <summary>
        /// 藍牙連線COM Port。<br/>
        /// 設定錯誤將會無法連線。
        /// </summary>
        public virtual string BluetoothComPort => "COM2";

        /// <summary>
        /// CSV 檔案儲存路徑。
        /// </summary>
        public virtual string CsvFilePath => @"../../../../csv/";

        /// <summary>
        /// Log 檔案儲存路徑。
        /// </summary>
        public virtual string LogFilePath => @"../../../../log/";
    }
}