//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coursework.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Заказы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказы()
        {
            this.Сведения_о_заказе = new HashSet<Сведения_о_заказе>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_Client { get; set; }
        public Nullable<int> ID_Work { get; set; }
        public Nullable<System.DateTime> Дата_размещения { get; set; }
        public Nullable<int> Номер_заказа { get; set; }
        public string Адрес { get; set; }
        public string Город { get; set; }
        public string Регион { get; set; }
        public string Телефон { get; set; }
        public Nullable<int> ID_Доставки { get; set; }
        public Nullable<decimal> Стоимость { get; set; }
    
        public virtual Доставка Доставка { get; set; }
        public virtual Клиенты Клиенты { get; set; }
        public virtual Сотрудники Сотрудники { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сведения_о_заказе> Сведения_о_заказе { get; set; }
    }
}
