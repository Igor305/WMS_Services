using System.Collections.Generic;

namespace BusinessLogicLayer.Models.Response
{
    public class CrTempqaResponseModel
    {
        public List<CrTempqaModel> crTempqaModels { get; set; }
        /// <summary>
        /// Числовий код помилки: <para>&#160;</para> 
        /// <para>&#8226;</para> 0 - Без помилок <para>&#160;</para> 
        /// <para>&#8226;</para> 1 - помилка пов'зана з внесеними данними <para>&#160;</para> 
        /// <para>&#8226;</para> 2 - помилка пов'язана з WMS MS SQL34 <para>&#160;</para> 
        /// <para>&#8226;</para> 3 - помилка пов'язана з WMS ORACLE SQL 
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// Текст помилки
        /// </summary>
        public string Message { get; set; }

        public CrTempqaResponseModel()
        {
            crTempqaModels = new List<CrTempqaModel>();
        }
    }
}
