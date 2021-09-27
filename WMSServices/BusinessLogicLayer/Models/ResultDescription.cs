namespace BusinessLogicLayer.Models
{
    /// <summary>
    /// Опис результату запиту
    /// </summary>
    public class ResultDescription
    {
        /// <summary>
        /// Числовий код помилки: <para>&#160;</para> 
        /// <para>&#8226;</para> 0 - Без помилок <para>&#160;</para> 
        /// <para>&#8226;</para> 1 - поле Livrea = Null <para>&#160;</para> 
        /// <para>&#8226;</para> 2 - помилка пов'язана з WMS MS SQL34 <para>&#160;</para> 
        /// <para>&#8226;</para> 3 - помилка пов'язана з WMS ORACLE SQL 
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Текст помилки
        /// </summary>
        public string Message { get; set; }
    }
}
