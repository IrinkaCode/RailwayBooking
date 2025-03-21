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
    public class СвободныеМаршруты : INotifyPropertyChanged
    {
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

        private int idПеревозчика;
        [JsonPropertyName("idПеревозчика")]
        public int IdПеревозчика
        {
            get => idПеревозчика;
            set
            {
                idПеревозчика = value;
                OnProperyChanged(nameof(IdПеревозчика));
            }
        }

        private int idГородаОтправления;
        [JsonPropertyName("idГородаОтправления")]
        public int IdГородаОтправления
        {
            get => idГородаОтправления;
            set
            {
                idГородаОтправления = value;
                OnProperyChanged(nameof(IdГородаОтправления));
            }
        }

        private int idГородаПрибытия;
        [JsonPropertyName("idГородаПрибытия")]
        public int IdГородаПрибытия
        {
            get => idГородаПрибытия;
            set
            {
                idГородаПрибытия = value;
                OnProperyChanged(nameof(IdГородаПрибытия));
            }
        }

        private DateTime датаОтправления;
        [JsonPropertyName("датаОтправления")]
        public DateTime ДатаОтправления
        {
            get => датаОтправления;
            set
            {
                датаОтправления = value;
                OnProperyChanged(nameof(ДатаОтправления));
            }
        }


        private decimal цена;
        [JsonPropertyName("цена")]
        public decimal Цена
        {
            get => цена;
            set
            {
                цена = value;
                OnProperyChanged(nameof(Цена));
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
