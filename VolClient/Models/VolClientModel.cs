using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace VolClient.Models
{
    class VolClientModel: INotifyPropertyChanged
    {
        private bool _isDone;
        private string _text;
        public DateTime TimeTable { get; set; } = DateTime.Now;
        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
