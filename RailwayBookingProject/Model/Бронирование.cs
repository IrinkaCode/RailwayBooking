using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RailwayBookingProject.Model
{
    public class Бронирование : INotifyPropertyChanged
    {
        private int idБронирования;
        [JsonPropertyName("idБронирования")]
        public int IdБронирования
        {
            get => idБронирования;
            set
            {
                idБронирования = value;
                OnProperyChanged(nameof(IdБронирования));
            }
        }

        private int idКлиента;
        [JsonPropertyName("firstname")]
        public int IdКлиента
        {
            get => idКлиента;
            set
            {
                idКлиента = value;
                OnProperyChanged(nameof(IdКлиента));
            }
        }

        private int idМаршрута;
        [JsonPropertyName("idМаршрута")]
        public int IdМаршрута
        {
            get => idМаршрута;
            set
            {
                idМаршрута = value;
                OnProperyChanged(nameof(IdМаршрута));
            }
        }

        private DateTime датаБронирования;
        [JsonPropertyName("датаБронирования")]
        public DateTime ДатаБронирования
        {
            get => датаБронирования;
            set
            {
                датаБронирования = value;
                OnProperyChanged(nameof(ДатаБронирования));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnProperyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
