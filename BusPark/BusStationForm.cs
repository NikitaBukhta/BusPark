using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPark
{
    public partial class BusStationForm : Form
    {
        private TabControl tabControl1;
        private TabPage _tabDriverPage;
        private TabPage _tabBusPage;
        private TabPage _tabShedulePage;
        private DataGridView _dataDriverView;
        private DataGridView _dataRouteGridView;
        private DataGridView _dataBusView;
        private DataGridView _dataSheduleView;
        private DataGridViewTextBoxColumn _sheduleColumnDriverFullName;
        private DataGridViewTextBoxColumn _sheduleColumnBusType;
        private DataGridViewTextBoxColumn _sheduleColumnRouteBeginEnd;
        private DataGridViewTextBoxColumn _sheduleColumnDate;
        private DataGridViewTextBoxColumn _sheduleColumnTime;
        private DataGridViewTextBoxColumn _routeColumnID;
        private DataGridViewTextBoxColumn _routeColumnNumber;
        private DataGridViewTextBoxColumn _routeColumnBegin;
        private DataGridViewTextBoxColumn _routeColumnEnd;
        private DataGridViewTextBoxColumn _routeColumnDuration;
        private DataGridViewTextBoxColumn _routeColumnInterval;
        private DataGridViewTextBoxColumn _busColumnID;
        private DataGridViewTextBoxColumn _busColumnNumber;
        private DataGridViewTextBoxColumn _busColumnType;
        private DataGridViewTextBoxColumn _busColumnMaxSeats;
        private Button _saveDriverButton;
        private Button _saveBusButton;
        private BindingSource dataBaseBindingSource;
        private IContainer components;
        private DataGridViewTextBoxColumn _driverColumnID;
        private DataGridViewTextBoxColumn _driverColumnFullName;
        private DataGridViewTextBoxColumn _driverColumnExperience;
        private DataGridViewTextBoxColumn _driverColumnClass;
        private DataGridViewTextBoxColumn _driverColumnBirthdate;
        private TabPage _tabRoutePage;

        public BusStationForm()
        {
            InitializeComponent();
            DataBase.ReadDBs();
            LoadDataSource();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._tabDriverPage = new System.Windows.Forms.TabPage();
            this._saveDriverButton = new System.Windows.Forms.Button();
            this._dataDriverView = new System.Windows.Forms.DataGridView();
            this._tabRoutePage = new System.Windows.Forms.TabPage();
            this._dataRouteGridView = new System.Windows.Forms.DataGridView();
            this._routeColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._routeColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._routeColumnBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._routeColumnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._routeColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._routeColumnInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tabBusPage = new System.Windows.Forms.TabPage();
            this._saveBusButton = new System.Windows.Forms.Button();
            this._dataBusView = new System.Windows.Forms.DataGridView();
            this._busColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._busColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._busColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._busColumnMaxSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tabShedulePage = new System.Windows.Forms.TabPage();
            this._dataSheduleView = new System.Windows.Forms.DataGridView();
            this._sheduleColumnDriverFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sheduleColumnBusType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sheduleColumnRouteBeginEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sheduleColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._sheduleColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._driverColumnBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._driverColumnClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._driverColumnExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._driverColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._driverColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this._tabDriverPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataDriverView)).BeginInit();
            this._tabRoutePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataRouteGridView)).BeginInit();
            this._tabBusPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataBusView)).BeginInit();
            this._tabShedulePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataSheduleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._tabDriverPage);
            this.tabControl1.Controls.Add(this._tabRoutePage);
            this.tabControl1.Controls.Add(this._tabBusPage);
            this.tabControl1.Controls.Add(this._tabShedulePage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(897, 479);
            this.tabControl1.TabIndex = 0;
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
            this._dataDriverView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._driverColumnID,
            this._driverColumnFullName,
            this._driverColumnExperience,
            this._driverColumnClass,
            this._driverColumnBirthdate});
            this._dataDriverView.Location = new System.Drawing.Point(6, 6);
            this._dataDriverView.Name = "_dataDriverView";
            this._dataDriverView.Size = new System.Drawing.Size(877, 412);
            this._dataDriverView.TabIndex = 0;
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
            this._dataRouteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._routeColumnID,
            this._routeColumnNumber,
            this._routeColumnBegin,
            this._routeColumnEnd,
            this._routeColumnDuration,
            this._routeColumnInterval});
            this._dataRouteGridView.Location = new System.Drawing.Point(6, 6);
            this._dataRouteGridView.Name = "_dataRouteGridView";
            this._dataRouteGridView.ReadOnly = true;
            this._dataRouteGridView.Size = new System.Drawing.Size(877, 441);
            this._dataRouteGridView.TabIndex = 1;
            // 
            // _routeColumnID
            // 
            this._routeColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._routeColumnID.HeaderText = "ID";
            this._routeColumnID.Name = "_routeColumnID";
            this._routeColumnID.ReadOnly = true;
            this._routeColumnID.Visible = false;
            // 
            // _routeColumnNumber
            // 
            this._routeColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._routeColumnNumber.HeaderText = "Номер";
            this._routeColumnNumber.Name = "_routeColumnNumber";
            this._routeColumnNumber.ReadOnly = true;
            // 
            // _routeColumnBegin
            // 
            this._routeColumnBegin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._routeColumnBegin.HeaderText = "Начало";
            this._routeColumnBegin.Name = "_routeColumnBegin";
            this._routeColumnBegin.ReadOnly = true;
            // 
            // _routeColumnEnd
            // 
            this._routeColumnEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._routeColumnEnd.HeaderText = "Конец";
            this._routeColumnEnd.Name = "_routeColumnEnd";
            this._routeColumnEnd.ReadOnly = true;
            // 
            // _routeColumnDuration
            // 
            this._routeColumnDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._routeColumnDuration.HeaderText = "Протяжённость в минутах";
            this._routeColumnDuration.Name = "_routeColumnDuration";
            this._routeColumnDuration.ReadOnly = true;
            // 
            // _routeColumnInterval
            // 
            this._routeColumnInterval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._routeColumnInterval.HeaderText = "Интервал Движения";
            this._routeColumnInterval.Name = "_routeColumnInterval";
            this._routeColumnInterval.ReadOnly = true;
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
            this._dataBusView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._busColumnID,
            this._busColumnNumber,
            this._busColumnType,
            this._busColumnMaxSeats});
            this._dataBusView.Location = new System.Drawing.Point(6, 6);
            this._dataBusView.Name = "_dataBusView";
            this._dataBusView.Size = new System.Drawing.Size(877, 412);
            this._dataBusView.TabIndex = 1;
            // 
            // _busColumnID
            // 
            this._busColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._busColumnID.HeaderText = "ID";
            this._busColumnID.Name = "_busColumnID";
            this._busColumnID.Visible = false;
            // 
            // _busColumnNumber
            // 
            this._busColumnNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._busColumnNumber.HeaderText = "Гос. Номер";
            this._busColumnNumber.Name = "_busColumnNumber";
            // 
            // _busColumnType
            // 
            this._busColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._busColumnType.HeaderText = "Тип";
            this._busColumnType.Name = "_busColumnType";
            // 
            // _busColumnMaxSeats
            // 
            this._busColumnMaxSeats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._busColumnMaxSeats.HeaderText = "Вместимость";
            this._busColumnMaxSeats.Name = "_busColumnMaxSeats";
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
            this._dataSheduleView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._sheduleColumnDriverFullName,
            this._sheduleColumnBusType,
            this._sheduleColumnRouteBeginEnd,
            this._sheduleColumnDate,
            this._sheduleColumnTime});
            this._dataSheduleView.Location = new System.Drawing.Point(6, 6);
            this._dataSheduleView.Name = "_dataSheduleView";
            this._dataSheduleView.ReadOnly = true;
            this._dataSheduleView.Size = new System.Drawing.Size(877, 441);
            this._dataSheduleView.TabIndex = 1;
            // 
            // _sheduleColumnDriverFullName
            // 
            this._sheduleColumnDriverFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._sheduleColumnDriverFullName.HeaderText = "Водитель";
            this._sheduleColumnDriverFullName.Name = "_sheduleColumnDriverFullName";
            this._sheduleColumnDriverFullName.ReadOnly = true;
            // 
            // _sheduleColumnBusType
            // 
            this._sheduleColumnBusType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._sheduleColumnBusType.HeaderText = "Автобус";
            this._sheduleColumnBusType.Name = "_sheduleColumnBusType";
            this._sheduleColumnBusType.ReadOnly = true;
            // 
            // _sheduleColumnRouteBeginEnd
            // 
            this._sheduleColumnRouteBeginEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._sheduleColumnRouteBeginEnd.HeaderText = "Маршрут";
            this._sheduleColumnRouteBeginEnd.Name = "_sheduleColumnRouteBeginEnd";
            this._sheduleColumnRouteBeginEnd.ReadOnly = true;
            // 
            // _sheduleColumnDate
            // 
            this._sheduleColumnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._sheduleColumnDate.HeaderText = "Дата";
            this._sheduleColumnDate.Name = "_sheduleColumnDate";
            this._sheduleColumnDate.ReadOnly = true;
            // 
            // _sheduleColumnTime
            // 
            this._sheduleColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._sheduleColumnTime.HeaderText = "Время";
            this._sheduleColumnTime.Name = "_sheduleColumnTime";
            this._sheduleColumnTime.ReadOnly = true;
            // 
            // _driverColumnBirthdate
            // 
            this._driverColumnBirthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._driverColumnBirthdate.HeaderText = "День Рождения";
            this._driverColumnBirthdate.Name = "_driverColumnBirthdate";
            // 
            // _driverColumnClass
            // 
            this._driverColumnClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._driverColumnClass.HeaderText = "Класс";
            this._driverColumnClass.Name = "_driverColumnClass";
            // 
            // _driverColumnExperience
            // 
            this._driverColumnExperience.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._driverColumnExperience.HeaderText = "Стаж";
            this._driverColumnExperience.Name = "_driverColumnExperience";
            // 
            // _driverColumnFullName
            // 
            this._driverColumnFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._driverColumnFullName.HeaderText = "ФИО";
            this._driverColumnFullName.Name = "_driverColumnFullName";
            // 
            // _driverColumnID
            // 
            this._driverColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._driverColumnID.HeaderText = "ID";
            this._driverColumnID.Name = "_driverColumnID";
            this._driverColumnID.Visible = false;
            // 
            // dataBaseBindingSource
            // 
            this.dataBaseBindingSource.DataSource = typeof(BusPark.DataBase);
            // 
            // BusStationForm
            // 
            this.ClientSize = new System.Drawing.Size(921, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "BusStationForm";
            this.tabControl1.ResumeLayout(false);
            this._tabDriverPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataDriverView)).EndInit();
            this._tabRoutePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataRouteGridView)).EndInit();
            this._tabBusPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataBusView)).EndInit();
            this._tabShedulePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataSheduleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void LoadDataSource()
        {
            OutputListToTable(ref _dataDriverView, DataBase.BusPark.Drivers, "ID", "ФИО", "Стаж", "Категория прав", "День рождения");
            _dataDriverView.Columns[0].Visible = false;

            OutputListToTable(ref _dataBusView, DataBase.BusPark.Buses, "ID", "Гос. Номер", "Марка", "Количество мест");
            _dataDriverView.Columns[0].Visible = false;
            //_dataDriverView.DataSource = DataBase.BusPark.Drivers;
        }

        private void OutputListToTable<ListContainData>(ref DataGridView table, List<ListContainData> data, params string[] columsName)
        {
            // Clear the table;
            table.Columns.Clear();
            table.Rows.Clear();
            table.Refresh();

            // Add all columns;
            for (int i = 0; i < columsName.Length; ++i)
            {
                table.Columns.Add(columsName[i], columsName[i]);
                table.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Fill data;
            for (int i = 0; i < data.Count; ++i)
            {
                table.Rows.Add(1);
                var d = data[i].ToString().Split('|');

                for (int j = 0; j < Math.Min(d.Length, columsName.Length); ++j)
                {
                    table.Rows[i].Cells[j].Value = d[j];
                }
            }
        }

        private void SaveDriverButtonClick(object sender, EventArgs e)
        {
            DataBase.BusPark.Drivers.Clear();

            for (int i = 0; i < _dataDriverView.RowCount - 1; ++i)
            {
                object[] data = new object[_dataDriverView.Columns.Count];
                for (int j = 0; j < data.Length; ++j)
                {
                    data[j] = _dataDriverView.Rows[i].Cells[j].Value;
                }

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
            OutputListToTable(ref _dataDriverView, DataBase.BusPark.Drivers, "ID", "ФИО", "Стаж", "Категория прав", "День рождения");
            _dataDriverView.Columns[0].Visible = false;
        }

        private void SaveBusButtonClick(object sender, EventArgs e)
        {
            DataBase.BusPark.Buses.Clear();

            for (int i = 0; i < _dataBusView.RowCount - 1; ++i)
            {
                object[] data = new object[_dataBusView.Columns.Count];
                for (int j = 0; j < data.Length; ++j)
                {
                    data[j] = _dataBusView.Rows[i].Cells[j].Value;
                }

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
            OutputListToTable(ref _dataBusView, DataBase.BusPark.Buses, "ID", "Гос. Номер", "Марка", "Количество мест");
            _dataDriverView.Columns[0].Visible = false;
        }
    }
}
