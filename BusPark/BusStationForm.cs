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
        private Button _saveDriverButton;
        private Button _saveBusButton;
        private BindingSource dataBaseBindingSource;
        private IContainer components;
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
            this._tabBusPage = new System.Windows.Forms.TabPage();
            this._saveBusButton = new System.Windows.Forms.Button();
            this._dataBusView = new System.Windows.Forms.DataGridView();
            this._tabShedulePage = new System.Windows.Forms.TabPage();
            this._dataSheduleView = new System.Windows.Forms.DataGridView();
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
            _dataBusView.Columns[0].Visible = false;

            OutputListToTable(ref _dataRouteGridView, DataBase.BusPark.Routes, "ID", "Номер маршрута", "Начало", "Конец", "Протяжённость в минутах", "Интервал");
            _dataRouteGridView.Columns[0].Visible = false;

            CreateColums(ref _dataSheduleView, "Водитель", "Автобус", "Маршрут", "Дата", "Время");
            OutputShedule();

            //_dataDriverView.DataSource = DataBase.BusPark.Drivers;
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
        }

        /* Description:
         * Fill the table with your data
         * 
         * Args:
         * table - data grid view we want to fill;
         * data - data we want to output; 
         * columsName - how we want to call the colums;
         */
        private void OutputListToTable<ListContainData>(ref DataGridView table, List<ListContainData> data, params string[] columsName)
        {
            // Clear the table;
            table.Columns.Clear();
            table.Rows.Clear();
            table.Refresh();

            CreateColums(ref table, columsName);

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
                                   route = r.Begin + " - " + r.End,
                                   date = shed.DepartureTime.ToString("dd.MM.yyyy"),
                                   time = shed.DepartureTime.ToString("hh:mm:ss")
                               }).ToList();

            for (int i = 0; i < outputValues.Count; ++i)
            {
                _dataSheduleView.Rows.Add(1);

                _dataSheduleView.Rows[i].Cells[0].Value = outputValues[i].driver;
                _dataSheduleView.Rows[i].Cells[1].Value = outputValues[i].bus;
                _dataSheduleView.Rows[i].Cells[2].Value = outputValues[i].route;
                _dataSheduleView.Rows[i].Cells[3].Value = outputValues[i].date;
                _dataSheduleView.Rows[i].Cells[4].Value = outputValues[i].time;
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
            OutputListToTable(ref _dataDriverView, DataBase.BusPark.Drivers, "ID", "ФИО", "Стаж", "Категория прав", "День рождения");
            _dataDriverView.Columns[0].Visible = false;
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
            OutputListToTable(ref _dataBusView, DataBase.BusPark.Buses, "ID", "Гос. Номер", "Марка", "Количество мест");
            _dataBusView.Columns[0].Visible = false;
        }
    }
}
