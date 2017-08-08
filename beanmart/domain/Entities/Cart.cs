using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        //Them moi 1 san pham vao gio hang
        public void AddItem(Bean bean, int quantity)
        {
            CartLine line = lineCollection.Where(b => b.Bean.ID == bean.ID).FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine { Bean = bean, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        //Xoa 1 san pham khoi gio hang
        public void RemoveLine(Bean bean)
        {
            lineCollection.RemoveAll(r => r.Bean.ID == bean.ID);
        }
        //Tinh tong so tien cua cac san pham trong gio  hang.
        public decimal TotalCart()
        {
            return lineCollection.Sum(t => t.Bean.Price * t.Quantity);
        }
        //Xoa tat ca cac san pham co trong gio hang
        public void Clear()
        {
            lineCollection.Clear();
        }
        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }
    // Lop Cartline chua doi tuong Bean va truong quantity
    public class CartLine
    {
        public Bean Bean { get; set; }
        public int Quantity { get; set; }
    }
}
