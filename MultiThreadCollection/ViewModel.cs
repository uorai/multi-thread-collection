﻿using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MultiThreadCollection
{
    public class ViewModel
    {
        private Model _model = Model.GetInstance();

        public ObservableCollection<DataGridSource> List
        {
            get { return _model.List; }
            set { _model.List = value; }
        }

        public AsyncReactiveCommand Command { get; }

        public ViewModel()
        {
            Command = new AsyncReactiveCommand();
            Command.Subscribe(async _ =>
            {
                await _model.Add();
            });
        }
    }
}
