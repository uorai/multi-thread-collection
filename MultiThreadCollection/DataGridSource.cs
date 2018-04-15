using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadCollection
{
    public class DataGridSource : ModelBase
    {
        private string _columnA;
        private string _columnB;
        private string _columnC;
        private string _columnD;
        private string _columnE;
        private string _columnF;
        private string _columnG;
        private string _columnH;
        private string _columnI;
        private string _columnJ;

        public string ColumnA
        {
            get { return _columnA; }
            set { SetProperty(ref _columnA, value); }
        }

        public string ColumnB
        {
            get { return _columnB; }
            set { SetProperty(ref _columnB, value); }
        }

        public string ColumnC
        {
            get { return _columnC; }
            set { SetProperty(ref _columnC, value); }
        }

        public string ColumnD
        {
            get { return _columnD; }
            set { SetProperty(ref _columnD, value); }
        }

        public string ColumnE
        {
            get { return _columnE; }
            set { SetProperty(ref _columnE, value); }
        }

        public string ColumnF
        {
            get { return _columnF; }
            set { SetProperty(ref _columnF, value); }
        }

        public string ColumnG
        {
            get { return _columnG; }
            set { SetProperty(ref _columnG, value); }
        }

        public string ColumnH
        {
            get { return _columnH; }
            set { SetProperty(ref _columnH, value); }
        }

        public string ColumnI
        {
            get { return _columnI; }
            set { SetProperty(ref _columnI, value); }
        }

        public string ColumnJ
        {
            get { return _columnJ; }
            set { SetProperty(ref _columnJ, value); }
        }
    }
}
