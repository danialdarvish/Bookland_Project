using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts
{
    public class PaymentMethod
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        private PaymentMethod(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public static List<PaymentMethod> GetList()
        {
            return new List<PaymentMethod>
            {
                new PaymentMethod(1, "پرداخت اینترنتی", "پرداخت از طریق درگاه ایمن زرین پال صورت می گیرد."),
                new PaymentMethod(2, "پرداخت نقدی", "پرداخت به شکل حضوری در هنگام تحویل صورت می گیرد.")
            };
        }

        public PaymentMethod GetBy(long id)
        {
            return GetList().FirstOrDefault(x => x.Id == id);
        }
    }
}
