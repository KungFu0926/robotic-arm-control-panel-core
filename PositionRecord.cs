using System;
using RASDK.Arm;

namespace MainForm
{
    public partial class MainForm
    {
        private PositionRecorder PositionRecorder = new PositionRecorder();

        /// <summary>
        /// 位置記錄。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_position_recode_Click(object sender, EventArgs e)
        {
            try
            {
                PositionRecorder.Write(textBox_position_record_name.Text,
                                       GetNowUiPosition(),
                                       GetCoordinateType(),
                                       textBox_position_record_comment.Text);
            }
            catch (Exception ex)
            {
                MessageHandler.Show(ex, RASDK.Basic.LoggingLevel.Warn);
            }
        }

        private void button_position_record_read_Click(object sender, EventArgs e)
        {
            try
            {
                var rowCount = PositionRecorder.Read(out var names,
                                                     out var positions,
                                                     out var types,
                                                     out var remarks,
                                                     out var times);

                listView_position_record.Items.Clear();
                for (int row = 0; row < rowCount; row++)
                {
                    var item = new System.Windows.Forms.ListViewItem();
                    item.SubItems[0].Text = times[row];
                    item.SubItems.Add(names[row]);
                    item.SubItems.Add(positions[row][0].ToString());
                    item.SubItems.Add(positions[row][1].ToString());
                    item.SubItems.Add(positions[row][2].ToString());
                    item.SubItems.Add(positions[row][3].ToString());
                    item.SubItems.Add(positions[row][4].ToString());
                    item.SubItems.Add(positions[row][5].ToString());
                    item.SubItems.Add(types[row].ToString());
                    item.SubItems.Add(remarks[row]);
                    listView_position_record.Items.Add(item);
                }

                // Selected the first item.
                if (listView_position_record.Items.Count > 0)
                {
                    listView_position_record.Items[0].Selected = true;
                }

                ResizeListColumnWidth();
            }
            catch (Exception ex)
            {
                MessageHandler.Show(ex, RASDK.Basic.LoggingLevel.Warn);
            }
        }

        private void ResizeListColumnWidth()
        {
            // 若要調整資料行中最長專案的寬度，請將 Width 屬性設定為-1。
            // 若要自動調整為數據行標題的寬度，請將 Width 屬性設定為-2。
            for (var col = 0; col < listView_position_record.Columns.Count; col++)
            {
                listView_position_record.Columns[col].Width = -2;
            }
        }
    }
}