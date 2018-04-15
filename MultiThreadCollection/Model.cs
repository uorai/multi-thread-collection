using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiThreadCollection
{
    public class Model
    {
        private static Model _model = new Model();
        private object _lockObject = new object();

        public ObservableCollection<DataGridSource> List { get; set; } = new ObservableCollection<DataGridSource>();

        private Model()
        {
            BindingOperations.EnableCollectionSynchronization(List, _lockObject);
        }
        public static Model GetInstance()
        {
            return _model;
        }

        public async Task Add()
        {
            await Task.Run(() =>
            {
                List.Clear();

                Parallel.For(0, 100, i =>
                {
                    var source = new DataGridSource()
                    {
                        ColumnA = "A" + i.ToString(),
                        ColumnB = "B" + i.ToString(),
                        ColumnC = "C" + i.ToString(),
                        ColumnD = "D" + i.ToString(),
                        ColumnE = "E" + i.ToString(),
                        ColumnF = "F" + i.ToString(),
                        ColumnG = "G" + i.ToString(),
                        ColumnH = "H" + i.ToString(),
                        ColumnI = "I" + i.ToString(),
                        ColumnJ = "J" + i.ToString()
                    };

                    lock (_lockObject)
                    {
                        List.Add(source);
                    }
                });
            });
        }
    }
}
