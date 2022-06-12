using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BusPark
{
    public partial class BusStationForm : Form
    {
        private TabControl _mainPage;
        private TabPage _tabDriverPage;
        private TabPage _tabBusPage;
        private TabPage _tabShedulePage;
        private DataGridView _dataDriverView;
        private DataGridView _dataRouteGridView;
        private DataGridView _dataBusView;
        private DataGridView _dataSheduleView;
        private Button _saveDriverButton;
        private Button _saveBusButton;
        private TabPage tabPage1;
        private Button _saveDirectoryButton;
        private TabPage tabQueryPage;
        private Label _newDataBaseDirLabel;
        private ComboBox _comboQueryBox;
        private ComboBox _comboQueryElemsBox;
        private DataGridView _dataQueryOutputView;
        private Label _moreDataQueryOutput;
        private TabPage _tabRoutePage;

        public BusStationForm()
        {
            InitializeComponent();
            DataBase.ReadDBs();
            LoadDataSource();
        }

        private void InitializeComponent()
        {
            this._mainPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._newDataBaseDirLabel = new System.Windows.Forms.Label();
            this._saveDirectoryButton = new System.Windows.Forms.Button();
            this._tabDriverPage = new System.Windows.Forms.TabPage();
            this._saveDriverButton = new System.Windows.Forms.Button();
            this._dataDriverView = new System.Windows.Forms.DataGridView();
            this._tabRoutePage = new System.Windows.Forms.TabPage();
            this._dataRouteGridView = new System.Windows.Forms.DataGridView();
            this._tabBusPage = new System.Windows.Forms.TabPage();
            this._saveBusButton = new System.Windows.Forms.Button();
            this._dataBusView = new System.Windows.Forms.DataGridView();
            this._tabShedulePage = new System.Windows.Forms.TabPage();
            this._dataSheduleView = new System.Windows.Forms.DataGridView();
            this.tabQueryPage = new System.Windows.Forms.TabPage();
            this._moreDataQueryOutput = new System.Windows.Forms.Label();
            this._dataQueryOutputView = new System.Windows.Forms.DataGridView();
            this._comboQueryElemsBox = new System.Windows.Forms.ComboBox();
            this._comboQueryBox = new System.Windows.Forms.ComboBox();
            this._mainPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this._tabDriverPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataDriverView)).BeginInit();
            this._tabRoutePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataRouteGridView)).BeginInit();
            this._tabBusPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataBusView)).BeginInit();
            this._tabShedulePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataSheduleView)).BeginInit();
            this.tabQueryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataQueryOutputView)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainPage
            // 
            this._mainPage.Controls.Add(this.tabPage1);
            this._mainPage.Controls.Add(this._tabDriverPage);
            this._mainPage.Controls.Add(this._tabRoutePage);
            this._mainPage.Controls.Add(this._tabBusPage);
            this._mainPage.Controls.Add(this._tabShedulePage);
            this._mainPage.Controls.Add(this.tabQueryPage);
            this._mainPage.Location = new System.Drawing.Point(12, 12);
            this._mainPage.Name = "_mainPage";
            this._mainPage.SelectedIndex = 0;
            this._mainPage.Size = new System.Drawing.Size(897, 479);
            this._mainPage.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._newDataBaseDirLabel);
            this.tabPage1.Controls.Add(this._saveDirectoryButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 453);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Выбор директории";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _newDataBaseDirLabel
            // 
            this._newDataBaseDirLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._newDataBaseDirLabel.Location = new System.Drawing.Point(129, 150);
            this._newDataBaseDirLabel.Name = "_newDataBaseDirLabel";
            this._newDataBaseDirLabel.Size = new System.Drawing.Size(448, 23);
            this._newDataBaseDirLabel.TabIndex = 2;
            this._newDataBaseDirLabel.Text = "Нажмите здесь, чтоб выбрать директорию для баз данных";
            this._newDataBaseDirLabel.Click += new System.EventHandler(this.NewDataBaseDirLabelClick);
            // 
            // _saveDirectoryButton
            // 
            this._saveDirectoryButton.Location = new System.Drawing.Point(583, 150);
            this._saveDirectoryButton.Name = "_saveDirectoryButton";
            this._saveDirectoryButton.Size = new System.Drawing.Size(67, 23);
            this._saveDirectoryButton.TabIndex = 1;
            this._saveDirectoryButton.Text = "OK";
            this._saveDirectoryButton.UseVisualStyleBackColor = true;
            this._saveDirectoryButton.Click += new System.EventHandler(this.SaveDirectoryButtonClick);
            // 
            // _tabDriverPage
            // 
            this._tabDriverPage.Controls.Add(this._saveDriverButton);
            this._tabDriverPage.Controls.Add(this._dataDriverView);
            this._tabDriverPage.Location = new System.Drawing.Point(4, 22);
            this._tabDriverPage.Name = "_tabDriverPage";
            this._tabDriverPage.Padding = new System.Windows.Forms.Padding(3);
            this._tabDriverPage.Size = new System.Drawing.Size(889, 453);
            this._tabDriverPage.TabIndex = 0;
            this._tabDriverPage.Text = "Водитель";
            this._tabDriverPage.UseVisualStyleBackColor = true;
            // 
            // _saveDriverButton
            // 
            this._saveDriverButton.Location = new System.Drawing.Point(355, 424);
            this._saveDriverButton.Name = "_saveDriverButton";
            this._saveDriverButton.Size = new System.Drawing.Size(170, 23);
            this._saveDriverButton.TabIndex = 3;
            this._saveDriverButton.Text = "Save";
            this._saveDriverButton.UseVisualStyleBackColor = true;
            this._saveDriverButton.Click += new System.EventHandler(this.SaveDriverButtonClick);
            // 
            // _dataDriverView
            // 
            this._dataDriverView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataDriverView.Location = new System.Drawing.Point(6, 6);
            this._dataDriverView.Name = "_dataDriverView";
            this._dataDriverView.Size = new System.Drawing.Size(877, 412);
            this._dataDriverView.TabIndex = 0;
            this._dataDriverView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataDriverViewUserDeletingRow);
            // 
            // _tabRoutePage
            // 
            this._tabRoutePage.Controls.Add(this._dataRouteGridView);
            this._tabRoutePage.Location = new System.Drawing.Point(4, 22);
            this._tabRoutePage.Name = "_tabRoutePage";
            this._tabRoutePage.Padding = new System.Windows.Forms.Padding(3);
            this._tabRoutePage.Size = new System.Drawing.Size(889, 453);
            this._tabRoutePage.TabIndex = 1;
            this._tabRoutePage.Text = "Маршрут";
            this._tabRoutePage.UseVisualStyleBackColor = true;
            // 
            // _dataRouteGridView
            // 
            this._dataRouteGridView.AllowUserToAddRows = false;
            this._dataRouteGridView.AllowUserToDeleteRows = false;
            this._dataRouteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataRouteGridView.Location = new System.Drawing.Point(6, 6);
            this._dataRouteGridView.Name = "_dataRouteGridView";
            this._dataRouteGridView.ReadOnly = true;
            this._dataRouteGridView.Size = new System.Drawing.Size(877, 441);
            this._dataRouteGridView.TabIndex = 1;
            // 
            // _tabBusPage
            // 
            this._tabBusPage.Controls.Add(this._saveBusButton);
            this._tabBusPage.Controls.Add(this._dataBusView);
            this._tabBusPage.Location = new System.Drawing.Point(4, 22);
            this._tabBusPage.Name = "_tabBusPage";
            this._tabBusPage.Padding = new System.Windows.Forms.Padding(3);
            this._tabBusPage.Size = new System.Drawing.Size(889, 453);
            this._tabBusPage.TabIndex = 2;
            this._tabBusPage.Text = "Автобус";
            this._tabBusPage.UseVisualStyleBackColor = true;
            // 
            // _saveBusButton
            // 
            this._saveBusButton.Location = new System.Drawing.Point(359, 424);
            this._saveBusButton.Name = "_saveBusButton";
            this._saveBusButton.Size = new System.Drawing.Size(173, 23);
            this._saveBusButton.TabIndex = 2;
            this._saveBusButton.Text = "Save";
            this._saveBusButton.UseVisualStyleBackColor = true;
            this._saveBusButton.Click += new System.EventHandler(this.SaveBusButtonClick);
            // 
            // _dataBusView
            // 
            this._dataBusView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataBusView.Location = new System.Drawing.Point(6, 6);
            this._dataBusView.Name = "_dataBusView";
            this._dataBusView.Size = new System.Drawing.Size(877, 412);
            this._dataBusView.TabIndex = 1;
            this._dataBusView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataBusViewUserDeletingRow);
            // 
            // _tabShedulePage
            // 
            this._tabShedulePage.Controls.Add(this._dataSheduleView);
            this._tabShedulePage.Location = new System.Drawing.Point(4, 22);
            this._tabShedulePage.Name = "_tabShedulePage";
            this._tabShedulePage.Padding = new System.Windows.Forms.Padding(3);
            this._tabShedulePage.Size = new System.Drawing.Size(889, 453);
            this._tabShedulePage.TabIndex = 3;
            this._tabShedulePage.Text = "График";
            this._tabShedulePage.UseVisualStyleBackColor = true;
            // 
            // _dataSheduleView
            // 
            this._dataSheduleView.AllowUserToAddRows = false;
            this._dataSheduleView.AllowUserToDeleteRows = false;
            this._dataSheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataSheduleView.Location = new System.Drawing.Point(6, 6);
            this._dataSheduleView.Name = "_dataSheduleView";
            this._dataSheduleView.ReadOnly = true;
            this._dataSheduleView.Size = new System.Drawing.Size(877, 441);
            this._dataSheduleView.TabIndex = 1;
            // 
            // tabQueryPage
            // 
            this.tabQueryPage.Controls.Add(this._moreDataQueryOutput);
            this.tabQueryPage.Controls.Add(this._dataQueryOutputView);
            this.tabQueryPage.Controls.Add(this._comboQueryElemsBox);
            this.tabQueryPage.Controls.Add(this._comboQueryBox);
            this.tabQueryPage.Location = new System.Drawing.Point(4, 22);
            this.tabQueryPage.Name = "tabQueryPage";
            this.tabQueryPage.Size = new System.Drawing.Size(889, 453);
            this.tabQueryPage.TabIndex = 5;
            this.tabQueryPage.Text = "Запросы";
            this.tabQueryPage.UseVisualStyleBackColor = true;
            // 
            // _moreDataQueryOutput
            // 
            this._moreDataQueryOutput.Location = new System.Drawing.Point(3, 125);
            this._moreDataQueryOutput.Name = "_moreDataQueryOutput";
            this._moreDataQueryOutput.Size = new System.Drawing.Size(883, 51);
            this._moreDataQueryOutput.TabIndex = 3;
            this._moreDataQueryOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._moreDataQueryOutput.Visible = false;
            // 
            // _dataQueryOutputView
            // 
            this._dataQueryOutputView.AllowUserToAddRows = false;
            this._dataQueryOutputView.AllowUserToDeleteRows = false;
            this._dataQueryOutputView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataQueryOutputView.Location = new System.Drawing.Point(3, 179);
            this._dataQueryOutputView.Name = "_dataQueryOutputView";
            this._dataQueryOutputView.ReadOnly = true;
            this._dataQueryOutputView.Size = new System.Drawing.Size(883, 271);
            this._dataQueryOutputView.TabIndex = 2;
            // 
            // _comboQueryElemsBox
            // 
            this._comboQueryElemsBox.FormattingEnabled = true;
            this._comboQueryElemsBox.Location = new System.Drawing.Point(637, 65);
            this._comboQueryElemsBox.Name = "_comboQueryElemsBox";
            this._comboQueryElemsBox.Size = new System.Drawing.Size(249, 21);
            this._comboQueryElemsBox.TabIndex = 1;
            this._comboQueryElemsBox.Visible = false;
            this._comboQueryElemsBox.SelectedIndexChanged += new System.EventHandler(this.ComboQueryElemsBoxSelectedIndexChanged);
            // 
            // _comboQueryBox
            // 
            this._comboQueryBox.FormattingEnabled = true;
            this._comboQueryBox.Items.AddRange(new object[] {
            "Список водителей, работающих на определенном маршруте с указанием графика их рабо" +
                "ты.",
            "Какие автобусы обслуживают данный маршрут.",
            "Протяженность маршрутов и их минимальная и максимальная протяженность.",
            "На каком маршруте работает водитель с максимальным стажем.",
            "Какова общая протяженность маршрутов, обслуживаемых автопарком."});
            this._comboQueryBox.Location = new System.Drawing.Point(6, 65);
            this._comboQueryBox.Name = "_comboQueryBox";
            this._comboQueryBox.Size = new System.Drawing.Size(459, 21);
            this._comboQueryBox.TabIndex = 0;
            this._comboQueryBox.SelectedIndexChanged += new System.EventHandler(this.ComboQueryBoxSelectedIndexChanged);
            // 
            // BusStationForm
            // 
            this.ClientSize = new System.Drawing.Size(921, 503);
            this.Controls.Add(this._mainPage);
            this.Name = "BusStationForm";
            this._mainPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this._tabDriverPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataDriverView)).EndInit();
            this._tabRoutePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataRouteGridView)).EndInit();
            this._tabBusPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataBusView)).EndInit();
            this._tabShedulePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataSheduleView)).EndInit();
            this.tabQueryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataQueryOutputView)).EndInit();
            this.ResumeLayout(false);

        }

        private void LoadDataSource()
        {
            OutputListToTable(ref _dataDriverView, DataBase.BusPark.Drivers, '|', 
                "ID", "ФИО", "Стаж", "Категория прав", "День рождения");
            _dataDriverView.Columns[0].Visible = false;

            OutputListToTable(ref _dataBusView, DataBase.BusPark.Buses, '|', 
                "ID", "Гос. Номер", "Марка", "Количество мест");
            _dataBusView.Columns[0].Visible = false;

            OutputListToTable(ref _dataRouteGridView, DataBase.BusPark.Routes, '|', 
                "ID", "Номер маршрута", "Начало", "Конец", "Протяжённость в минутах", "Интервал");
            _dataRouteGridView.Columns[0].Visible = false;

            CreateColums(ref _dataSheduleView, 
                "Водитель", "Автобус", "Гос. номер", "Маршрут", "Дата", "Время");
            OutputShedule();

            //_dataDriverView.DataSource = DataBase.BusPark.Drivers;
        }

        private void ClearTable(ref DataGridView table)
        {
            table.Rows.Clear();
            table.Columns.Clear();
            table.Refresh();
        }

        /* Description:
         * Create colums for the specific table;
         * 
         * Args:
         * table - data grid view we want to fill;
         * columsName = how we want to call the colums;
         */
        private void CreateColums(ref DataGridView table, params string[] columsName)
        {
            ClearTable(ref table);


            // Add all columns;
            for (int i = 0; i < columsName.Length; ++i)
            {
                table.Columns.Add(columsName[i], columsName[i]);
                table.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /* Description:
         * Fill the table with your data. For this you must have ToString overload!
         * 
         * Args:
         * table - data grid view we want to fill;
         * data - data we want to output; 
         * columsName - how we want to call the colums;
         */
        private void OutputListToTable<ListContainData>(ref DataGridView table, List<ListContainData> data, char split_data_char, params string[] columsName)
        {
            ClearTable(ref table);
            CreateColums(ref table, columsName);

            // Fill data;
            for (int i = 0; i < data.Count; ++i)
            {
                table.Rows.Add(1);
                var d = data[i].ToString().Split(split_data_char);

                for (int j = 0; j < Math.Min(d.Length, columsName.Length); ++j)
                {
                    table.Rows[i].Cells[j].Value = d[j];
                }
            }
        }

        private void OutputShedule()
        {
            // remove all previous data;
            _dataSheduleView.Rows.Clear();
            _dataSheduleView.Refresh();

            // get all names we need;
            var outputValues = (from shed in DataBase.BusPark.Shedules
                               from dr in DataBase.BusPark.Drivers
                               where shed.DriverID == dr.ID
                               from b in DataBase.BusPark.Buses
                               where shed.BusID == b.ID
                               from r in DataBase.BusPark.Routes
                               where shed.RouteID == r.ID
                               select new
                               {
                                   driver = dr.FullName,
                                   bus = b.Type,
                                   busStateNumber = b.StateNumber,
                                   routeNumber = r.Number,
                                   date = shed.DepartureTime.ToString("dd.MM.yyyy"),
                                   time = shed.DepartureTime.ToString("hh:mm:ss")
                               }).ToList();

            for (int i = 0; i < outputValues.Count; ++i)
            {
                _dataSheduleView.Rows.Add(1);

                _dataSheduleView.Rows[i].Cells[0].Value = outputValues[i].driver;
                _dataSheduleView.Rows[i].Cells[1].Value = outputValues[i].bus;
                _dataSheduleView.Rows[i].Cells[2].Value = outputValues[i].busStateNumber;
                _dataSheduleView.Rows[i].Cells[3].Value = outputValues[i].routeNumber;
                _dataSheduleView.Rows[i].Cells[4].Value = outputValues[i].date;
                _dataSheduleView.Rows[i].Cells[5].Value = outputValues[i].time;
            }
        }

        private void SaveDriverButtonClick(object sender, EventArgs e)
        {
            DataBase.BusPark.Drivers.Clear();

            for (int i = 0; i < _dataDriverView.RowCount - 1; ++i)
            {
                // there we cotain all data about the object;
                object[] data = new object[_dataDriverView.Columns.Count];
                for (int j = 0; j < data.Length; ++j)
                {
                    data[j] = _dataDriverView.Rows[i].Cells[j].Value;
                }

                // if id == null, that is a new data;
                if (data[0] != null)
                {
                    DataBase.BusPark.Drivers.Add(new BusStation.Driver(data[1].ToString(), (float)Convert.ToDouble(data[2]),
                        data[3].ToString(), Convert.ToDateTime(data[4]), Convert.ToUInt64(data[0])));
                }
                else
                {
                    DataBase.BusPark.Drivers.Add(new BusStation.Driver(data[1].ToString(), (float)Convert.ToDouble(data[2]),
                        data[3].ToString(), Convert.ToDateTime(data[4])));
                }
            }

            DataBase.RewriteDataBase(DataBase.BusPark.Drivers, DataBase.ConvertToFullPath(DataBase.DBPath, DataBase.DriverDBName));
            OutputListToTable(ref _dataDriverView, DataBase.BusPark.Drivers, '|',
                "ID", "ФИО", "Стаж", "Категория прав", "День рождения");
            _dataDriverView.Columns[0].Visible = false;

            SaveShedule();
        }

        private void SaveBusButtonClick(object sender, EventArgs e)
        {
            DataBase.BusPark.Buses.Clear();

            for (int i = 0; i < _dataBusView.RowCount - 1; ++i)
            {
                // there we cotain all data about the object;
                object[] data = new object[_dataBusView.Columns.Count];
                for (int j = 0; j < data.Length; ++j)
                {
                    data[j] = _dataBusView.Rows[i].Cells[j].Value;
                }

                // if id == null, that is a new data;
                if (data[0] != null)
                {
                    DataBase.BusPark.Buses.Add(new BusStation.Bus(data[1].ToString(), data[2].ToString(),
                        Convert.ToUInt16(data[3]), Convert.ToUInt64(data[0])));
                }
                else
                {
                    DataBase.BusPark.Buses.Add(new BusStation.Bus(data[1].ToString(), data[2].ToString(),
                        Convert.ToUInt16(data[3])));
                }
            }

            DataBase.RewriteDataBase(DataBase.BusPark.Buses, DataBase.ConvertToFullPath(DataBase.DBPath, DataBase.BusDBName));
            OutputListToTable(ref _dataBusView, DataBase.BusPark.Buses, '|',
                "ID", "Гос. Номер", "Марка", "Количество мест");
            _dataBusView.Columns[0].Visible = false;

            SaveShedule();
        }

        private void SaveShedule()
        {
            DataBase.BusPark.Shedules.Clear();

            for (int i = 0; i < _dataSheduleView.RowCount - 1; ++i)
            {
                // there we cotain all data about the object;
                object[] data = new object[_dataSheduleView.Columns.Count];
                for (int j = 0; j < data.Length; ++j)
                {
                    data[j] = _dataSheduleView.Rows[i].Cells[j].Value;
                }

                var driverID = (from dr in DataBase.BusPark.Drivers
                                where data[0].Equals(dr.FullName)
                                select new
                                {
                                    dr.ID
                                }).FirstOrDefault();

                var busID = (from b in DataBase.BusPark.Buses
                             where b.StateNumber == data[2].ToString()
                             select new
                             {
                                 b.ID
                             }).FirstOrDefault();

                var RouteID = (from s in DataBase.BusPark.Routes
                               where (s.Begin + " - " + s.End) == data[3].ToString()
                               select new
                               {
                                   s.ID
                               }).FirstOrDefault();

                // if id == null, that is a new data;
                if (driverID != default && busID != default && RouteID != default)
                {
                    var date = Convert.ToDateTime(data[4]);
                    var time = Convert.ToDateTime(data[5]);
                    date = date + TimeSpan.Parse(time.ToString("hh:mm:ss"));

                    DataBase.BusPark.Shedules.Add(new BusStation.Shedule(driverID.ID, busID.ID,
                        RouteID.ID, date));
                }
            }

            DataBase.RewriteDataBase(DataBase.BusPark.Shedules, DataBase.ConvertToFullPath(DataBase.DBPath, DataBase.SheduleDBName));
            CreateColums(ref _dataSheduleView, "Водитель", "Автобус", "Гос. номер", "Маршрут", "Дата", "Время");
            OutputShedule();
        }

        private void NewDataBaseDirLabelClick(object sender, EventArgs e)
        {
            FolderBrowserDialog link = new FolderBrowserDialog();

            if (link.ShowDialog() == DialogResult.OK)
                _newDataBaseDirLabel.Text = link.SelectedPath;
        }

        private void SaveDirectoryButtonClick(object sender, EventArgs e)
        {
            try
            {
                /* check if entered data is a directory.
                 * If not, exception throws;
                 */
                if(!(_newDataBaseDirLabel.Text.Contains("/") || _newDataBaseDirLabel.Text.Contains("\\")))
                {
                    throw new DataException("Entered data in not a directory!");
                }

                DataBase.DBPath = _newDataBaseDirLabel.Text;
                DataBase.ReadDBs();                             // read new data;
                LoadDataSource();                               // load new data;
            }
            catch(DataException error)
            {
                MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataDriverViewUserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this row?", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (res)
            {
                case (DialogResult.Cancel):
                    e.Cancel = true;    // calncel deleting;
                    break;

                case (DialogResult.OK):
                    for (int i = _dataSheduleView.RowCount - 1; i >= 0; --i)
                    {
                        if (_dataSheduleView.Rows[i].Cells[0].Value.Equals(e.Row.Cells[1].Value))
                        {
                            _dataSheduleView.Rows.Remove(_dataSheduleView.Rows[i]);
                        }
                    }
                    break;
            }
        }

        private void DataBusViewUserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this row?", "Warning!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            switch (res)
            {
                case (DialogResult.Cancel):
                    e.Cancel = true;    // calncel deleting;
                    break;

                case (DialogResult.OK):
                    for (int i = _dataSheduleView.RowCount - 1; i >= 0; --i)
                    {
                        if (_dataSheduleView.Rows[i].Cells[2].Value.Equals(e.Row.Cells[1].Value))
                        {
                            _dataSheduleView.Rows.Remove(_dataSheduleView.Rows[i]);
                        }
                    }
                    break;
            }
        }

        private void ComboQueryBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_comboQueryBox.SelectedIndex < 0)
                return;

            Action hideUnwantedWidgets = () =>
            {
                _moreDataQueryOutput.Visible = false;
                _comboQueryElemsBox.Visible = false;
            };

            ClearTable(ref _dataQueryOutputView);

            switch (_comboQueryBox.SelectedIndex)
            {
                case 0:
                    hideUnwantedWidgets();

                    // output choicing of route
                    _comboQueryElemsBox.DataSource = DataBase.BusPark.Routes;
                    _comboQueryElemsBox.DisplayMember = "Number";
                    _comboQueryElemsBox.ValueMember = "ID";
                    _comboQueryElemsBox.Visible = true;
                    _comboQueryElemsBox.SelectedIndex = -1;

                    // actions will be happened in _comboQueryElemsBox;
                    break;

                case 1:
                    hideUnwantedWidgets();

                    // output choicing of route
                    _comboQueryElemsBox.DataSource = DataBase.BusPark.Routes;
                    _comboQueryElemsBox.DisplayMember = "Number";
                    _comboQueryElemsBox.ValueMember = "ID";
                    _comboQueryElemsBox.Visible = true;
                    _comboQueryElemsBox.SelectedIndex = -1;

                    // actions will be happened in _comboQueryElemsBox;
                    break;

                case 2:
                    hideUnwantedWidgets();
                    OutputRoutes();
                    break;

                case 3:
                    hideUnwantedWidgets();
                    OutputTheMostExperiencedDriver();
                    break;

                case 4:
                    hideUnwantedWidgets();
                    OutputTotalParkDuration();
                    break;
            }
        }

        private void OutputRoutes()
        {
            var routes = (from route in DataBase.BusPark.Routes
                          orderby route.Number
                          select new
                          {
                              routeNumber = route.Number,
                              routeDuration = route.Duration
                          }).ToList();

            CreateColums(ref _dataQueryOutputView, "Номер маршрутка", "Протяжённость в минутах");
            int row = 0;
            foreach (var r in routes)
            {
                _dataQueryOutputView.Rows.Add(1);

                _dataQueryOutputView.Rows[row].Cells[0].Value = r.routeNumber;
                _dataQueryOutputView.Rows[row].Cells[1].Value = r.routeDuration;

                ++row;
            }

            var minDurationElem = routes.FirstOrDefault(o => o.routeDuration == routes.Min(e => e.routeDuration));
            var maxDurationElem = routes.FirstOrDefault(o => o.routeDuration == routes.Max(e => e.routeDuration));

            _moreDataQueryOutput.Text = $"Минимальная протяжённость: {minDurationElem.routeDuration} минут " +
                $"({minDurationElem.routeNumber} маршрутка)" +
                $"\nМаксимальная протяжённость: {maxDurationElem.routeDuration} минут " +
                $"({maxDurationElem.routeNumber} маршрутка)";

            _moreDataQueryOutput.Visible = true;
        }

        private void OutputTheMostExperiencedDriver()
        {
            var driver = DataBase.BusPark.Drivers.FirstOrDefault(
                o => o.Experience == DataBase.BusPark.Drivers.Max(e => e.Experience));

            var routes = (from sh in DataBase.BusPark.Shedules
                          where sh.DriverID == driver.ID
                          join route in DataBase.BusPark.Routes
                          on sh.RouteID equals route.ID
                         select new
                         {
                             driverName = driver.FullName,
                             driverExp = driver.Experience,
                             routeNumber = route.Number
                         }).ToList();

            CreateColums(ref _dataQueryOutputView, "ФИО", "Стаж", "Маршрут");

            int row = 0;
            foreach(var route in routes)
            {
                _dataQueryOutputView.Rows.Add(1);

                _dataQueryOutputView.Rows[row].Cells[0].Value = route.driverName;
                _dataQueryOutputView.Rows[row].Cells[1].Value = route.driverExp;
                _dataQueryOutputView.Rows[row].Cells[2].Value = route.routeNumber;

                ++row;
            }
        }

        private void OutputTotalParkDuration()
        {
            var totalDuration = DataBase.BusPark.Routes.Sum(o => o.Duration);

            _moreDataQueryOutput.Text = $"Общая протяжённость: {totalDuration}";
            _moreDataQueryOutput.Visible = true;
        }

        private void ComboQueryElemsBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (_comboQueryElemsBox.SelectedIndex < 0 || _comboQueryBox.SelectedIndex < 0)
            {
                return;
            }

            ulong choosenRouteID;
            switch (_comboQueryBox.SelectedIndex)
            {
                case 0:
                    choosenRouteID = Convert.ToUInt64(_comboQueryElemsBox.SelectedValue);
                    OutputDriversWithSHedule(choosenRouteID);

                    break;

                case 1:
                    choosenRouteID = Convert.ToUInt64(_comboQueryElemsBox.SelectedValue);
                    OutputBusesForRoutes(choosenRouteID);

                    break;
            }

            //ulong choosenRoute = Convert.ToUInt64(_comboQueryElemsBox.SelectedValue);


        }

        private void OutputBusesForRoutes(ulong routeID)
        {
            var buses = (from sh in DataBase.BusPark.Shedules
                         where sh.RouteID == routeID
                         join b in DataBase.BusPark.Buses
                         on sh.BusID equals b.ID
                         select b).ToList();

            OutputListToTable(ref _dataQueryOutputView, buses, '|',
                "ID", "Гос. Номер", "Марка", "Количество мест");
            _dataQueryOutputView.Columns[0].Visible = false;
        }

        private void OutputDriversWithSHedule(ulong routeID)
        {
            var drivers = (from sh in DataBase.BusPark.Shedules
                           where sh.RouteID == routeID
                           from d in DataBase.BusPark.Drivers
                           where sh.DriverID == d.ID
                           orderby sh.DepartureTime
                           select new
                           {
                               driverName = d.FullName,
                               driverExp = d.Experience,
                               shedule = sh.DepartureTime
                           }).ToList();

            CreateColums(ref _dataQueryOutputView, "Водитель", "Стаж", "Время отправления");

            int row = 0;
            foreach (var d in drivers)
            {
                _dataQueryOutputView.Rows.Add(1);

                _dataQueryOutputView.Rows[row].Cells[0].Value = d.driverName;
                _dataQueryOutputView.Rows[row].Cells[1].Value = d.driverExp;
                _dataQueryOutputView.Rows[row].Cells[2].Value = d.shedule;

                ++row;
            }
        }
    }
}
