using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiThreadCollection
{
    public class Model
    {
        private object _lockObject = new object();

        public ObservableCollection<string> List { get; set; } = new ObservableCollection<string>();

        public Model()
        {
            BindingOperations.EnableCollectionSynchronization(List, _lockObject);
        }

        public async Task Add()
        {
            await Task.Run(() =>
            {
                for (var i = 0; i < 100; i++)
                {
                    List.Add("hoge" + i.ToString());
                }
            });
        }
    }
}
