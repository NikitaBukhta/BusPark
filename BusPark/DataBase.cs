using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusPark.BusStation;

namespace BusPark
{
    internal class DataBase
    {
        static public Park BusPark { get; set; } = new Park("1", "Pushkin street");

        static public string BusDBName { get; private set; } = "bus_db.txt";

        static public string DriverDBName { get; private set; } = "driver_db.txt";

        static public string RouteDBName { get; private set; } = "route_db.txt";

        static public string SheduleDBName { get; private set; } = "shedule_db.txt";

        static public string DBPath { get; set; } = "./data_bases";

        /* Description:
         * Add data to the file (in our case in data base);
         * For right method working you need to override 
         *      ToString() method!;
         *      
         * Args:
         * data - object you want to write to the file
         * dbPath - full path to the file;
         * 
         * Errors:
         * If some errors occured, message box will throw with
         *      error description;
         */
        static public void AddData<DataType>(DataType data, string dbPath)
        {
            try
            {
                CreateFileIfNotExists(dbPath);

                File.AppendAllText(dbPath, data.ToString() + "\n");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        /* Description:
         * Check if path is exists;
         * 
         * Args:
         * path - path we want to check for existing;
         * 
         * Return values:
         * Return true if path exists;
         * Otherwise false;
         */
        static private bool PathExists(string path)
        {
            return Directory.Exists(path) || File.Exists(path);
        }

        /* Description:
         * Create file and path if not exists to the file;
         * 
         * Args:
         * dbPath - path to the file and the file we want to create;
         * 
         * Return Value:
         * Return true if path was created;
         * Otherwise, return false;
         */
        static private bool CreateFileIfNotExists(string dbPath)
        {
            if (!PathExists(dbPath))
            {
                /* remove file name from a directory in order to not 
                 * create a file as a directory;
                 */
                Directory.CreateDirectory(Directory.GetParent(dbPath).FullName);
                // create a file;
                File.Create(dbPath).Close();

                return true;
            }

            return false;
        }

        /* Description:
         * Convert path + dbName to the full path;
         * In other words, that is wrapping of Path.Combine(string, string) method;
         * 
         * Args:
         * path - path to the file;
         * dbName - name of file;
         */
        static public string ConvertToFullPath(string path, string dbName)
        {
            return Path.Combine(path, dbName);
        }

        /* Description:
         * Rewrite file with new data;
         * 
         * Args:
         * data - list of objects that contains data we want to write;
         * dbPath - full path to the file;
         */
        static public void RewriteDataBase<DataType>(List<DataType> data, string dbPath)
        {
            // clear file;
            File.WriteAllText(dbPath, string.Empty);

            foreach (var d in data)
            {
                AddData(d, dbPath);
            }
        }

        /* Desctiption:
         * Read all data bases from the files;
         * Data bases:
         *  1) bus_db.txt;
         *  2) driver_db.txt;
         *  3) route_db.txt;
         *  4) shedule_db.txt;
         */
        static public void ReadDBs()
        {
            ReadBus();
            ReadDrivers();
            ReadRoute();
            ReadShedule();
        }

        static public void ReadDrivers()
        {
            BusPark.Drivers.Clear();
            string fullPath = ConvertToFullPath(DBPath, DriverDBName);

            // if file was created, is empty. So go out from the method;
            if (CreateFileIfNotExists(fullPath))
            {
                return;
            }

            uint rightArgsCount = 5;
            uint currentLine = 0;
            // Read the file and add data to the library  
            foreach (string line in System.IO.File.ReadLines(fullPath))
            {
                ++currentLine;
                var data = line.Split('|');

                try
                {
                    // if line does not contain enought count of args;
                    if (data.Count() != rightArgsCount)
                    {
                        throw new ArgumentException($"No right count of args in line {currentLine}");
                    }
                }
                catch(ArgumentException error)
                {
                    MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    continue;
                }


                BusPark.Drivers.Add(new Driver(data[1].ToString(), (float)Convert.ToDouble(data[2]),
                    data[3].ToString(), Convert.ToDateTime(data[4]), Convert.ToUInt64(data[0])));
            }
        }

        static public void ReadShedule()
        {
            BusPark.Shedules.Clear();
            string fullPath = ConvertToFullPath(DBPath, SheduleDBName);

            // if file was created, is empty. So go out from the method;
            if (CreateFileIfNotExists(fullPath))
            {
                return;
            }

            uint rightArgsCount = 4;
            uint currentLine = 0;
            // Read the file and add data to the library  
            foreach (string line in System.IO.File.ReadLines(fullPath))
            {
                ++currentLine;
                var data = line.Split('|');

                try
                {
                    // if line does not contain enought count of args;
                    if (data.Count() != rightArgsCount)
                    {
                        throw new ArgumentException($"No right count of args in line {currentLine}");
                    }
                }
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    continue;
                }

                BusPark.Shedules.Add(new Shedule(Convert.ToUInt64(data[0]), Convert.ToUInt64(data[1]), 
                    Convert.ToUInt64(data[2]), Convert.ToDateTime(data[3])));
            }
        }

        static public void ReadBus()
        {
            BusPark.Buses.Clear();
            string fullPath = ConvertToFullPath(DBPath, BusDBName);

            // if file was created, is empty. So go out from the method;
            if (CreateFileIfNotExists(fullPath))
            {
                return;
            }

            uint rightArgsCount = 4;
            uint currentLine = 0;
            // Read the file and add data to the library  
            foreach (string line in System.IO.File.ReadLines(fullPath))
            {
                ++currentLine;
                var data = line.Split('|');

                try
                {
                    // if line does not contain enought count of args;
                    if (data.Count() != rightArgsCount)
                    {
                        throw new ArgumentException($"No right count of args in line {currentLine}");
                    }
                }
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    continue;
                }

                BusPark.Buses.Add(new Bus(data[1].ToString(), data[2].ToString(), 
                    Convert.ToUInt16(data[3]), Convert.ToUInt64(data[0])));
            }
        }

        static public void ReadRoute()
        {
            BusPark.Routes.Clear();
            string fullPath = ConvertToFullPath(DBPath, RouteDBName);

            // if file was created, is empty. So go out from the method;
            if (CreateFileIfNotExists(fullPath))
            {
                return;
            }

            uint rightArgsCount = 6;
            uint currentLine = 0;
            // Read the file and add data to the library  
            foreach (string line in System.IO.File.ReadLines(fullPath))
            {
                ++currentLine;
                var data = line.Split('|');

                try
                {
                    // if line does not contain enought count of args;
                    if (data.Count() != rightArgsCount)
                    {
                        throw new ArgumentException($"No right count of args in line {currentLine}");
                    }
                }
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    continue;
                }

                BusPark.Routes.Add(new Route(Convert.ToUInt16(data[1]), data[2].ToString(),
                    data[3].ToString(), Convert.ToUInt16(data[4]), Convert.ToUInt16(data[5]),
                    Convert.ToUInt64(data[6])));
            }
        }
    }
}
