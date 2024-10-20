using System.ComponentModel.DataAnnotations;

namespace CQRSDemo.Api.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }              // Уникальный идентификатор заказа
        [Required]
        public int CustomerId { get; set; }      // Идентификатор клиента, который сделал заказ
        public DateTime OrderDate { get; set; }  // Дата, когда был сделан заказ
        [Range(0, 10_000)]
        public decimal TotalAmount { get; set; } // Общая сумма заказа
        [Required]
        public string Status { get; set; } = string.Empty;      // Статус заказа (например, "Pending", "Completed", "Cancelled")
    }

}
