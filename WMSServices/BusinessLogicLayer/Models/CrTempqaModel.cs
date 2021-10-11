using System;

namespace BusinessLogicLayer.Models
{
    public class CrTempqaModel
    {
        /// <summary>
        /// Номер лоту
        /// </summary>
        public decimal Nlotpr { get; set; }
        /// <summary>
        /// Номер рядка лоту
        /// </summary>
        public decimal Nligpr { get; set; }
        /// <summary>
        /// Власник
        /// </summary>
        public string Donord { get; set; }
        /// <summary>
        /// Депо
        /// </summary>
        public string Depot { get; set; }
        /// <summary>
        /// Код EAN артикулу
        /// </summary>
        public string Ean { get; set; }
        /// <summary>
        /// Код артикулу
        /// </summary>
        public string Cproin { get; set; }
        /// <summary>
        /// Продажний варіант артикулу
        /// </summary>
        public string Arprom { get; set; }
        /// <summary>
        /// Логістичний варіант артикулу
        /// </summary>
        public string Ilogis { get; set; }
        /// <summary>
        /// Код одержувача лоту
        /// </summary>
        public string Livrea { get; set; }
        /// <summary>
        /// Факитчна кількість артикулу (WMS)
        /// </summary>
        public decimal Uvreel { get; set; }
        /// <summary>
        /// Фактична кількість артикулу (QA)
        /// </summary>
        public decimal? Qauvreel { get; set; }
        /// <summary>
        /// Код SHU
        /// </summary>
        public string Usscc { get; set; }
        /// <summary>
        /// Код упаковки
        /// </summary>
        public string Csscc { get; set; }
        /// <summary>
        /// Блок SHU (0-так, 1 – Ні)
        /// </summary>
        public string Block { get; set; }
        /// <summary>
        /// Поточний адрес зберігання 
        /// </summary>
        public string Adrums { get; set; }
        /// <summary>
        /// Дата створення запису
        /// </summary>
        public DateTime? Datcre { get; set; }
        /// <summary>
        /// Назва товару
        /// </summary>
        public string Libpro { get; set; }
    }
}
