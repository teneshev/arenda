using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace arenda
{
    [Table(Name = "[Выданные автомобили]")]
    public class Выданные
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Код_проката { get; set; }
        [Column]
        public int Код_клиента { get; set; }
        [Column]
        public int Код_авто { get; set; }
        [Column]
        public DateTime Дата_выдачи { get; set; }
        [Column]
        public int Количество_дней { get; set; }
        [Column]
        public DateTime Ожидаемая_дата_возрата { get; set; }
        [Column]
        public int Наименование_скидки { get; set; }
        [Column]
        public int Сумма { get; set; }
        [Column]
        public int Штрафы { get; set; }
        [Column]
        public int Итоговая_сумма { get; set; }
    }
}
