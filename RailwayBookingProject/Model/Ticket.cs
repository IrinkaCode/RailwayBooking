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
    public class Ticket : INotifyPropertyChanged
    {
        private int билетId;
        [JsonPropertyName("билетId")]
        public int БилетId
        {
            get => билетId;
            set
            {
                билетId = value;
                OnProperyChanged(nameof(БилетId));
            }
        }


        private int номерМеста;
        [JsonPropertyName("номерМеста")]
        public int НомерМеста
        {
            get => номерМеста;
            set
            {
                номерМеста = value;
                OnProperyChanged(nameof(НомерМеста));
            }
        }

        private string? городОтправления;
        [JsonPropertyName("городОтправления")]
        public string ГородОтправления
        {
            get => городОтправления!;
            set
            {
                городОтправления = value;
                OnProperyChanged(nameof(ГородОтправления));
            }
        }

        private string? городПрибытия;
        [JsonPropertyName("городПрибытия")]
        public string? ГородПрибытия
        {
            get => городПрибытия;
            set
            {
                городПрибытия = value;
                OnProperyChanged(nameof(городПрибытия));
            }
        }

        private int idКлиента;
        [JsonPropertyName("idКлиента")]
        public int IdКлиента
        {
            get => idКлиента;
            set
            {
                idКлиента = value;
                OnProperyChanged(nameof(IdКлиента));
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
